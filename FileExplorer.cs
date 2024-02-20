using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ManuelOS
{
    public partial class FileExplorer : UserControl
    {
        public string mp3Path = "";
        public string openFile = "";
        public string currentPath = "";

        private Task taskMusic, taskText;
        CancellationTokenSource tokenCancelMusic, tokenCancelText;

        public MusicPlayer musicPlayer;
        public TextEditor textEditor;
        public Window musicWindow, textWindow;
        public FileExplorer()
        {
            InitializeComponent();
        }

        private void documentsDir_Click(object sender, EventArgs e)
        {
            string appPath = getAppDirectory();
            string fullPath = System.IO.Path.Combine(appPath, "Storage", "Documents");

            getFiles(fullPath);
        }

        private void musicDir_Click(object sender, EventArgs e)
        {
            string appPath = getAppDirectory();
            string fullPath = System.IO.Path.Combine(appPath, "Storage", "Music");

            getFiles(fullPath);
        }

        private void downloadDir_Click(object sender, EventArgs e)
        {
            // Obtener la ruta de descarga de windows
            string fullPath = "D:\\Descargas";

            getFiles(fullPath);

        }

        private void recycleDir_Click(object sender, EventArgs e)
        {
            string appPath = getAppDirectory();
            string fullPath = System.IO.Path.Combine(appPath, "Storage", "Recycle Bin");

            getFiles(fullPath);
        }

        private void directoryFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == - 1)
                return;

            string path = directoryFiles.Rows[e.RowIndex].Cells[4].Value.ToString();

            if (directoryFiles.SelectedRows[0].Cells[2].Value.ToString() == ".mp3")
            {
                tokenCancelMusic = new CancellationTokenSource();
                CancellationToken token = tokenCancelMusic.Token;

                if (musicWindow != null)
                {
                    if (musicWindow.isMinimized)
                    {
                        musicWindow.Show();
                        mp3Path = path;
                        musicPlayer_onSongSended(musicPlayer, new EventArgs());
                        return;
                    }
                }

                musicWindow = new Window();
                musicWindow.SetTitle("Spotify Premium");
                musicWindow.Location = new Point(120, 120);
                musicWindow.Size = new Size(800, 400);
                Panel? iPanel = musicWindow.Controls.Find("infoPanel", true).FirstOrDefault() as Panel;
                iPanel.Size = new Size(800, 28);

                musicPlayer = new MusicPlayer();
                Panel? contentPanel = musicWindow.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
                musicPlayer.Dock = DockStyle.Fill;

                musicPlayer.onSongSended += musicPlayer_onSongSended;
                mp3Path = path;

                contentPanel?.Controls.Add(musicPlayer);

                musicWindow.onClose += window_onClose;

                taskMusic = Task.Run(() =>
                {
                    Invoke((Action)(() =>
                    {
                        this.Controls.Add(musicWindow);

                        musicWindow.BringToFront();
                    }));
                }, token);

            }

            string file = directoryFiles.SelectedRows[0].Cells[4].Value.ToString(); 

            if (directoryFiles.SelectedRows[0].Cells[2].Value.ToString() == ".txt")
            {
                tokenCancelText = new CancellationTokenSource();
                CancellationToken token = tokenCancelText.Token;

                if (textWindow != null)
                {
                    if (textWindow.isMinimized)
                    {
                        textWindow.Show();
                        openFile = file;
                        textEditor_onFileSended(textEditor, new EventArgs());
                        return;
                    }
                }

                textWindow = new Window();
                textWindow.SetTitle("Text Editor");
                textWindow.Location = new Point(120, 120);
                textWindow.Size = new Size(900, 600);
                Panel? iPanel = textWindow.Controls.Find("infoPanel", true).FirstOrDefault() as Panel;
                iPanel.Size = new Size(900, 28);

                textEditor = new TextEditor();
                Panel? contentPanel = textWindow.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
                textEditor.Dock = DockStyle.Fill;

                textEditor.OnFileSended += textEditor_onFileSended;
                openFile = file;

                contentPanel?.Controls.Add(textEditor);

                textWindow.onClose += window_onClose;

                taskText = Task.Run(() =>
                {
                    Invoke((Action)(() =>
                    {
                        this.Controls.Add(textWindow);

                        textWindow.BringToFront();
                    }));
                }, token);
            }

            if (directoryFiles.SelectedRows[0].Cells[2].Value.ToString() == "Folder")
            {
                getFiles(path);
            }

        }

        private void musicPlayer_onSongSended(object? sender, EventArgs e)
        {
            MusicPlayer musicPlayer = sender as MusicPlayer;
            string fileName = System.IO.Path.GetFileName(mp3Path);
            musicPlayer?.ReceiveSong(mp3Path, fileName);
        }

        private void textEditor_onFileSended(object? sender, EventArgs e)
        {
            TextEditor textEditor = sender as TextEditor;
            textEditor?.ReceiveFile(openFile);
        }


        private void directoryFiles_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void directoryFiles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void changeNameMn_Click(object sender, EventArgs e)
        {
            if(directoryFiles.SelectedRows.Count > 1)
                return;

            //Abrir un cuadro de diálogo para cambiar el nombre del archivo o carpeta
            if (directoryFiles.SelectedRows.Count > 0)
            {
                string name = directoryFiles.SelectedRows[0].Cells[0].Value.ToString();
                string path = directoryFiles.SelectedRows[0].Cells[4].Value.ToString();
                string extension = directoryFiles.SelectedRows[0].Cells[2].Value.ToString();
                // Pedir el nuevo nombre sin la extensión
                string newName = Microsoft.VisualBasic.Interaction.InputBox("Introduce the new name", "Change name", name);


                if (newName != "")
                {
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Move(path, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), newName + extension));
                    }
                    else if (System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.Move(path, System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), newName));
                    }
                }

                // Actualizar el DataGridView
                string fullPath = System.IO.Path.GetDirectoryName(path);

                getFiles(fullPath);
            }

        }

        private void deleteMn_Click(object sender, EventArgs e)
        {
            
            // Eliminar el o los archivos o carpetas seleccionados
            if (directoryFiles.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in directoryFiles.SelectedRows)
                {
                    string path = row.Cells[4].Value.ToString();
                    string appPath = getAppDirectory();
                    string movePath = System.IO.Path.Combine(appPath, "Storage", "Recycle Bin");
                    if (System.IO.File.Exists(path))
                    {
                        if(path.Contains(movePath))
                        {
                            System.IO.File.Delete(path);
                        }
                        else
                        {
                            System.IO.File.Move(path, System.IO.Path.Combine(movePath, System.IO.Path.GetFileName(path)));
                        }
                    }
                    else if (System.IO.Directory.Exists(path))
                    {
                        if (path.Contains(movePath))
                        {
                            System.IO.Directory.Delete(path);
                        }
                        else
                        {
                            System.IO.Directory.Move(path, System.IO.Path.Combine(movePath, System.IO.Path.GetFileName(path)));
                        }
                    }
                }

                // Actualizar el DataGridView
                string fullPath = System.IO.Path.GetDirectoryName(directoryFiles.SelectedRows[0].Cells[4].Value.ToString());

                getFiles(fullPath);
            }
        }

        private void newFolder_Click(object sender, EventArgs e)
        {
            if (currentPath != "")
            {
                string newFolderName = Microsoft.VisualBasic.Interaction.InputBox("Introduce the new folder name", "New folder", "New folder");
                if (newFolderName != "")
                {
                    string newFolderPath = System.IO.Path.Combine(currentPath, newFolderName);
                    System.IO.Directory.CreateDirectory(newFolderPath);
                    getFiles(currentPath);
                }
            }
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            if (currentPath != "")
            {
                string newFileName = Microsoft.VisualBasic.Interaction.InputBox("Introduce the new file name", "New file", "New file");
                if (newFileName != "")
                {
                    string newFilePath = System.IO.Path.Combine(currentPath, newFileName);
                    System.IO.File.Create(newFilePath);
                    getFiles(currentPath);
                }
            }
        }

        private void getFiles(string fullPath)
        {
            if (System.IO.Directory.Exists(fullPath))
            {
                directoryFiles.Rows.Clear();
                //Recorrer los archivos de la carpeta y mostrarlos en un DataGridView con sus propiedades y ponerle un icono
                DirectoryInfo dir = new DirectoryInfo(fullPath);
                FileInfo[] files = dir.GetFiles();
                DirectoryInfo[] dirs = dir.GetDirectories();

                foreach (DirectoryInfo directory in dirs)
                {
                    // Agregar una nueva fila al DataGridView y asignar las celdas correspondientes
                    directoryFiles.Rows.Add(directory.Name, directory.LastWriteTime, "Folder", "", directory.FullName);
                }

                foreach (FileInfo file in files)
                {
                    // Agregar una nueva fila al DataGridView y asignar las celdas correspondientes
                    directoryFiles.Rows.Add(file.Name, file.LastWriteTime, file.Extension, FormatFileSize(file.Length), file.FullName);
                }
                currentPath = fullPath;
            }
        }

        private string FormatFileSize(long bytes)
        {
            const int scale = 1024;
            string[] orders = new string[] { "GB", "MB", "KB", "Bytes" };
            long max = (long)Math.Pow(scale, orders.Length - 1);

            foreach (string order in orders)
            {
                if (bytes > max)
                    return string.Format("{0:##.##} {1}", decimal.Divide(bytes, max), order);

                max /= scale;
            }

            return "0 Bytes";
        }

        private string getAppDirectory()
        {
            // Obtener la ruta de ejecución de la aplicación
            string assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            // Obtener la ruta del directorio del proyecto
            string projectDirectory = System.IO.Path.GetDirectoryName(assemblyPath);
            while (!System.IO.Directory.Exists(System.IO.Path.Combine(projectDirectory, "Storage")))
            {
                projectDirectory = System.IO.Directory.GetParent(projectDirectory).FullName;
                if (projectDirectory == null)
                {
                    throw new InvalidOperationException("No se pudo encontrar el directorio del proyecto.");
                }
            }

            return projectDirectory;
        }


        private void window_onClose(object sender, EventArgs e)
        {
            Window? window = sender as Window;
            foreach (Control panel in window.Controls)
            {
                // Verificar si el panel contiene controles
                if (panel.HasChildren)
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is MusicPlayer)
                        {
                            musicPlayer.mediaPlayer.Close();
                            tokenCancelMusic?.Cancel();
                            window.isMinimized = false;
                            musicPlayer.Dispose();
                        }

                        if (control is TextEditor)
                        {
                            tokenCancelText?.Cancel();
                            window.isMinimized = false;
                            textEditor.Dispose();
                        }
                    }
                }
            }
            window.Dispose();
        }
    }
}
