namespace ManuelOS
{
    partial class SongsList
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
            panel1 = new Panel();
            contentPanel = new Panel();
            songList = new ListView();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.Control;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 28);
            panel1.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(12, 12, 12);
            contentPanel.Controls.Add(songList);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 28);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(5);
            contentPanel.Size = new Size(410, 222);
            contentPanel.TabIndex = 1;
            // 
            // songList
            // 
            songList.Activation = ItemActivation.TwoClick;
            songList.BackColor = Color.FromArgb(12, 12, 12);
            songList.BorderStyle = BorderStyle.None;
            songList.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songList.ForeColor = Color.PaleGreen;
            songList.FullRowSelect = true;
            songList.GridLines = true;
            songList.LabelWrap = false;
            songList.Location = new Point(8, 6);
            songList.MultiSelect = false;
            songList.Name = "songList";
            songList.Size = new Size(394, 208);
            songList.TabIndex = 0;
            songList.TileSize = new Size(228, 28);
            songList.UseCompatibleStateImageBehavior = false;
            songList.View = View.Tile;
            songList.ItemSelectionChanged += songList_ItemSelectionChanged;
            // 
            // SongsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            Name = "SongsList";
            Size = new Size(410, 250);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel contentPanel;
        private ListView songList;
    }
}
