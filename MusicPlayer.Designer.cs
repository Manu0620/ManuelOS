namespace ManuelOS
{
    partial class MusicPlayer
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            contentPanel = new Panel();
            artistLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            songDuration = new Guna.UI2.WinForms.Guna2ProgressBar();
            nextSong = new FontAwesome.Sharp.IconPictureBox();
            playMusic = new FontAwesome.Sharp.IconPictureBox();
            backMusic = new FontAwesome.Sharp.IconPictureBox();
            musicIcon = new FontAwesome.Sharp.IconPictureBox();
            pauseMusic = new FontAwesome.Sharp.IconPictureBox();
            panel1 = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextSong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playMusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backMusic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)musicIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pauseMusic).BeginInit();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(18, 18, 18);
            contentPanel.Controls.Add(artistLabel);
            contentPanel.Controls.Add(titleLabel);
            contentPanel.Controls.Add(iconPictureBox2);
            contentPanel.Controls.Add(guna2HtmlLabel1);
            contentPanel.Controls.Add(songDuration);
            contentPanel.Controls.Add(nextSong);
            contentPanel.Controls.Add(playMusic);
            contentPanel.Controls.Add(backMusic);
            contentPanel.Controls.Add(musicIcon);
            contentPanel.Controls.Add(pauseMusic);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(800, 400);
            contentPanel.TabIndex = 0;
            // 
            // artistLabel
            // 
            artistLabel.Anchor = AnchorStyles.Top;
            artistLabel.AutoSize = false;
            artistLabel.BackColor = Color.Transparent;
            artistLabel.Font = new Font("Roboto Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            artistLabel.ForeColor = Color.PaleGreen;
            artistLabel.Location = new Point(235, 288);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(307, 25);
            artistLabel.TabIndex = 18;
            artistLabel.Text = "Artist";
            artistLabel.TextAlignment = ContentAlignment.MiddleCenter;
            artistLabel.Visible = false;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top;
            titleLabel.AutoSize = false;
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.PaleGreen;
            titleLabel.Location = new Point(88, 263);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(599, 25);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "Titulo";
            titleLabel.TextAlignment = ContentAlignment.MiddleCenter;
            titleLabel.Visible = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top;
            iconPictureBox2.BackColor = Color.FromArgb(18, 18, 18);
            iconPictureBox2.Enabled = false;
            iconPictureBox2.ForeColor = Color.PaleGreen;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Spotify;
            iconPictureBox2.IconColor = Color.PaleGreen;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 159;
            iconPictureBox2.Location = new Point(310, 103);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(159, 159);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 15;
            iconPictureBox2.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.Top;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Roboto", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.PaleGreen;
            guna2HtmlLabel1.Location = new Point(328, 48);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(118, 46);
            guna2HtmlLabel1.TabIndex = 14;
            guna2HtmlLabel1.Text = "Spotify";
            guna2HtmlLabel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // songDuration
            // 
            songDuration.Anchor = AnchorStyles.Top;
            songDuration.BackColor = Color.Transparent;
            songDuration.BorderColor = Color.PaleGreen;
            songDuration.BorderRadius = 5;
            songDuration.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            songDuration.BorderThickness = 1;
            songDuration.CustomizableEdges = customizableEdges1;
            songDuration.FillColor = Color.FromArgb(32, 32, 32);
            songDuration.Location = new Point(14, 327);
            songDuration.Name = "songDuration";
            songDuration.ProgressColor = Color.PaleGreen;
            songDuration.ProgressColor2 = Color.FromArgb(32, 32, 32);
            songDuration.ShadowDecoration.Color = Color.PaleGreen;
            songDuration.ShadowDecoration.CustomizableEdges = customizableEdges2;
            songDuration.ShadowDecoration.Depth = 10;
            songDuration.ShadowDecoration.Enabled = true;
            songDuration.Size = new Size(766, 8);
            songDuration.TabIndex = 13;
            songDuration.Text = "guna2ProgressBar1";
            songDuration.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Value;
            songDuration.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            songDuration.MouseDown += songDuration_MouseDown;
            // 
            // nextSong
            // 
            nextSong.Anchor = AnchorStyles.Top;
            nextSong.BackColor = Color.FromArgb(18, 18, 18);
            nextSong.ForeColor = Color.PaleGreen;
            nextSong.IconChar = FontAwesome.Sharp.IconChar.Forward;
            nextSong.IconColor = Color.PaleGreen;
            nextSong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nextSong.IconSize = 42;
            nextSong.Location = new Point(423, 342);
            nextSong.Margin = new Padding(5);
            nextSong.Name = "nextSong";
            nextSong.Size = new Size(42, 42);
            nextSong.TabIndex = 12;
            nextSong.TabStop = false;
            nextSong.Click += nextSong_Click;
            // 
            // playMusic
            // 
            playMusic.Anchor = AnchorStyles.Top;
            playMusic.BackColor = Color.FromArgb(18, 18, 18);
            playMusic.ForeColor = Color.PaleGreen;
            playMusic.IconChar = FontAwesome.Sharp.IconChar.Play;
            playMusic.IconColor = Color.PaleGreen;
            playMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            playMusic.IconSize = 42;
            playMusic.Location = new Point(371, 342);
            playMusic.Margin = new Padding(5);
            playMusic.Name = "playMusic";
            playMusic.Size = new Size(42, 42);
            playMusic.TabIndex = 11;
            playMusic.TabStop = false;
            playMusic.Click += btnPlay_click;
            // 
            // backMusic
            // 
            backMusic.Anchor = AnchorStyles.Top;
            backMusic.BackColor = Color.FromArgb(18, 18, 18);
            backMusic.ForeColor = Color.PaleGreen;
            backMusic.IconChar = FontAwesome.Sharp.IconChar.Backward;
            backMusic.IconColor = Color.PaleGreen;
            backMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            backMusic.IconSize = 42;
            backMusic.Location = new Point(319, 342);
            backMusic.Margin = new Padding(5);
            backMusic.Name = "backMusic";
            backMusic.Size = new Size(42, 42);
            backMusic.TabIndex = 10;
            backMusic.TabStop = false;
            backMusic.Click += backMusic_Click;
            // 
            // musicIcon
            // 
            musicIcon.Anchor = AnchorStyles.Top;
            musicIcon.BackColor = Color.FromArgb(18, 18, 18);
            musicIcon.ForeColor = Color.PaleGreen;
            musicIcon.IconChar = FontAwesome.Sharp.IconChar.ItunesNote;
            musicIcon.IconColor = Color.PaleGreen;
            musicIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            musicIcon.IconSize = 42;
            musicIcon.Location = new Point(14, 342);
            musicIcon.Name = "musicIcon";
            musicIcon.Size = new Size(42, 42);
            musicIcon.TabIndex = 9;
            musicIcon.TabStop = false;
            musicIcon.Click += musicIcon_Click;
            // 
            // pauseMusic
            // 
            pauseMusic.Anchor = AnchorStyles.Top;
            pauseMusic.BackColor = Color.FromArgb(18, 18, 18);
            pauseMusic.ForeColor = Color.PaleGreen;
            pauseMusic.IconChar = FontAwesome.Sharp.IconChar.Pause;
            pauseMusic.IconColor = Color.PaleGreen;
            pauseMusic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            pauseMusic.IconSize = 42;
            pauseMusic.Location = new Point(371, 342);
            pauseMusic.Margin = new Padding(5);
            pauseMusic.Name = "pauseMusic";
            pauseMusic.Size = new Size(42, 42);
            pauseMusic.TabIndex = 16;
            pauseMusic.TabStop = false;
            pauseMusic.Visible = false;
            pauseMusic.Click += pauseMusic_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 28);
            panel1.TabIndex = 1;
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // MusicPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(contentPanel);
            Name = "MusicPlayer";
            Size = new Size(800, 400);
            Load += MusicPlayer_Load;
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextSong).EndInit();
            ((System.ComponentModel.ISupportInitialize)playMusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)backMusic).EndInit();
            ((System.ComponentModel.ISupportInitialize)musicIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pauseMusic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private FontAwesome.Sharp.IconPictureBox musicIcon;
        private FontAwesome.Sharp.IconPictureBox nextSong;
        private FontAwesome.Sharp.IconPictureBox playMusic;
        private FontAwesome.Sharp.IconPictureBox backMusic;
        private Guna.UI2.WinForms.Guna2ProgressBar songDuration;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Timer timer;
        private FontAwesome.Sharp.IconPictureBox pauseMusic;
        private Guna.UI2.WinForms.Guna2HtmlLabel artistLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
    }
}
