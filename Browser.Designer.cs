namespace ManuelOS
{
    partial class Browser
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            contentPanel = new Panel();
            formPanel = new Panel();
            restartBtn = new Guna.UI2.WinForms.Guna2Button();
            forwardBtn = new Guna.UI2.WinForms.Guna2Button();
            backBtn = new Guna.UI2.WinForms.Guna2Button();
            toSearchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            infoPanel = new Panel();
            browserPanel = new Panel();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            titleLabel = new Label();
            contentPanel.SuspendLayout();
            formPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            browserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(18, 18, 18);
            contentPanel.Controls.Add(formPanel);
            contentPanel.Controls.Add(infoPanel);
            contentPanel.Controls.Add(browserPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1280, 720);
            contentPanel.TabIndex = 0;
            // 
            // formPanel
            // 
            formPanel.BackColor = Color.FromArgb(32, 32, 32);
            formPanel.Controls.Add(restartBtn);
            formPanel.Controls.Add(forwardBtn);
            formPanel.Controls.Add(backBtn);
            formPanel.Controls.Add(toSearchTxt);
            formPanel.Dock = DockStyle.Top;
            formPanel.Location = new Point(0, 28);
            formPanel.Name = "formPanel";
            formPanel.Size = new Size(1280, 50);
            formPanel.TabIndex = 3;
            // 
            // restartBtn
            // 
            restartBtn.BorderRadius = 10;
            restartBtn.CustomizableEdges = customizableEdges17;
            restartBtn.DisabledState.BorderColor = Color.DarkGray;
            restartBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            restartBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            restartBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            restartBtn.FillColor = Color.FromArgb(32, 32, 32);
            restartBtn.Font = new Font("Segoe UI", 9F);
            restartBtn.ForeColor = Color.White;
            restartBtn.HoverState.FillColor = Color.FromArgb(18, 18, 18);
            restartBtn.Image = Properties.Resources.restart;
            restartBtn.ImageSize = new Size(18, 18);
            restartBtn.Location = new Point(88, 6);
            restartBtn.Name = "restartBtn";
            restartBtn.PressedColor = Color.FromArgb(18, 18, 18);
            restartBtn.ShadowDecoration.CustomizableEdges = customizableEdges18;
            restartBtn.Size = new Size(36, 36);
            restartBtn.TabIndex = 5;
            restartBtn.Click += restartBtn_Click;
            // 
            // forwardBtn
            // 
            forwardBtn.BorderRadius = 10;
            forwardBtn.CustomizableEdges = customizableEdges19;
            forwardBtn.DisabledState.BorderColor = Color.DarkGray;
            forwardBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            forwardBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            forwardBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            forwardBtn.FillColor = Color.FromArgb(32, 32, 32);
            forwardBtn.Font = new Font("Segoe UI", 9F);
            forwardBtn.ForeColor = Color.White;
            forwardBtn.HoverState.FillColor = Color.FromArgb(18, 18, 18);
            forwardBtn.Image = Properties.Resources.angle_right;
            forwardBtn.ImageSize = new Size(13, 18);
            forwardBtn.Location = new Point(51, 6);
            forwardBtn.Name = "forwardBtn";
            forwardBtn.PressedColor = Color.FromArgb(18, 18, 18);
            forwardBtn.ShadowDecoration.CustomizableEdges = customizableEdges20;
            forwardBtn.Size = new Size(36, 36);
            forwardBtn.TabIndex = 4;
            forwardBtn.Click += forwardBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BorderRadius = 10;
            backBtn.CustomizableEdges = customizableEdges21;
            backBtn.DisabledState.BorderColor = Color.DarkGray;
            backBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            backBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            backBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            backBtn.FillColor = Color.FromArgb(32, 32, 32);
            backBtn.Font = new Font("Segoe UI", 9F);
            backBtn.ForeColor = Color.White;
            backBtn.HoverState.FillColor = Color.FromArgb(18, 18, 18);
            backBtn.Image = Properties.Resources.angle_left;
            backBtn.ImageSize = new Size(13, 18);
            backBtn.Location = new Point(14, 6);
            backBtn.Name = "backBtn";
            backBtn.PressedColor = Color.FromArgb(18, 18, 18);
            backBtn.ShadowDecoration.CustomizableEdges = customizableEdges22;
            backBtn.Size = new Size(36, 36);
            backBtn.TabIndex = 3;
            backBtn.Click += backBtn_Click;
            // 
            // toSearchTxt
            // 
            toSearchTxt.BorderColor = Color.DimGray;
            toSearchTxt.BorderRadius = 10;
            toSearchTxt.CustomizableEdges = customizableEdges23;
            toSearchTxt.DefaultText = "";
            toSearchTxt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            toSearchTxt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            toSearchTxt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            toSearchTxt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            toSearchTxt.FillColor = Color.FromArgb(12, 12, 12);
            toSearchTxt.FocusedState.BorderColor = Color.PaleGreen;
            toSearchTxt.FocusedState.FillColor = Color.FromArgb(18, 18, 18);
            toSearchTxt.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toSearchTxt.ForeColor = Color.PaleGreen;
            toSearchTxt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            toSearchTxt.Location = new Point(262, 6);
            toSearchTxt.Name = "toSearchTxt";
            toSearchTxt.PasswordChar = '\0';
            toSearchTxt.PlaceholderForeColor = Color.FromArgb(201, 253, 201);
            toSearchTxt.PlaceholderText = "https://www.google.com";
            toSearchTxt.SelectedText = "";
            toSearchTxt.ShadowDecoration.CustomizableEdges = customizableEdges24;
            toSearchTxt.Size = new Size(826, 36);
            toSearchTxt.TabIndex = 1;
            toSearchTxt.KeyPress += toSearchTxt_KeyPress;
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(titleLabel);
            infoPanel.Dock = DockStyle.Top;
            infoPanel.Location = new Point(0, 0);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(1280, 28);
            infoPanel.TabIndex = 1;
            // 
            // browserPanel
            // 
            browserPanel.Controls.Add(webView);
            browserPanel.Dock = DockStyle.Fill;
            browserPanel.Location = new Point(0, 0);
            browserPanel.Name = "browserPanel";
            browserPanel.Size = new Size(1280, 720);
            browserPanel.TabIndex = 0;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.ForeColor = Color.PaleGreen;
            webView.Location = new Point(3, 79);
            webView.Name = "webView";
            webView.Size = new Size(1274, 638);
            webView.TabIndex = 0;
            webView.ZoomFactor = 0.9D;
            webView.SourceChanged += webView_SourceChanged;
            webView.Click += webView_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.PaleGreen;
            titleLabel.Location = new Point(8, 7);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(54, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Browser";
            // 
            // Browser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Name = "Browser";
            Size = new Size(1280, 720);
            Load += Browser_Load;
            contentPanel.ResumeLayout(false);
            formPanel.ResumeLayout(false);
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            browserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Panel browserPanel;
        private Panel infoPanel;
        private Panel formPanel;
        private Guna.UI2.WinForms.Guna2TextBox toSearchTxt;
        private Guna.UI2.WinForms.Guna2Button restartBtn;
        private Guna.UI2.WinForms.Guna2Button forwardBtn;
        private Guna.UI2.WinForms.Guna2Button backBtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Label titleLabel;
    }
}
