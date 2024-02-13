namespace ManuelOS
{
    partial class TextEditor
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
            contentPanel = new Panel();
            contentTextArea = new RichTextBox();
            Menu = new MenuStrip();
            sdsdToolStripMenuItem = new ToolStripMenuItem();
            mnNew = new ToolStripMenuItem();
            mnOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuSaveAs = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            panel1 = new Panel();
            contentPanel.SuspendLayout();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(12, 12, 12);
            contentPanel.Controls.Add(contentTextArea);
            contentPanel.Controls.Add(Menu);
            contentPanel.Controls.Add(panel1);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1280, 692);
            contentPanel.TabIndex = 1;
            // 
            // contentTextArea
            // 
            contentTextArea.BackColor = Color.FromArgb(32, 32, 32);
            contentTextArea.BorderStyle = BorderStyle.None;
            contentTextArea.Dock = DockStyle.Fill;
            contentTextArea.Font = new Font("Roboto", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentTextArea.ForeColor = Color.PaleGreen;
            contentTextArea.Location = new Point(0, 54);
            contentTextArea.Margin = new Padding(0);
            contentTextArea.Name = "contentTextArea";
            contentTextArea.Size = new Size(1280, 638);
            contentTextArea.TabIndex = 0;
            contentTextArea.Text = "";
            // 
            // Menu
            // 
            Menu.AutoSize = false;
            Menu.BackColor = Color.FromArgb(36, 36, 36);
            Menu.Items.AddRange(new ToolStripItem[] { sdsdToolStripMenuItem });
            Menu.Location = new Point(0, 28);
            Menu.Name = "Menu";
            Menu.Size = new Size(1280, 26);
            Menu.TabIndex = 1;
            Menu.Text = "Menu";
            // 
            // sdsdToolStripMenuItem
            // 
            sdsdToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            sdsdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnNew, mnOpen, menuSave, menuSaveAs, menuExit });
            sdsdToolStripMenuItem.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sdsdToolStripMenuItem.ForeColor = Color.PaleGreen;
            sdsdToolStripMenuItem.Name = "sdsdToolStripMenuItem";
            sdsdToolStripMenuItem.Size = new Size(39, 22);
            sdsdToolStripMenuItem.Text = "File";
            // 
            // mnNew
            // 
            mnNew.BackColor = Color.FromArgb(36, 36, 36);
            mnNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            mnNew.ForeColor = Color.PaleGreen;
            mnNew.Name = "mnNew";
            mnNew.Size = new Size(180, 22);
            mnNew.Text = "New";
            mnNew.Click += mnNew_Click;
            // 
            // mnOpen
            // 
            mnOpen.BackColor = Color.FromArgb(36, 36, 36);
            mnOpen.ForeColor = Color.PaleGreen;
            mnOpen.Name = "mnOpen";
            mnOpen.Size = new Size(180, 22);
            mnOpen.Text = "Open";
            mnOpen.Click += mnOpen_Click;
            // 
            // menuSave
            // 
            menuSave.BackColor = Color.FromArgb(36, 36, 36);
            menuSave.ForeColor = Color.PaleGreen;
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(180, 22);
            menuSave.Text = "Save";
            // 
            // menuSaveAs
            // 
            menuSaveAs.BackColor = Color.FromArgb(36, 36, 36);
            menuSaveAs.ForeColor = Color.PaleGreen;
            menuSaveAs.Name = "menuSaveAs";
            menuSaveAs.Size = new Size(180, 22);
            menuSaveAs.Text = "Save As";
            // 
            // menuExit
            // 
            menuExit.BackColor = Color.FromArgb(36, 36, 36);
            menuExit.ForeColor = Color.PaleGreen;
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(180, 22);
            menuExit.Text = "Exit";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 28);
            panel1.TabIndex = 2;
            // 
            // TextEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Name = "TextEditor";
            Size = new Size(1280, 692);
            contentPanel.ResumeLayout(false);
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private RichTextBox contentTextArea;
        private MenuStrip Menu;
        private ToolStripMenuItem sdsdToolStripMenuItem;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem mnNew;
        private ToolStripMenuItem mnOpen;
        private ToolStripMenuItem menuSave;
        private ToolStripMenuItem menuSaveAs;
        private Panel panel1;
    }
}
