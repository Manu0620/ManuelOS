namespace ManuelOS
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            desktopPanel = new Panel();
            explorerBtn = new FontAwesome.Sharp.IconButton();
            recycleBinBtn = new FontAwesome.Sharp.IconButton();
            dockPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            musicIndicator = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            taskIndicator = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            textIndicator = new Guna.UI2.WinForms.Guna2Panel();
            browserIndicator = new Guna.UI2.WinForms.Guna2Panel();
            taskManagerIcon = new FontAwesome.Sharp.IconPictureBox();
            musicIcon = new FontAwesome.Sharp.IconPictureBox();
            textEditorIcon = new FontAwesome.Sharp.IconPictureBox();
            browserIcon = new FontAwesome.Sharp.IconPictureBox();
            menuIcon = new FontAwesome.Sharp.IconPictureBox();
            infoPanel = new Panel();
            minimize = new FontAwesome.Sharp.IconPictureBox();
            maximize = new FontAwesome.Sharp.IconPictureBox();
            restart = new FontAwesome.Sharp.IconPictureBox();
            powerOff = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            batteryLabel = new Label();
            titleLabel = new Label();
            hourLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            desktopPanel.SuspendLayout();
            dockPanel.SuspendLayout();
            musicIndicator.SuspendLayout();
            taskIndicator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskManagerIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)musicIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditorIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)browserIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuIcon).BeginInit();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)restart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)powerOff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconDropDownButton1.IconColor = Color.Black;
            iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconDropDownButton1.Name = "iconDropDownButton1";
            iconDropDownButton1.Size = new Size(23, 23);
            iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // desktopPanel
            // 
            desktopPanel.BackColor = Color.FromArgb(12, 12, 12);
            desktopPanel.Controls.Add(explorerBtn);
            desktopPanel.Controls.Add(recycleBinBtn);
            desktopPanel.Controls.Add(dockPanel);
            desktopPanel.Controls.Add(infoPanel);
            desktopPanel.Dock = DockStyle.Fill;
            desktopPanel.Location = new Point(0, 0);
            desktopPanel.Name = "desktopPanel";
            desktopPanel.Size = new Size(1600, 900);
            desktopPanel.TabIndex = 0;
            // 
            // explorerBtn
            // 
            explorerBtn.Cursor = Cursors.Hand;
            explorerBtn.FlatAppearance.BorderSize = 0;
            explorerBtn.FlatStyle = FlatStyle.Flat;
            explorerBtn.ForeColor = Color.PaleGreen;
            explorerBtn.IconChar = FontAwesome.Sharp.IconChar.FolderClosed;
            explorerBtn.IconColor = Color.PaleGreen;
            explorerBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            explorerBtn.Location = new Point(11, 118);
            explorerBtn.Name = "explorerBtn";
            explorerBtn.Size = new Size(87, 74);
            explorerBtn.TabIndex = 7;
            explorerBtn.Text = "File Explorer";
            explorerBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            explorerBtn.UseVisualStyleBackColor = true;
            explorerBtn.Click += explorerBtn_Click;
            // 
            // recycleBinBtn
            // 
            recycleBinBtn.Cursor = Cursors.Hand;
            recycleBinBtn.FlatAppearance.BorderSize = 0;
            recycleBinBtn.FlatStyle = FlatStyle.Flat;
            recycleBinBtn.ForeColor = Color.PaleGreen;
            recycleBinBtn.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            recycleBinBtn.IconColor = Color.PaleGreen;
            recycleBinBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            recycleBinBtn.Location = new Point(11, 38);
            recycleBinBtn.Name = "recycleBinBtn";
            recycleBinBtn.Size = new Size(87, 74);
            recycleBinBtn.TabIndex = 6;
            recycleBinBtn.Text = "Recycle Bin";
            recycleBinBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            recycleBinBtn.UseVisualStyleBackColor = true;
            // 
            // dockPanel
            // 
            dockPanel.Anchor = AnchorStyles.Bottom;
            dockPanel.BackColor = Color.Transparent;
            dockPanel.Controls.Add(musicIndicator);
            dockPanel.Controls.Add(taskIndicator);
            dockPanel.Controls.Add(textIndicator);
            dockPanel.Controls.Add(browserIndicator);
            dockPanel.Controls.Add(taskManagerIcon);
            dockPanel.Controls.Add(musicIcon);
            dockPanel.Controls.Add(textEditorIcon);
            dockPanel.Controls.Add(browserIcon);
            dockPanel.Controls.Add(menuIcon);
            dockPanel.FillColor = Color.FromArgb(18, 18, 18);
            dockPanel.Location = new Point(369, 818);
            dockPanel.Name = "dockPanel";
            dockPanel.Radius = 10;
            dockPanel.ShadowColor = Color.PaleGreen;
            dockPanel.Size = new Size(890, 70);
            dockPanel.TabIndex = 5;
            // 
            // musicIndicator
            // 
            musicIndicator.Anchor = AnchorStyles.Bottom;
            musicIndicator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            musicIndicator.BorderRadius = 5;
            musicIndicator.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            musicIndicator.Controls.Add(guna2Panel3);
            musicIndicator.CustomizableEdges = customizableEdges3;
            musicIndicator.FillColor = Color.PaleGreen;
            musicIndicator.Location = new Point(542, 56);
            musicIndicator.Name = "musicIndicator";
            musicIndicator.ShadowDecoration.CustomizableEdges = customizableEdges4;
            musicIndicator.Size = new Size(20, 7);
            musicIndicator.TabIndex = 10;
            musicIndicator.UseTransparentBackground = true;
            musicIndicator.Visible = false;
            // 
            // guna2Panel3
            // 
            guna2Panel3.BorderRadius = 10;
            guna2Panel3.CustomizableEdges = customizableEdges1;
            guna2Panel3.FillColor = Color.PaleGreen;
            guna2Panel3.Location = new Point(40, 0);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel3.Size = new Size(30, 5);
            guna2Panel3.TabIndex = 9;
            // 
            // taskIndicator
            // 
            taskIndicator.Anchor = AnchorStyles.Bottom;
            taskIndicator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            taskIndicator.BorderRadius = 5;
            taskIndicator.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            taskIndicator.Controls.Add(guna2Panel1);
            taskIndicator.CustomizableEdges = customizableEdges7;
            taskIndicator.FillColor = Color.PaleGreen;
            taskIndicator.Location = new Point(488, 56);
            taskIndicator.Name = "taskIndicator";
            taskIndicator.ShadowDecoration.CustomizableEdges = customizableEdges8;
            taskIndicator.Size = new Size(20, 7);
            taskIndicator.TabIndex = 8;
            taskIndicator.UseTransparentBackground = true;
            taskIndicator.Visible = false;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.FillColor = Color.PaleGreen;
            guna2Panel1.Location = new Point(40, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(30, 5);
            guna2Panel1.TabIndex = 9;
            // 
            // textIndicator
            // 
            textIndicator.Anchor = AnchorStyles.Bottom;
            textIndicator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            textIndicator.BorderRadius = 5;
            textIndicator.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            textIndicator.CustomizableEdges = customizableEdges9;
            textIndicator.FillColor = Color.PaleGreen;
            textIndicator.Location = new Point(435, 56);
            textIndicator.Name = "textIndicator";
            textIndicator.ShadowDecoration.CustomizableEdges = customizableEdges10;
            textIndicator.Size = new Size(20, 7);
            textIndicator.TabIndex = 7;
            textIndicator.UseTransparentBackground = true;
            textIndicator.Visible = false;
            // 
            // browserIndicator
            // 
            browserIndicator.Anchor = AnchorStyles.Bottom;
            browserIndicator.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            browserIndicator.BorderRadius = 5;
            browserIndicator.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            browserIndicator.CustomizableEdges = customizableEdges11;
            browserIndicator.FillColor = Color.PaleGreen;
            browserIndicator.Location = new Point(382, 56);
            browserIndicator.Name = "browserIndicator";
            browserIndicator.ShadowDecoration.CustomizableEdges = customizableEdges12;
            browserIndicator.Size = new Size(20, 7);
            browserIndicator.TabIndex = 6;
            browserIndicator.UseTransparentBackground = true;
            browserIndicator.Visible = false;
            // 
            // taskManagerIcon
            // 
            taskManagerIcon.Anchor = AnchorStyles.Top;
            taskManagerIcon.BackColor = Color.FromArgb(18, 18, 18);
            taskManagerIcon.Cursor = Cursors.Hand;
            taskManagerIcon.ForeColor = Color.PaleGreen;
            taskManagerIcon.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            taskManagerIcon.IconColor = Color.PaleGreen;
            taskManagerIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            taskManagerIcon.IconSize = 42;
            taskManagerIcon.Location = new Point(477, 14);
            taskManagerIcon.Name = "taskManagerIcon";
            taskManagerIcon.Padding = new Padding(5);
            taskManagerIcon.Size = new Size(42, 42);
            taskManagerIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            taskManagerIcon.TabIndex = 9;
            taskManagerIcon.TabStop = false;
            taskManagerIcon.Click += taskManagerIcon_Click;
            // 
            // musicIcon
            // 
            musicIcon.Anchor = AnchorStyles.Top;
            musicIcon.BackColor = Color.FromArgb(18, 18, 18);
            musicIcon.Cursor = Cursors.Hand;
            musicIcon.ForeColor = Color.PaleGreen;
            musicIcon.IconChar = FontAwesome.Sharp.IconChar.Spotify;
            musicIcon.IconColor = Color.PaleGreen;
            musicIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            musicIcon.IconSize = 42;
            musicIcon.Location = new Point(531, 14);
            musicIcon.Name = "musicIcon";
            musicIcon.Padding = new Padding(5);
            musicIcon.Size = new Size(42, 42);
            musicIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            musicIcon.TabIndex = 8;
            musicIcon.TabStop = false;
            musicIcon.Click += musicIcon_Click;
            // 
            // textEditorIcon
            // 
            textEditorIcon.Anchor = AnchorStyles.Top;
            textEditorIcon.BackColor = Color.FromArgb(18, 18, 18);
            textEditorIcon.Cursor = Cursors.Hand;
            textEditorIcon.ForeColor = Color.PaleGreen;
            textEditorIcon.IconChar = FontAwesome.Sharp.IconChar.NoteSticky;
            textEditorIcon.IconColor = Color.PaleGreen;
            textEditorIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            textEditorIcon.IconSize = 42;
            textEditorIcon.Location = new Point(424, 14);
            textEditorIcon.Name = "textEditorIcon";
            textEditorIcon.Padding = new Padding(5);
            textEditorIcon.Size = new Size(42, 42);
            textEditorIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            textEditorIcon.TabIndex = 7;
            textEditorIcon.TabStop = false;
            textEditorIcon.Click += textEditorIcon_Click;
            // 
            // browserIcon
            // 
            browserIcon.Anchor = AnchorStyles.Top;
            browserIcon.BackColor = Color.FromArgb(18, 18, 18);
            browserIcon.Cursor = Cursors.Hand;
            browserIcon.ForeColor = Color.PaleGreen;
            browserIcon.IconChar = FontAwesome.Sharp.IconChar.Edge;
            browserIcon.IconColor = Color.PaleGreen;
            browserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            browserIcon.IconSize = 42;
            browserIcon.Location = new Point(371, 14);
            browserIcon.Name = "browserIcon";
            browserIcon.Padding = new Padding(5);
            browserIcon.Size = new Size(42, 42);
            browserIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            browserIcon.TabIndex = 6;
            browserIcon.TabStop = false;
            browserIcon.Click += browserIcon_Click;
            // 
            // menuIcon
            // 
            menuIcon.Anchor = AnchorStyles.Top;
            menuIcon.BackColor = Color.FromArgb(18, 18, 18);
            menuIcon.ForeColor = Color.PaleGreen;
            menuIcon.IconChar = FontAwesome.Sharp.IconChar.Windows;
            menuIcon.IconColor = Color.PaleGreen;
            menuIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuIcon.IconSize = 42;
            menuIcon.Location = new Point(318, 14);
            menuIcon.Name = "menuIcon";
            menuIcon.Padding = new Padding(5);
            menuIcon.Size = new Size(42, 42);
            menuIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            menuIcon.TabIndex = 5;
            menuIcon.TabStop = false;
            // 
            // infoPanel
            // 
            infoPanel.BackColor = Color.FromArgb(18, 18, 18);
            infoPanel.Controls.Add(minimize);
            infoPanel.Controls.Add(maximize);
            infoPanel.Controls.Add(restart);
            infoPanel.Controls.Add(powerOff);
            infoPanel.Controls.Add(iconPictureBox2);
            infoPanel.Controls.Add(batteryLabel);
            infoPanel.Controls.Add(titleLabel);
            infoPanel.Controls.Add(hourLabel);
            infoPanel.Dock = DockStyle.Top;
            infoPanel.Location = new Point(0, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(1600, 28);
            infoPanel.TabIndex = 3;
            infoPanel.MouseDown += infoPanel_MouseDown;
            infoPanel.MouseMove += infoPanel_MouseMove;
            infoPanel.MouseUp += infoPanel_MouseUp;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Right;
            minimize.BackColor = Color.FromArgb(18, 18, 18);
            minimize.Cursor = Cursors.Hand;
            minimize.ForeColor = Color.PaleGreen;
            minimize.IconChar = FontAwesome.Sharp.IconChar.DownLeftAndUpRightToCenter;
            minimize.IconColor = Color.PaleGreen;
            minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minimize.IconSize = 20;
            minimize.Location = new Point(1528, 4);
            minimize.Name = "minimize";
            minimize.Size = new Size(20, 20);
            minimize.SizeMode = PictureBoxSizeMode.CenterImage;
            minimize.TabIndex = 9;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // maximize
            // 
            maximize.Anchor = AnchorStyles.Right;
            maximize.BackColor = Color.FromArgb(18, 18, 18);
            maximize.Cursor = Cursors.Hand;
            maximize.ForeColor = Color.PaleGreen;
            maximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            maximize.IconColor = Color.PaleGreen;
            maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximize.IconSize = 20;
            maximize.Location = new Point(1550, 4);
            maximize.Name = "maximize";
            maximize.Size = new Size(20, 20);
            maximize.SizeMode = PictureBoxSizeMode.CenterImage;
            maximize.TabIndex = 8;
            maximize.TabStop = false;
            maximize.Click += maximize_Click;
            // 
            // restart
            // 
            restart.Anchor = AnchorStyles.Right;
            restart.BackColor = Color.FromArgb(18, 18, 18);
            restart.Cursor = Cursors.Hand;
            restart.ForeColor = Color.PaleGreen;
            restart.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            restart.IconColor = Color.PaleGreen;
            restart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            restart.IconSize = 20;
            restart.Location = new Point(1505, 4);
            restart.Name = "restart";
            restart.Size = new Size(20, 20);
            restart.SizeMode = PictureBoxSizeMode.CenterImage;
            restart.TabIndex = 7;
            restart.TabStop = false;
            restart.Click += Restart_Click;
            // 
            // powerOff
            // 
            powerOff.Anchor = AnchorStyles.Right;
            powerOff.BackColor = Color.FromArgb(18, 18, 18);
            powerOff.Cursor = Cursors.Hand;
            powerOff.ForeColor = Color.PaleGreen;
            powerOff.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            powerOff.IconColor = Color.PaleGreen;
            powerOff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            powerOff.IconSize = 20;
            powerOff.Location = new Point(1573, 4);
            powerOff.Name = "powerOff";
            powerOff.Size = new Size(20, 20);
            powerOff.SizeMode = PictureBoxSizeMode.CenterImage;
            powerOff.TabIndex = 6;
            powerOff.TabStop = false;
            powerOff.Click += PowerOff_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.FromArgb(18, 18, 18);
            iconPictureBox2.Cursor = Cursors.PanNW;
            iconPictureBox2.ForeColor = Color.PaleGreen;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.BatteryFull;
            iconPictureBox2.IconColor = Color.PaleGreen;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 20;
            iconPictureBox2.Location = new Point(1371, 5);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(20, 20);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            iconPictureBox2.TabIndex = 5;
            iconPictureBox2.TabStop = false;
            // 
            // batteryLabel
            // 
            batteryLabel.Anchor = AnchorStyles.Right;
            batteryLabel.AutoSize = true;
            batteryLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            batteryLabel.ForeColor = Color.PaleGreen;
            batteryLabel.Location = new Point(1393, 7);
            batteryLabel.Name = "batteryLabel";
            batteryLabel.Size = new Size(41, 15);
            batteryLabel.TabIndex = 4;
            batteryLabel.Text = "100 %";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.PaleGreen;
            titleLabel.Location = new Point(12, 7);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(55, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Desktop";
            // 
            // hourLabel
            // 
            hourLabel.Anchor = AnchorStyles.Right;
            hourLabel.AutoSize = true;
            hourLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hourLabel.ForeColor = Color.PaleGreen;
            hourLabel.Location = new Point(1435, 7);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new Size(61, 15);
            hourLabel.TabIndex = 0;
            hourLabel.Text = "23: 59: 59";
            // 
            // timer
            // 
            timer.Interval = 1000;
            // 
            // Desktop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1600, 900);
            Controls.Add(desktopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Desktop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desktop";
            desktopPanel.ResumeLayout(false);
            dockPanel.ResumeLayout(false);
            musicIndicator.ResumeLayout(false);
            taskIndicator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)taskManagerIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)musicIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditorIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)browserIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuIcon).EndInit();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)restart).EndInit();
            ((System.ComponentModel.ISupportInitialize)powerOff).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label exitLabel;
        private Label minimizeLabel;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Panel desktopPanel;
        private Panel infoPanel;
        private FontAwesome.Sharp.IconPictureBox restart;
        private FontAwesome.Sharp.IconPictureBox powerOff;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label batteryLabel;
        private Label titleLabel;
        private Label hourLabel;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2ShadowPanel dockPanel;
        private FontAwesome.Sharp.IconPictureBox taskManagerIcon;
        private FontAwesome.Sharp.IconPictureBox musicIcon;
        private FontAwesome.Sharp.IconPictureBox textEditorIcon;
        private FontAwesome.Sharp.IconPictureBox browserIcon;
        private FontAwesome.Sharp.IconPictureBox menuIcon;
        private FontAwesome.Sharp.IconPictureBox maximize;
        private FontAwesome.Sharp.IconPictureBox minimize;
        private Guna.UI2.WinForms.Guna2Panel textIndicator;
        private Guna.UI2.WinForms.Guna2Panel browserIndicator;
        private Guna.UI2.WinForms.Guna2Panel musicIndicator;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel taskIndicator;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton recycleBinBtn;
        private FontAwesome.Sharp.IconButton explorerBtn;
    }
}