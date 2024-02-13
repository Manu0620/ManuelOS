using ManuelOS.Classes;

using System.Windows.Media;

namespace ManuelOS
{
    public partial class MusicPlayer : UserControl
    {
        List<Song> songsList = new List<Song>();
        public MediaPlayer mediaPlayer = new MediaPlayer();
        bool isPause = false;
        int songIndex = 0;
        List<Window> openWindows = new List<Window>();

        public MusicPlayer()
        {
            InitializeComponent();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            songsList.Add(new Song("Tirate @Izy Music", "Donaty", @"C:\Users\Manuel\Music\ManuelOSongs\DONATY-TIRATE.mp3"));
            songsList.Add(new Song("ONANA Ni2Ni3", "Jey One", @"C:\Users\Manuel\Music\ManuelOSongs\ONANA-JEY ONE.mp3"));
            songsList.Add(new Song("De Mi Enamorate", "Tito Nieves", @"C:\Users\Manuel\Music\ManuelOSongs\DE MI ENAMORATE.mp3"));
            songsList.Add(new Song("Feliz Navidad Peppa Pig", "Arcangel", @"C:\Users\Manuel\Music\ManuelOSongs\Feliz Navidad Peppa Pig.mp3"));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null && !isPause)
            {
                if (mediaPlayer.NaturalDuration.HasTimeSpan && mediaPlayer.Position < mediaPlayer.NaturalDuration)
                {
                    double progress = mediaPlayer.Position.TotalSeconds / mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                    songDuration.Value = (int)(progress * 100);
                }
            }
            if (songDuration.Value == 99)
            {
                pauseMusic.Visible = false;
                playMusic.Visible = true;
                songDuration.Value = 0;
                if (songIndex < songsList.Count - 1)
                {
                    songIndex++;
                    PlaySong(songIndex);
                }
            }
        }

        private void PlaySong(int indice)
        {
            if (indice >= 0 && indice < songsList.Count)
            {
                // Detener la canción actual si hay una reproduciéndose
                if (mediaPlayer.Source != null)
                    mediaPlayer.Stop();

                // Cargar y reproducir la nueva canción
                mediaPlayer.Open(new Uri(songsList[songIndex].Path));
                titleLabel.Text = songsList[songIndex].Title;
                artistLabel.Text = songsList[songIndex].Artist;
                mediaPlayer.Play();

                songIndex = indice;
                pauseMusic.Visible = true;
                playMusic.Visible = false;
                titleLabel.Visible = true;
                artistLabel.Visible = true;

            }
        }

        private void btnPlay_click(object sender, EventArgs e)
        {
            if (isPause)
            {
                mediaPlayer.Play();
                pauseMusic.Visible = true;
                playMusic.Visible = false;
                isPause = false;
                return;
            }
            PlaySong(songIndex);
        }

        private void pauseMusic_Click(object sender, EventArgs e)
        {
            // Pausar la canción
            mediaPlayer.Pause();
            isPause = true;
            pauseMusic.Visible = false;
            playMusic.Visible = true;
        }

        private void musicIcon_Click(object sender, EventArgs e)
        {
            // Abrir la lista de canciones en una nueva ventana
            Window window = new Window();
            window.SetTitle("Songs");
            contentPanel.Controls.Add(window);
            window.Location = new Point(20, 20);
            window.Size = new Size(410, 250);
            window.BringToFront();

            SongsList songList = new SongsList();
            songList.Dock = DockStyle.Fill;
            Panel? windowPanel = window.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
            ListView? listView = songList.Controls.Find("songList", true).FirstOrDefault() as ListView;
            foreach (Song song in songsList)
            {
                ListViewItem item = new ListViewItem($"{song.Title} | {song.Artist}");
                listView?.Items.Add(item);
            }
            songList.onSongSelected += SongList_onSongSelected;

            openWindows.Add(window);
            window.onClose += window_onClose;

            Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    windowPanel.Controls.Add(songList);
                }));
            });
        }

        private void backMusic_Click(object sender, EventArgs e)
        {
            if (songIndex > 0)
            {
                songIndex--;
                mediaPlayer.Stop();
                PlaySong(songIndex);
                songDuration.Value = 0;
            }
        }

        private void nextSong_Click(object sender, EventArgs e)
        {
            if (songIndex < songsList.Count - 1)
            {
                songIndex++;
                mediaPlayer.Stop();
                PlaySong(songIndex);
                songDuration.Value = 0;
            }
        }

        private void SongList_onSongSelected(object sender, EventArgs e)
        {
            SongsList songList = sender as SongsList;
            ListView? songs = songList.Controls.Find("songList", true).FirstOrDefault() as ListView;

            // Obtener el indice de la canción seleccionada y buscarla en songsList para reproducirla y reiniciar los indices seleccionados
            if (songs?.SelectedIndices.Count > 0)
            {
                songIndex = songs.SelectedIndices[0];
                PlaySong(songIndex);
                songDuration.Value = 0;
                songs.SelectedIndices.Clear();
            }
        }

        private void window_onClose(object sender, EventArgs e)
        {
            Window window = sender as Window;
            openWindows.Remove(window);
            contentPanel.Controls.Remove(window);
        }


        private void songDuration_MouseDown(object sender, MouseEventArgs e)
        {
            int mouseX = e.Location.X;
            int progressBarWidth = songDuration.Width;

            double percentageClicked = (double)mouseX / progressBarWidth;

            double totalSeconds = mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds;
            double timeClicked = totalSeconds * percentageClicked;
            mediaPlayer.Position = TimeSpan.FromSeconds(timeClicked);
        }
    }
}
