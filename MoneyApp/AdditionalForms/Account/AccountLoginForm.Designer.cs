namespace MoneyApp.AdditionalForms.Account
{
    partial class AccountLoginForm
    {

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
        protected void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbLogin = new MaterialSkin.Controls.MaterialTextBox();
            userModelBindingSource = new BindingSource(components);
            tbPassword = new MaterialSkin.Controls.MaterialTextBox();
            tlpLogIn = new TableLayoutPanel();
            tbConfirmationPass = new MaterialSkin.Controls.MaterialTextBox();
            btnAction = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).BeginInit();
            tlpLogIn.SuspendLayout();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.AnimateReadOnly = false;
            tbLogin.BorderStyle = BorderStyle.None;
            tbLogin.DataBindings.Add(new Binding("Text", userModelBindingSource, "Username", true));
            tbLogin.Depth = 0;
            tbLogin.Dock = DockStyle.Fill;
            tbLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbLogin.Hint = "Login";
            tbLogin.LeadingIcon = null;
            tbLogin.Location = new Point(3, 3);
            tbLogin.MaxLength = 50;
            tbLogin.MouseState = MaterialSkin.MouseState.OUT;
            tbLogin.Multiline = false;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(234, 50);
            tbLogin.TabIndex = 2;
            tbLogin.Text = "";
            tbLogin.TrailingIcon = null;
            // 
            // userModelBindingSource
            // 
            userModelBindingSource.DataSource = typeof(Model.UserItem.UserModel);
            // 
            // tbPassword
            // 
            tbPassword.AnimateReadOnly = false;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.DataBindings.Add(new Binding("Text", userModelBindingSource, "Password", true));
            tbPassword.Depth = 0;
            tbPassword.Dock = DockStyle.Fill;
            tbPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbPassword.Hint = "Password";
            tbPassword.LeadingIcon = null;
            tbPassword.Location = new Point(3, 73);
            tbPassword.MaxLength = 50;
            tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(234, 50);
            tbPassword.TabIndex = 3;
            tbPassword.Text = "";
            tbPassword.TrailingIcon = null;
            // 
            // tlpLogIn
            // 
            tlpLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpLogIn.ColumnCount = 1;
            tlpLogIn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpLogIn.Controls.Add(tbConfirmationPass, 0, 2);
            tlpLogIn.Controls.Add(tbPassword, 0, 1);
            tlpLogIn.Controls.Add(tbLogin, 0, 0);
            tlpLogIn.Controls.Add(btnAction, 0, 3);
            tlpLogIn.Location = new Point(80, 70);
            tlpLogIn.Name = "tlpLogIn";
            tlpLogIn.RowCount = 4;
            tlpLogIn.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogIn.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogIn.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogIn.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlpLogIn.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpLogIn.Size = new Size(240, 280);
            tlpLogIn.TabIndex = 4;
            // 
            // tbConfirmationPass
            // 
            tbConfirmationPass.AnimateReadOnly = false;
            tbConfirmationPass.BorderStyle = BorderStyle.None;
            tbConfirmationPass.DataBindings.Add(new Binding("Text", userModelBindingSource, "Password", true));
            tbConfirmationPass.Depth = 0;
            tbConfirmationPass.Dock = DockStyle.Fill;
            tbConfirmationPass.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbConfirmationPass.Hint = "Confirm password";
            tbConfirmationPass.LeadingIcon = null;
            tbConfirmationPass.Location = new Point(3, 143);
            tbConfirmationPass.MaxLength = 50;
            tbConfirmationPass.MouseState = MaterialSkin.MouseState.OUT;
            tbConfirmationPass.Multiline = false;
            tbConfirmationPass.Name = "tbConfirmationPass";
            tbConfirmationPass.Size = new Size(234, 50);
            tbConfirmationPass.TabIndex = 5;
            tbConfirmationPass.Text = "";
            tbConfirmationPass.TrailingIcon = null;
            // 
            // btnAction
            // 
            btnAction.Anchor = AnchorStyles.Bottom;
            btnAction.AutoSize = false;
            btnAction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAction.Depth = 0;
            btnAction.HighEmphasis = true;
            btnAction.Icon = null;
            btnAction.Location = new Point(45, 230);
            btnAction.Margin = new Padding(0, 15, 0, 15);
            btnAction.MaximumSize = new Size(150, 35);
            btnAction.MinimumSize = new Size(150, 35);
            btnAction.MouseState = MaterialSkin.MouseState.HOVER;
            btnAction.Name = "btnAction";
            btnAction.NoAccentTextColor = Color.Empty;
            btnAction.Size = new Size(150, 35);
            btnAction.TabIndex = 4;
            btnAction.Text = "Action";
            btnAction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAction.UseAccentColor = false;
            btnAction.UseVisualStyleBackColor = true;
            btnAction.Click += BtnActionUserID_Click;
            // 
            // AccountLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 350);
            Controls.Add(tlpLogIn);
            MinimumSize = new Size(400, 350);
            Name = "AccountLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)userModelBindingSource).EndInit();
            tlpLogIn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        protected MaterialSkin.Controls.MaterialTextBox tbLogin;
        protected MaterialSkin.Controls.MaterialTextBox tbPassword;
        protected TableLayoutPanel tlpLogIn;
        protected MaterialSkin.Controls.MaterialButton btnAction;
        protected MaterialSkin.Controls.MaterialTextBox tbConfirmationPass;
        protected BindingSource userModelBindingSource;
        private System.ComponentModel.IContainer components;
    }
}