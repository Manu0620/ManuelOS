namespace ManuelOS
{
    partial class FileExplorer
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            toolsPanel = new Guna.UI2.WinForms.Guna2Panel();
            changeNameMn = new FontAwesome.Sharp.IconButton();
            deleteMn = new FontAwesome.Sharp.IconButton();
            newFile = new FontAwesome.Sharp.IconButton();
            newFolder = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            directoryFiles = new Guna.UI2.WinForms.Guna2DataGridView();
            name = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            size = new DataGridViewTextBoxColumn();
            path = new DataGridViewTextBoxColumn();
            sideMenu = new FlowLayoutPanel();
            documentsDir = new FontAwesome.Sharp.IconButton();
            musicDir = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            downloadDir = new FontAwesome.Sharp.IconButton();
            recycleDir = new FontAwesome.Sharp.IconButton();
            toolsPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)directoryFiles).BeginInit();
            sideMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 12, 12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 28);
            panel1.TabIndex = 0;
            // 
            // toolsPanel
            // 
            toolsPanel.BackColor = Color.FromArgb(24, 24, 24);
            toolsPanel.BorderColor = Color.Bisque;
            toolsPanel.BorderRadius = 10;
            toolsPanel.BorderThickness = 1;
            toolsPanel.Controls.Add(changeNameMn);
            toolsPanel.Controls.Add(deleteMn);
            toolsPanel.Controls.Add(newFile);
            toolsPanel.Controls.Add(newFolder);
            customizableEdges1.TopLeft = false;
            customizableEdges1.TopRight = false;
            toolsPanel.CustomizableEdges = customizableEdges1;
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 28);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Padding = new Padding(10);
            toolsPanel.ShadowDecoration.BorderRadius = 10;
            toolsPanel.ShadowDecoration.Color = Color.PaleGreen;
            toolsPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            toolsPanel.ShadowDecoration.Shadow = new Padding(0, 0, 0, 5);
            toolsPanel.Size = new Size(1280, 62);
            toolsPanel.TabIndex = 1;
            // 
            // changeNameMn
            // 
            changeNameMn.Cursor = Cursors.Hand;
            changeNameMn.Dock = DockStyle.Left;
            changeNameMn.FlatAppearance.BorderSize = 0;
            changeNameMn.FlatStyle = FlatStyle.Flat;
            changeNameMn.Font = new Font("Roboto", 9F, FontStyle.Bold);
            changeNameMn.ForeColor = Color.Bisque;
            changeNameMn.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            changeNameMn.IconColor = Color.Bisque;
            changeNameMn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            changeNameMn.IconSize = 28;
            changeNameMn.ImageAlign = ContentAlignment.MiddleLeft;
            changeNameMn.Location = new Point(327, 10);
            changeNameMn.Name = "changeNameMn";
            changeNameMn.Size = new Size(130, 42);
            changeNameMn.TabIndex = 3;
            changeNameMn.Text = "Change Name";
            changeNameMn.TextAlign = ContentAlignment.MiddleLeft;
            changeNameMn.TextImageRelation = TextImageRelation.ImageBeforeText;
            changeNameMn.UseVisualStyleBackColor = true;
            changeNameMn.Click += changeNameMn_Click;
            // 
            // deleteMn
            // 
            deleteMn.Cursor = Cursors.Hand;
            deleteMn.Dock = DockStyle.Left;
            deleteMn.FlatAppearance.BorderSize = 0;
            deleteMn.FlatStyle = FlatStyle.Flat;
            deleteMn.Font = new Font("Roboto", 9F, FontStyle.Bold);
            deleteMn.ForeColor = Color.Bisque;
            deleteMn.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            deleteMn.IconColor = Color.Bisque;
            deleteMn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            deleteMn.IconSize = 28;
            deleteMn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteMn.Location = new Point(246, 10);
            deleteMn.Name = "deleteMn";
            deleteMn.Size = new Size(81, 42);
            deleteMn.TabIndex = 2;
            deleteMn.Text = "Delete";
            deleteMn.TextAlign = ContentAlignment.MiddleLeft;
            deleteMn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteMn.UseVisualStyleBackColor = true;
            deleteMn.Click += deleteMn_Click;
            // 
            // newFile
            // 
            newFile.Cursor = Cursors.Hand;
            newFile.Dock = DockStyle.Left;
            newFile.FlatAppearance.BorderSize = 0;
            newFile.FlatStyle = FlatStyle.Flat;
            newFile.Font = new Font("Roboto", 9F, FontStyle.Bold);
            newFile.ForeColor = Color.Bisque;
            newFile.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            newFile.IconColor = Color.Bisque;
            newFile.IconFont = FontAwesome.Sharp.IconFont.Solid;
            newFile.IconSize = 28;
            newFile.ImageAlign = ContentAlignment.MiddleLeft;
            newFile.Location = new Point(124, 10);
            newFile.Name = "newFile";
            newFile.Size = new Size(122, 42);
            newFile.TabIndex = 1;
            newFile.Text = "New Text File";
            newFile.TextAlign = ContentAlignment.MiddleLeft;
            newFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            newFile.UseVisualStyleBackColor = true;
            newFile.Click += newFile_Click;
            // 
            // newFolder
            // 
            newFolder.Cursor = Cursors.Hand;
            newFolder.Dock = DockStyle.Left;
            newFolder.FlatAppearance.BorderSize = 0;
            newFolder.FlatStyle = FlatStyle.Flat;
            newFolder.Font = new Font("Roboto", 9F, FontStyle.Bold);
            newFolder.ForeColor = Color.Bisque;
            newFolder.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            newFolder.IconColor = Color.Bisque;
            newFolder.IconFont = FontAwesome.Sharp.IconFont.Solid;
            newFolder.IconSize = 28;
            newFolder.ImageAlign = ContentAlignment.MiddleLeft;
            newFolder.Location = new Point(10, 10);
            newFolder.Name = "newFolder";
            newFolder.Size = new Size(114, 42);
            newFolder.TabIndex = 0;
            newFolder.Text = "New Folder";
            newFolder.TextAlign = ContentAlignment.MiddleLeft;
            newFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            newFolder.UseVisualStyleBackColor = true;
            newFolder.Click += newFolder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 18, 18);
            panel2.Controls.Add(directoryFiles);
            panel2.Controls.Add(sideMenu);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(1280, 630);
            panel2.TabIndex = 2;
            // 
            // directoryFiles
            // 
            directoryFiles.AllowUserToAddRows = false;
            directoryFiles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle1.ForeColor = Color.Bisque;
            dataGridViewCellStyle1.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(24, 24, 24);
            directoryFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            directoryFiles.BackgroundColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle2.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Bisque;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle2.SelectionForeColor = Color.Bisque;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            directoryFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            directoryFiles.ColumnHeadersHeight = 27;
            directoryFiles.Columns.AddRange(new DataGridViewColumn[] { name, date, Type, size, path });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle7.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Bisque;
            dataGridViewCellStyle7.Padding = new Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            directoryFiles.DefaultCellStyle = dataGridViewCellStyle7;
            directoryFiles.Dock = DockStyle.Fill;
            directoryFiles.EditMode = DataGridViewEditMode.EditProgrammatically;
            directoryFiles.GridColor = Color.FromArgb(50, 56, 62);
            directoryFiles.Location = new Point(300, 0);
            directoryFiles.Name = "directoryFiles";
            directoryFiles.ReadOnly = true;
            directoryFiles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle8.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle8.ForeColor = Color.Bisque;
            dataGridViewCellStyle8.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            directoryFiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            directoryFiles.RowHeadersVisible = false;
            directoryFiles.RowHeadersWidth = 30;
            directoryFiles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            directoryFiles.RowTemplate.Height = 30;
            directoryFiles.RowTemplate.Resizable = DataGridViewTriState.False;
            directoryFiles.ScrollBars = ScrollBars.Vertical;
            directoryFiles.Size = new Size(980, 630);
            directoryFiles.TabIndex = 4;
            directoryFiles.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            directoryFiles.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(24, 24, 24);
            directoryFiles.ThemeStyle.AlternatingRowsStyle.Font = null;
            directoryFiles.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Bisque;
            directoryFiles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Bisque;
            directoryFiles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(24, 24, 24);
            directoryFiles.ThemeStyle.BackColor = Color.FromArgb(18, 18, 18);
            directoryFiles.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            directoryFiles.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(18, 18, 18);
            directoryFiles.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            directoryFiles.ThemeStyle.HeaderStyle.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            directoryFiles.ThemeStyle.HeaderStyle.ForeColor = Color.Bisque;
            directoryFiles.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            directoryFiles.ThemeStyle.HeaderStyle.Height = 27;
            directoryFiles.ThemeStyle.ReadOnly = true;
            directoryFiles.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(18, 18, 18);
            directoryFiles.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            directoryFiles.ThemeStyle.RowsStyle.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            directoryFiles.ThemeStyle.RowsStyle.ForeColor = Color.Bisque;
            directoryFiles.ThemeStyle.RowsStyle.Height = 30;
            directoryFiles.ThemeStyle.RowsStyle.SelectionBackColor = Color.Bisque;
            directoryFiles.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(18, 18, 18);
            directoryFiles.CellDoubleClick += directoryFiles_CellDoubleClick;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle3.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Bisque;
            dataGridViewCellStyle3.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(18, 18, 18);
            name.DefaultCellStyle = dataGridViewCellStyle3;
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.True;
            // 
            // date
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle4.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Bisque;
            dataGridViewCellStyle4.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(18, 18, 18);
            date.DefaultCellStyle = dataGridViewCellStyle4;
            date.HeaderText = "Date";
            date.Name = "date";
            date.ReadOnly = true;
            // 
            // Type
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle5.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle5.ForeColor = Color.Bisque;
            dataGridViewCellStyle5.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(18, 18, 18);
            Type.DefaultCellStyle = dataGridViewCellStyle5;
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // size
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle6.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle6.ForeColor = Color.Bisque;
            dataGridViewCellStyle6.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(18, 18, 18);
            size.DefaultCellStyle = dataGridViewCellStyle6;
            size.HeaderText = "Size";
            size.Name = "size";
            size.ReadOnly = true;
            size.Resizable = DataGridViewTriState.True;
            // 
            // path
            // 
            path.HeaderText = "Path";
            path.Name = "path";
            path.ReadOnly = true;
            path.Visible = false;
            // 
            // sideMenu
            // 
            sideMenu.BackColor = Color.FromArgb(24, 24, 24);
            sideMenu.BorderStyle = BorderStyle.FixedSingle;
            sideMenu.Controls.Add(documentsDir);
            sideMenu.Controls.Add(musicDir);
            sideMenu.Controls.Add(iconButton2);
            sideMenu.Controls.Add(downloadDir);
            sideMenu.Controls.Add(recycleDir);
            sideMenu.Dock = DockStyle.Left;
            sideMenu.Location = new Point(0, 0);
            sideMenu.Name = "sideMenu";
            sideMenu.Padding = new Padding(0, 25, 0, 0);
            sideMenu.Size = new Size(300, 630);
            sideMenu.TabIndex = 3;
            // 
            // documentsDir
            // 
            documentsDir.Dock = DockStyle.Top;
            documentsDir.FlatAppearance.BorderSize = 0;
            documentsDir.FlatStyle = FlatStyle.Flat;
            documentsDir.Font = new Font("Roboto", 9F);
            documentsDir.ForeColor = Color.Bisque;
            documentsDir.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            documentsDir.IconColor = Color.Bisque;
            documentsDir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            documentsDir.IconSize = 20;
            documentsDir.ImageAlign = ContentAlignment.MiddleLeft;
            documentsDir.Location = new Point(3, 28);
            documentsDir.Name = "documentsDir";
            documentsDir.Padding = new Padding(15, 0, 0, 0);
            documentsDir.Size = new Size(292, 32);
            documentsDir.TabIndex = 3;
            documentsDir.Text = "Documents";
            documentsDir.TextAlign = ContentAlignment.MiddleLeft;
            documentsDir.TextImageRelation = TextImageRelation.ImageBeforeText;
            documentsDir.UseVisualStyleBackColor = true;
            documentsDir.Click += documentsDir_Click;
            // 
            // musicDir
            // 
            musicDir.Dock = DockStyle.Top;
            musicDir.FlatAppearance.BorderSize = 0;
            musicDir.FlatStyle = FlatStyle.Flat;
            musicDir.Font = new Font("Roboto", 9F);
            musicDir.ForeColor = Color.Bisque;
            musicDir.IconChar = FontAwesome.Sharp.IconChar.Music;
            musicDir.IconColor = Color.Bisque;
            musicDir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            musicDir.IconSize = 20;
            musicDir.ImageAlign = ContentAlignment.MiddleLeft;
            musicDir.Location = new Point(3, 66);
            musicDir.Name = "musicDir";
            musicDir.Padding = new Padding(15, 0, 0, 0);
            musicDir.Size = new Size(292, 32);
            musicDir.TabIndex = 4;
            musicDir.Text = "Music";
            musicDir.TextAlign = ContentAlignment.MiddleLeft;
            musicDir.TextImageRelation = TextImageRelation.ImageBeforeText;
            musicDir.UseVisualStyleBackColor = true;
            musicDir.Click += musicDir_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Roboto", 9F);
            iconButton2.ForeColor = Color.Bisque;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            iconButton2.IconColor = Color.Bisque;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(3, 104);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(15, 0, 0, 0);
            iconButton2.Size = new Size(292, 32);
            iconButton2.TabIndex = 5;
            iconButton2.Text = "Images";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // downloadDir
            // 
            downloadDir.Dock = DockStyle.Top;
            downloadDir.FlatAppearance.BorderSize = 0;
            downloadDir.FlatStyle = FlatStyle.Flat;
            downloadDir.Font = new Font("Roboto", 9F);
            downloadDir.ForeColor = Color.Bisque;
            downloadDir.IconChar = FontAwesome.Sharp.IconChar.Download;
            downloadDir.IconColor = Color.Bisque;
            downloadDir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            downloadDir.IconSize = 20;
            downloadDir.ImageAlign = ContentAlignment.MiddleLeft;
            downloadDir.Location = new Point(3, 142);
            downloadDir.Name = "downloadDir";
            downloadDir.Padding = new Padding(15, 0, 0, 0);
            downloadDir.Size = new Size(292, 32);
            downloadDir.TabIndex = 6;
            downloadDir.Text = "Downloads";
            downloadDir.TextAlign = ContentAlignment.MiddleLeft;
            downloadDir.TextImageRelation = TextImageRelation.ImageBeforeText;
            downloadDir.UseVisualStyleBackColor = true;
            downloadDir.Click += downloadDir_Click;
            // 
            // recycleDir
            // 
            recycleDir.Dock = DockStyle.Top;
            recycleDir.FlatAppearance.BorderSize = 0;
            recycleDir.FlatStyle = FlatStyle.Flat;
            recycleDir.Font = new Font("Roboto", 9F);
            recycleDir.ForeColor = Color.Bisque;
            recycleDir.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            recycleDir.IconColor = Color.Bisque;
            recycleDir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            recycleDir.IconSize = 20;
            recycleDir.ImageAlign = ContentAlignment.MiddleLeft;
            recycleDir.Location = new Point(3, 180);
            recycleDir.Name = "recycleDir";
            recycleDir.Padding = new Padding(15, 0, 0, 0);
            recycleDir.Size = new Size(292, 32);
            recycleDir.TabIndex = 7;
            recycleDir.Text = "Recycle Bin";
            recycleDir.TextAlign = ContentAlignment.MiddleLeft;
            recycleDir.TextImageRelation = TextImageRelation.ImageBeforeText;
            recycleDir.UseVisualStyleBackColor = true;
            recycleDir.Click += recycleDir_Click;
            // 
            // FileExplorer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(toolsPanel);
            Controls.Add(panel1);
            Name = "FileExplorer";
            Size = new Size(1280, 720);
            toolsPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)directoryFiles).EndInit();
            sideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel toolsPanel;
        private Panel panel2;
        private FlowLayoutPanel sideMenu;
        private FontAwesome.Sharp.IconButton documentsDir;
        private FontAwesome.Sharp.IconButton musicDir;
        private FontAwesome.Sharp.IconButton newFolder;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2DataGridView directoryFiles;
        private FontAwesome.Sharp.IconButton downloadDir;
        private FontAwesome.Sharp.IconButton newFile;
        private FontAwesome.Sharp.IconButton deleteMn;
        private FontAwesome.Sharp.IconButton changeNameMn;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn size;
        private DataGridViewTextBoxColumn path;
        private FontAwesome.Sharp.IconButton recycleDir;
    }
}
