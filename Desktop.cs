using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Media;
using System.Threading;
using Guna.UI2.WinForms;

namespace ManuelOS
{
    public partial class Desktop : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        List<Window> openWindows = new List<Window>();
        private Task taskBrowser, taskMusic, taskExplorer, taskText;
        CancellationTokenSource tokenCancelBrowser, tokenCancelMusic, tokenCancelExplorer, tokenCancelText;
        MusicPlayer musicPlayer = new MusicPlayer();

        public Desktop()
        {
            InitializeComponent();
            // Hacer que el metodo actualHour se ejecute cada segundo
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            hourLabel.Text = DateTime.Now.ToString("HH:mm:ss");

            PowerStatus powerStatus = SystemInformation.PowerStatus;
            int batteryLevel = (int)(powerStatus.BatteryLifePercent * 100);
            batteryLabel.Text = $"{batteryLevel} %";
            if(openWindows.Count > 0)
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
                                    minimizeIndicator(browserIcon ,browserIndicator, win.isMinimized);
                                
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

        private void powerOff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restart_Click(object sender, EventArgs e)
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

        private void browserIcon_Click(object sender, EventArgs e)
        {
            tokenCancelBrowser = new CancellationTokenSource();
            CancellationToken token = tokenCancelBrowser.Token;

            if (isWindowOpen("Browser"))
                return;

            Window window = new Window();
            window.SetTitle("Browser");
            window.Location = new Point(120, 120);
            browserIndicator.Visible = true;

            Browser browser = new Browser();
            Panel? contentPanel = window.Controls.Find("contentPanel", true).FirstOrDefault() as Panel;
            browser.Dock = DockStyle.Fill;
            contentPanel?.Controls.Add(browser);

            openWindows.Add(window);
            window.onClose += window_onClose;

            taskBrowser = Task.Run(() =>
            {
                Invoke((Action)(() =>
                {
                    desktopPanel.Controls.Add(window);
                    window.BringToFront();
                }));
            }, token);
        }

        private void musicIcon_Click(object sender, EventArgs e)
        {
            tokenCancelMusic = new CancellationTokenSource();
            CancellationToken token = tokenCancelMusic.Token;

            if (isWindowOpen("Music Player"))
                return;

            Window window = new Window();
            window.SetTitle("Music Player");
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
                        }
                        else if (control is MusicPlayer)
                        {
                            MusicPlayer musicPlayer = control as MusicPlayer;
                            musicPlayer.mediaPlayer.Close();
                            musicPlayer.Dispose();
                            tokenCancelMusic.Cancel();
                            musicIndicator.Visible = false;
                        }
                        else if (control is TextEditor)
                        {
                            tokenCancelText.Cancel();
                            textIndicator.Visible = false;
                        }
                    }
                }
            }

            openWindows.Remove(window);
            window.Dispose();
        }

        private void minimizeIndicator(FontAwesome.Sharp.IconPictureBox icon,Guna2Panel panel, bool isMinimized)
        {
            
            if (isMinimized)
            {
                panel.FillColor = System.Drawing.Color.DarkSeaGreen;
                icon.IconColor = System.Drawing.Color.DarkSeaGreen;
                return;
            }
            panel.FillColor = System.Drawing.Color.PaleGreen;
            icon.IconColor = System.Drawing.Color.PaleGreen;
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
            if(this.WindowState == FormWindowState.Maximized)
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
