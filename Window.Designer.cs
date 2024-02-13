namespace ManuelOS
{
    partial class Window
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
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            contentPanel = new Panel();
            infoPanel = new Panel();
            maximize = new FontAwesome.Sharp.IconPictureBox();
            minimize = new Label();
            exit = new Label();
            titleLabel = new Label();
            transition = new Guna.UI2.WinForms.Guna2Transition();
            contentPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maximize).BeginInit();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(12, 12, 12);
            contentPanel.Controls.Add(infoPanel);
            transition.SetDecoration(contentPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1280, 720);
            contentPanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            infoPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            infoPanel.BackColor = Color.FromArgb(18, 18, 18);
            infoPanel.Controls.Add(maximize);
            infoPanel.Controls.Add(minimize);
            infoPanel.Controls.Add(exit);
            infoPanel.Controls.Add(titleLabel);
            transition.SetDecoration(infoPanel, Guna.UI2.AnimatorNS.DecorationType.None);
            infoPanel.Dock = DockStyle.Top;
            infoPanel.Location = new Point(0, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(1280, 28);
            infoPanel.TabIndex = 2;
            infoPanel.MouseDown += infoPanel_MouseDown;
            infoPanel.MouseMove += infoPanel_MouseMove;
            infoPanel.MouseUp += infoPanel_MouseUp;
            // 
            // maximize
            // 
            maximize.Anchor = AnchorStyles.Right;
            maximize.BackColor = Color.FromArgb(18, 18, 18);
            maximize.Cursor = Cursors.PanNW;
            transition.SetDecoration(maximize, Guna.UI2.AnimatorNS.DecorationType.None);
            maximize.ForeColor = Color.PaleGreen;
            maximize.IconChar = FontAwesome.Sharp.IconChar.Square;
            maximize.IconColor = Color.PaleGreen;
            maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            maximize.IconSize = 18;
            maximize.Location = new Point(1230, 7);
            maximize.Name = "maximize";
            maximize.Size = new Size(18, 18);
            maximize.SizeMode = PictureBoxSizeMode.CenterImage;
            maximize.TabIndex = 10;
            maximize.TabStop = false;
            maximize.Click += maximize_Click;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Right;
            minimize.AutoSize = true;
            transition.SetDecoration(minimize, Guna.UI2.AnimatorNS.DecorationType.None);
            minimize.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimize.ForeColor = Color.PaleGreen;
            minimize.Location = new Point(1208, 7);
            minimize.Name = "minimize";
            minimize.Size = new Size(19, 15);
            minimize.TabIndex = 9;
            minimize.Text = "__";
            minimize.TextAlign = ContentAlignment.MiddleCenter;
            minimize.Click += minimize_Click;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Right;
            exit.AutoSize = true;
            transition.SetDecoration(exit, Guna.UI2.AnimatorNS.DecorationType.None);
            exit.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.PaleGreen;
            exit.Location = new Point(1253, 7);
            exit.Name = "exit";
            exit.Size = new Size(15, 15);
            exit.TabIndex = 8;
            exit.Text = "X";
            exit.TextAlign = ContentAlignment.MiddleCenter;
            exit.Click += exit_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            transition.SetDecoration(titleLabel, Guna.UI2.AnimatorNS.DecorationType.None);
            titleLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.PaleGreen;
            titleLabel.Location = new Point(12, 7);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(53, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Window";
            // 
            // transition
            // 
            transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Particles;
            transition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = (PointF)resources.GetObject("animation4.BlindCoeff");
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = (PointF)resources.GetObject("animation4.MosaicCoeff");
            animation4.MosaicShift = (PointF)resources.GetObject("animation4.MosaicShift");
            animation4.MosaicSize = 1;
            animation4.Padding = new Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = (PointF)resources.GetObject("animation4.ScaleCoeff");
            animation4.SlideCoeff = (PointF)resources.GetObject("animation4.SlideCoeff");
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            transition.DefaultAnimation = animation4;
            transition.Interval = 100;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            Name = "Window";
            Size = new Size(1280, 720);
            contentPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maximize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Panel infoPanel;
        private Label titleLabel;
        private Label minimize;
        private Label exit;
        private Guna.UI2.WinForms.Guna2Transition transition;
        private FontAwesome.Sharp.IconPictureBox maximize;
    }
}
