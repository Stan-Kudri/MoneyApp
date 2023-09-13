namespace MoneyApp.AdditionalForms
{
    partial class StartupForm
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
            btnLogIn = new MaterialSkin.Controls.MaterialButton();
            btnRegistration = new MaterialSkin.Controls.MaterialButton();
            tlpStartupForm = new TableLayoutPanel();
            tlpStartupForm.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogIn.Depth = 0;
            btnLogIn.Dock = DockStyle.Fill;
            btnLogIn.HighEmphasis = true;
            btnLogIn.Icon = null;
            btnLogIn.Location = new Point(6, 6);
            btnLogIn.Margin = new Padding(6);
            btnLogIn.MinimumSize = new Size(150, 35);
            btnLogIn.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogIn.Name = "btnLogIn";
            btnLogIn.NoAccentTextColor = Color.Empty;
            btnLogIn.Size = new Size(150, 38);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Log In";
            btnLogIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogIn.UseAccentColor = false;
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += BtnLogIn_Click;
            // 
            // btnRegistration
            // 
            btnRegistration.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRegistration.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRegistration.Depth = 0;
            btnRegistration.Dock = DockStyle.Fill;
            btnRegistration.HighEmphasis = true;
            btnRegistration.Icon = null;
            btnRegistration.Location = new Point(6, 56);
            btnRegistration.Margin = new Padding(6);
            btnRegistration.MinimumSize = new Size(150, 35);
            btnRegistration.MouseState = MaterialSkin.MouseState.HOVER;
            btnRegistration.Name = "btnRegistration";
            btnRegistration.NoAccentTextColor = Color.Empty;
            btnRegistration.Size = new Size(150, 38);
            btnRegistration.TabIndex = 1;
            btnRegistration.Text = "Registration";
            btnRegistration.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRegistration.UseAccentColor = false;
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += BtnRegistration_Click;
            // 
            // tlpStartupForm
            // 
            tlpStartupForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpStartupForm.ColumnCount = 1;
            tlpStartupForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpStartupForm.Controls.Add(btnLogIn, 0, 0);
            tlpStartupForm.Controls.Add(btnRegistration, 0, 1);
            tlpStartupForm.Location = new Point(70, 100);
            tlpStartupForm.Name = "tlpStartupForm";
            tlpStartupForm.RowCount = 2;
            tlpStartupForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStartupForm.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpStartupForm.Size = new Size(159, 100);
            tlpStartupForm.TabIndex = 2;
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 250);
            Controls.Add(tlpStartupForm);
            MinimumSize = new Size(300, 250);
            Name = "StartupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Startup Form";
            tlpStartupForm.ResumeLayout(false);
            tlpStartupForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnLogIn;
        private MaterialSkin.Controls.MaterialButton btnRegistration;
        private TableLayoutPanel tlpStartupForm;
    }
}