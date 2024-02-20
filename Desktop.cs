using System;
using System.Diagnostics;
using Guna.UI2.WinForms;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using Microsoft.Win32;


namespace ManuelOS
{
    public partial class Desktop : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        List<Window> openWindows = new List<Window>();
        private Task taskBrowser, taskMusic, taskExplorer, taskText, taskManager;
        CancellationTokenSource tokenCancelBrowser, tokenCancelMusic, tokenCancelExplorer, tokenCancelText, tokenCancelManager;
        MusicPlayer musicPlayer = new MusicPlayer();

        Process browserProcess;

        // Importa la función SetParent de la API de Windows
        [DllImport("user32.dll")]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        // Importa la función ShowWindow de la API de Windows
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        // Constantes para el comando de visualización
        private const int SW_SHOWMAXIMIZED = 3;

        public Desktop()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            // Hacer que el metodo actualHour se ejecute cada segundo
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            hourLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            PowerStatus powerStatus = SystemInformation.PowerStatus;
            int batteryLevel = (int)(powerStatus.BatteryLifePercent * 100);
            batteryLabel.Text = $"{batteryLevel} %";

            if (openWindows.Count > 0)
            {
                foreach (Window win in openWindows)
                {
                    foreach (Control panel in win.Controls)
                    {
                        if (panel.HasChildren)
                        {
                            foreach (Control control in panel.Controls)
                            {
                                if (control is Browser)
                                    minimizeIndicator(browserIcon, browserIndicator, win.isMinimized);

                                if (control is MusicPlayer)
                                    minimizeIndicator(musicIcon, musicIndicator, win.isMinimized);

                                if (control is TextEditor)
                                    minimizeIndicator(textEditorIcon, textIndicator, win.isMinimized);
                            }
                        }
                    }
                }
            }
        }

        private static Process NewProcess(string path, Control containerControl)
        {
            if (System.IO.File.Exists(path))
            {
                try
                {
                    Process process = Process.Start(path);
                    process.WaitForInputIdle();

                    IntPtr appWinHandle = process.MainWindowHandle;

                    // Insertar la ventana del proceso dentro del control contenedor especificado
                    SetParent(appWinHandle, containerControl.Handle);
                    ShowWindow(appWinHandle, SW_SHOWMAXIMIZED);

                    return process;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("The specified file does not exist.");
            }

            return null;
        }

        private void PowerOff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicacion actual y volver a abrirla
            Application.Restart();
        }

        private void textEditorIcon_Click(object sender, EventArgs e)
        {
            tokenCancelText = new CancellationTokenSource();
            CancellationToken token = tokenCancelText.Token;

            if (isWindowOpen("Text Editor"))
                return;

            Window window = new Window();
            window.SetTitle("Text Editor");
            window.Location = new Point(120, 120);
            textIndicator.Visible = true;

            TextEditor textEditor = new TextEditor();
            Panel? contentPanel = window.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
            textEditor.Dock = DockStyle.Fill;
            contentPanel?.Controls.Add(textEditor);

            openWindows.Add(window);
            window.onClose += window_onClose;

            taskText = Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    desktopPanel.Controls.Add(window);
                    window.BringToFront();

                }));
            }, token);
        }

        private async void browserIcon_Click(object sender, EventArgs e)
        {
            tokenCancelBrowser = new CancellationTokenSource();
            CancellationToken token = tokenCancelBrowser.Token;

            // Abrir nuevo proceso en segundo plano
            browserProcess = NewProcess("C:\\Users\\Manuel\\source\\repos\\ManuelOS\\WinFormsApp1\\bin\\Debug\\net8.0-windows\\BrowserApp.exe", desktopPanel);

            //if (isWindowOpen("Browser"))
            //    return;

            //Window window = new Window();
            //window.SetTitle("Browser");
            //window.Location = new Point(120, 120);
            //browserIndicator.Visible = true;

            //Browser browser = new Browser();
            //Panel? contentPanel = window.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
            //browser.Dock = DockStyle.Fill;
            //contentPanel?.Controls.Add(browser);

            //openWindows.Add(window);
            //window.onClose += window_onClose;

            //taskBrowser = Task.Run(() =>
            //{
            //    Invoke((Action)(() =>
            //    {
            //        desktopPanel.Controls.Add(window);
            //        window.BringToFront();
            //    }));
            //}, token);
        }

        private void musicIcon_Click(object sender, EventArgs e)
        {
            tokenCancelMusic = new CancellationTokenSource();
            CancellationToken token = tokenCancelMusic.Token;

            if (isWindowOpen("Spotify Premium"))
                return;

            Window window = new Window();
            window.SetTitle("Spotify Premium");
            window.Location = new Point(120, 120);
            musicIndicator.Visible = true;
            window.Size = new Size(800, 400);
            Panel? iPanel = window.Controls.Find("infoPanel", true).FirstOrDefault() as Panel;
            iPanel.Size = new Size(800, 28);

            musicPlayer = new MusicPlayer();
            Panel? contentPanel = window.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
            musicPlayer.Dock = DockStyle.Fill;
            contentPanel?.Controls.Add(musicPlayer);

            openWindows.Add(window);
            window.onClose += window_onClose;

            taskMusic = Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    desktopPanel.Controls.Add(window);
                    window.BringToFront();
                }));
            }, token);
        }

        private void explorerBtn_Click(object sender, EventArgs e)
        {
            tokenCancelExplorer = new CancellationTokenSource();
            CancellationToken token = tokenCancelExplorer.Token;

            if (isWindowOpen("File Explorer"))
                return;

            Window window = new Window();
            window.SetTitle("File Explorer");
            window.Location = new Point(120, 120);

            FileExplorer fileExp = new FileExplorer();
            Panel? contentPanel = window.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
            fileExp.Dock = DockStyle.Fill;
            contentPanel?.Controls.Add(fileExp);

            openWindows.Add(window);
            window.onClose += window_onClose;

            taskExplorer = Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    desktopPanel.Controls.Add(window);
                    window.BringToFront();
                }));
            }, token);
        }

        private void taskManagerIcon_Click(object sender, EventArgs e)
        {
            tokenCancelManager = new CancellationTokenSource();
            CancellationToken token = tokenCancelManager.Token;

            if (isWindowOpen("Task Manager"))
                return;

            Window window = new Window();
            window.SetTitle("Task Manager");
            window.Location = new Point(120, 120);

            TaskManager fileExp = new TaskManager();
            Panel? contentPanel = window.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
            fileExp.Dock = DockStyle.Fill;
            contentPanel?.Controls.Add(fileExp);

            openWindows.Add(window);
            window.onClose += window_onClose;

            taskManager = Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    desktopPanel.Controls.Add(window);
                    window.BringToFront();
                }));
            }, token);
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
                        if (control is Browser)
                        {
                            Browser browser = control as Browser;
                            tokenCancelBrowser.Cancel();
                            browserIndicator.Visible = false;
                            browserProcess.Kill();   
                            browserIcon.IconColor = System.Drawing.Color.PaleGreen;
                        }
                        else if (control is MusicPlayer)
                        {
                            MusicPlayer musicPlayer = control as MusicPlayer;
                            musicPlayer.mediaPlayer.Close();
                            musicPlayer.Dispose();
                            tokenCancelMusic.Cancel();
                            musicIndicator.Visible = false;
                            musicIcon.IconColor = System.Drawing.Color.PaleGreen;
                        }
                        else if (control is TextEditor)
                        {
                            tokenCancelText.Cancel();
                            textIndicator.Visible = false;
                            textEditorIcon.IconColor = System.Drawing.Color.PaleGreen;
                        }
                        else if (control is FileExplorer)
                        {
                            FileExplorer fileExplorer = control as FileExplorer;
                            if(fileExplorer.musicPlayer != null)
                                fileExplorer.musicPlayer.mediaPlayer.Close();
                            tokenCancelExplorer.Cancel();
                        }
                    }
                }
            }

            openWindows.Remove(window);
            window.Dispose();
        }

        private void minimizeIndicator(FontAwesome.Sharp.IconPictureBox icon, Guna2Panel panel, bool isMinimized)
        {

            if (isMinimized)
            {
                panel.FillColor = System.Drawing.Color.DarkSeaGreen;
                icon.IconColor = System.Drawing.Color.DarkSeaGreen;
                return;
            }
            icon.IconColor = System.Drawing.Color.PaleGreen;
            panel.FillColor = System.Drawing.Color.PaleGreen;
        }

        private bool isWindowOpen(string title)
        {
            foreach (Window win in openWindows)
            {
                Label winTitle = win.Controls.Find("titleLabel", true).FirstOrDefault() as Label;
                if (winTitle.Text == title && win.isMinimized)
                {
                    win.Show();
                    win.BringToFront();
                    win.isMinimized = false;

                    return true;
                }
                else if (winTitle.Text == title && !win.isMinimized)
                {
                    win.Hide();
                    win.isMinimized = true;
                    return true;
                }
            }
            return false;
        }

        private void infoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void infoPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void infoPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
