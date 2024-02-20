namespace ManuelOS
{
    partial class TaskManager
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            contentPanel = new Panel();
            taskList = new Guna.UI2.WinForms.Guna2DataGridView();
            name = new DataGridViewTextBoxColumn();
            cpu = new DataGridViewTextBoxColumn();
            memory = new DataGridViewTextBoxColumn();
            disk = new DataGridViewTextBoxColumn();
            network = new DataGridViewTextBoxColumn();
            blank = new DataGridViewTextBoxColumn();
            toolsPanel = new Guna.UI2.WinForms.Guna2Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            newFolder = new FontAwesome.Sharp.IconButton();
            timer = new System.Windows.Forms.Timer(components);
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskList).BeginInit();
            toolsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 12, 12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 28);
            panel1.TabIndex = 1;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(12, 12, 12);
            contentPanel.Controls.Add(taskList);
            contentPanel.Controls.Add(toolsPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 28);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1280, 692);
            contentPanel.TabIndex = 2;
            // 
            // taskList
            // 
            taskList.AllowUserToAddRows = false;
            taskList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle10.ForeColor = Color.PaleGreen;
            dataGridViewCellStyle10.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(24, 24, 24);
            taskList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            taskList.BackgroundColor = Color.FromArgb(18, 18, 18);
            taskList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle11.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.PaleGreen;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle11.SelectionForeColor = Color.PaleGreen;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            taskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            taskList.ColumnHeadersHeight = 50;
            taskList.Columns.AddRange(new DataGridViewColumn[] { name, cpu, memory, disk, network, blank });
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle17.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.PaleGreen;
            dataGridViewCellStyle17.Padding = new Padding(5);
            dataGridViewCellStyle17.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            taskList.DefaultCellStyle = dataGridViewCellStyle17;
            taskList.Dock = DockStyle.Fill;
            taskList.EditMode = DataGridViewEditMode.EditProgrammatically;
            taskList.GridColor = Color.FromArgb(50, 56, 62);
            taskList.Location = new Point(0, 62);
            taskList.Name = "taskList";
            taskList.ReadOnly = true;
            taskList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle18.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle18.ForeColor = Color.Bisque;
            dataGridViewCellStyle18.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle18.SelectionForeColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            taskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            taskList.RowHeadersVisible = false;
            taskList.RowHeadersWidth = 30;
            taskList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            taskList.RowTemplate.Height = 40;
            taskList.RowTemplate.Resizable = DataGridViewTriState.False;
            taskList.ScrollBars = ScrollBars.Vertical;
            taskList.Size = new Size(1280, 630);
            taskList.TabIndex = 5;
            taskList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            taskList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(24, 24, 24);
            taskList.ThemeStyle.AlternatingRowsStyle.Font = null;
            taskList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.PaleGreen;
            taskList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.PaleGreen;
            taskList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(24, 24, 24);
            taskList.ThemeStyle.BackColor = Color.FromArgb(18, 18, 18);
            taskList.ThemeStyle.GridColor = Color.FromArgb(50, 56, 62);
            taskList.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(18, 18, 18);
            taskList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            taskList.ThemeStyle.HeaderStyle.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskList.ThemeStyle.HeaderStyle.ForeColor = Color.PaleGreen;
            taskList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            taskList.ThemeStyle.HeaderStyle.Height = 50;
            taskList.ThemeStyle.ReadOnly = true;
            taskList.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(18, 18, 18);
            taskList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            taskList.ThemeStyle.RowsStyle.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskList.ThemeStyle.RowsStyle.ForeColor = Color.PaleGreen;
            taskList.ThemeStyle.RowsStyle.Height = 40;
            taskList.ThemeStyle.RowsStyle.SelectionBackColor = Color.PaleGreen;
            taskList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(18, 18, 18);
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle12.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Bisque;
            dataGridViewCellStyle12.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(18, 18, 18);
            name.DefaultCellStyle = dataGridViewCellStyle12;
            name.FillWeight = 250F;
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            name.Resizable = DataGridViewTriState.True;
            // 
            // cpu
            // 
            cpu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle13.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle13.ForeColor = Color.Bisque;
            dataGridViewCellStyle13.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(18, 18, 18);
            cpu.DefaultCellStyle = dataGridViewCellStyle13;
            cpu.HeaderText = "CPU";
            cpu.Name = "cpu";
            cpu.ReadOnly = true;
            // 
            // memory
            // 
            memory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle14.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle14.ForeColor = Color.Bisque;
            dataGridViewCellStyle14.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(18, 18, 18);
            memory.DefaultCellStyle = dataGridViewCellStyle14;
            memory.HeaderText = "Memory";
            memory.Name = "memory";
            memory.ReadOnly = true;
            // 
            // disk
            // 
            disk.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(18, 18, 18);
            dataGridViewCellStyle15.Font = new Font("Roboto", 10F);
            dataGridViewCellStyle15.ForeColor = Color.Bisque;
            dataGridViewCellStyle15.SelectionBackColor = Color.Bisque;
            dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(18, 18, 18);
            disk.DefaultCellStyle = dataGridViewCellStyle15;
            disk.HeaderText = "Disk";
            disk.Name = "disk";
            disk.ReadOnly = true;
            disk.Resizable = DataGridViewTriState.True;
            // 
            // network
            // 
            network.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleRight;
            network.DefaultCellStyle = dataGridViewCellStyle16;
            network.HeaderText = "Network";
            network.Name = "network";
            network.ReadOnly = true;
            // 
            // blank
            // 
            blank.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            blank.FillWeight = 250F;
            blank.HeaderText = "";
            blank.Name = "blank";
            blank.ReadOnly = true;
            // 
            // toolsPanel
            // 
            toolsPanel.BackColor = Color.FromArgb(24, 24, 24);
            toolsPanel.BorderColor = Color.PaleGreen;
            toolsPanel.BorderRadius = 10;
            toolsPanel.BorderThickness = 1;
            toolsPanel.Controls.Add(iconButton1);
            toolsPanel.Controls.Add(newFolder);
            customizableEdges3.TopLeft = false;
            customizableEdges3.TopRight = false;
            toolsPanel.CustomizableEdges = customizableEdges3;
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(0, 0);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Padding = new Padding(50, 10, 50, 10);
            toolsPanel.ShadowDecoration.BorderRadius = 10;
            toolsPanel.ShadowDecoration.Color = Color.PaleGreen;
            toolsPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            toolsPanel.ShadowDecoration.Shadow = new Padding(0, 0, 0, 5);
            toolsPanel.Size = new Size(1280, 62);
            toolsPanel.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Left;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Roboto", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.PaleGreen;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Gears;
            iconButton1.IconColor = Color.PaleGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 28;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(50, 10);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(120, 42);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Processes";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // newFolder
            // 
            newFolder.Cursor = Cursors.Hand;
            newFolder.Dock = DockStyle.Right;
            newFolder.Enabled = false;
            newFolder.FlatAppearance.BorderSize = 0;
            newFolder.FlatStyle = FlatStyle.Flat;
            newFolder.Font = new Font("Roboto", 9F, FontStyle.Bold);
            newFolder.ForeColor = Color.PaleGreen;
            newFolder.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            newFolder.IconColor = Color.PaleGreen;
            newFolder.IconFont = FontAwesome.Sharp.IconFont.Solid;
            newFolder.IconSize = 28;
            newFolder.ImageAlign = ContentAlignment.MiddleLeft;
            newFolder.Location = new Point(1110, 10);
            newFolder.Name = "newFolder";
            newFolder.Size = new Size(120, 42);
            newFolder.TabIndex = 0;
            newFolder.Text = "Close task";
            newFolder.TextAlign = ContentAlignment.MiddleLeft;
            newFolder.TextImageRelation = TextImageRelation.ImageBeforeText;
            newFolder.UseVisualStyleBackColor = true;
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            Name = "TaskManager";
            Size = new Size(1280, 720);
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskList).EndInit();
            toolsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel contentPanel;
        private Guna.UI2.WinForms.Guna2Panel toolsPanel;
        private FontAwesome.Sharp.IconButton newFolder;
        private Guna.UI2.WinForms.Guna2DataGridView taskList;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn cpu;
        private DataGridViewTextBoxColumn memory;
        private DataGridViewTextBoxColumn disk;
        private DataGridViewTextBoxColumn network;
        private DataGridViewTextBoxColumn blank;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Timer timer;
    }
}
