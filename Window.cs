using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace ManuelOS
{
    public partial class Window : UserControl
    {
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        public event EventHandler onClose;
        public bool isMinimized = false;
        public Window()
        {
            InitializeComponent();
        }

        public void SetTitle(string title)
        {
            titleLabel.Text = title;
            if(title.Contains("Explorer")  || title.Contains("Explorador") || title.Contains("File") || title.Contains("Archivo"))
            {
                titleLabel.ForeColor = System.Drawing.Color.Bisque;
                exit.ForeColor = System.Drawing.Color.Bisque;
                minimize.ForeColor = System.Drawing.Color.Bisque;
                maximize.ForeColor = System.Drawing.Color.Bisque;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            onClose?.Invoke(this, EventArgs.Empty);
        }

        private void infoPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
            this.Dock = DockStyle.None;
            this.BringToFront();
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
            dragging = false;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            isMinimized = true;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if(this.Dock == DockStyle.Fill)
            {
                this.Dock = DockStyle.None;
                return;
            }
                
            this.Dock = DockStyle.Fill;
        }
    }
}