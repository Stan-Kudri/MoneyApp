namespace MoneyApp.AdditionalForms.AccountCash
{
    partial class AccountCashForm
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
            tlpAccount = new TableLayoutPanel();
            tbName = new MaterialSkin.Controls.MaterialTextBox();
            accountModelBindingSource = new BindingSource(components);
            tbBalance = new MaterialSkin.Controls.MaterialTextBox();
            cbTypeWallet = new MaterialSkin.Controls.MaterialComboBox();
            itemsBSTypeWallet = new BindingSource(components);
            selectableTypeWalletBindingSource = new BindingSource(components);
            cbCurrency = new MaterialSkin.Controls.MaterialComboBox();
            itemsBSCurrency = new BindingSource(components);
            selectableCurrencyWalletBindingSource = new BindingSource(components);
            tbDescription = new MaterialSkin.Controls.MaterialTextBox();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            tlpAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accountModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBSTypeWallet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectableTypeWalletBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBSCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selectableCurrencyWalletBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tlpAccount
            // 
            tlpAccount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpAccount.ColumnCount = 1;
            tlpAccount.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpAccount.Controls.Add(tbName, 0, 0);
            tlpAccount.Controls.Add(tbBalance, 0, 3);
            tlpAccount.Controls.Add(cbTypeWallet, 0, 1);
            tlpAccount.Controls.Add(cbCurrency, 0, 2);
            tlpAccount.Controls.Add(tbDescription, 0, 4);
            tlpAccount.Controls.Add(btnSave, 0, 5);
            tlpAccount.Location = new Point(6, 67);
            tlpAccount.Name = "tlpAccount";
            tlpAccount.RowCount = 6;
            tlpAccount.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAccount.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAccount.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAccount.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAccount.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAccount.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tlpAccount.Size = new Size(288, 327);
            tlpAccount.TabIndex = 0;
            // 
            // tbName
            // 
            tbName.AnimateReadOnly = false;
            tbName.BorderStyle = BorderStyle.None;
            tbName.DataBindings.Add(new Binding("Text", accountModelBindingSource, "Name", true));
            tbName.Depth = 0;
            tbName.Dock = DockStyle.Fill;
            tbName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbName.Hint = "Name";
            tbName.LeadingIcon = null;
            tbName.Location = new Point(3, 3);
            tbName.MaxLength = 50;
            tbName.MouseState = MaterialSkin.MouseState.OUT;
            tbName.Multiline = false;
            tbName.Name = "tbName";
            tbName.Size = new Size(282, 50);
            tbName.TabIndex = 0;
            tbName.Text = "";
            tbName.TrailingIcon = null;
            // 
            // accountModelBindingSource
            // 
            accountModelBindingSource.DataSource = typeof(Model.Item.WalletItem.AccountModel);
            // 
            // tbBalance
            // 
            tbBalance.AnimateReadOnly = false;
            tbBalance.BorderStyle = BorderStyle.None;
            tbBalance.DataBindings.Add(new Binding("Text", accountModelBindingSource, "Balance", true));
            tbBalance.Depth = 0;
            tbBalance.Dock = DockStyle.Fill;
            tbBalance.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbBalance.Hint = "Balance";
            tbBalance.LeadingIcon = null;
            tbBalance.Location = new Point(3, 165);
            tbBalance.MaxLength = 50;
            tbBalance.MouseState = MaterialSkin.MouseState.OUT;
            tbBalance.Multiline = false;
            tbBalance.Name = "tbBalance";
            tbBalance.Size = new Size(282, 50);
            tbBalance.TabIndex = 3;
            tbBalance.Text = "";
            tbBalance.TrailingIcon = null;
            tbBalance.KeyPress += TbBalance_KeyPress;
            // 
            // cbTypeWallet
            // 
            cbTypeWallet.AutoResize = false;
            cbTypeWallet.BackColor = Color.FromArgb(255, 255, 255);
            cbTypeWallet.DataBindings.Add(new Binding("SelectedValue", accountModelBindingSource, "TypeWallet", true));
            cbTypeWallet.DataSource = itemsBSTypeWallet;
            cbTypeWallet.Depth = 0;
            cbTypeWallet.Dock = DockStyle.Fill;
            cbTypeWallet.DrawMode = DrawMode.OwnerDrawVariable;
            cbTypeWallet.DropDownHeight = 174;
            cbTypeWallet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeWallet.DropDownWidth = 121;
            cbTypeWallet.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbTypeWallet.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbTypeWallet.FormattingEnabled = true;
            cbTypeWallet.Hint = "Type";
            cbTypeWallet.IntegralHeight = false;
            cbTypeWallet.ItemHeight = 43;
            cbTypeWallet.Location = new Point(3, 57);
            cbTypeWallet.MaxDropDownItems = 4;
            cbTypeWallet.MouseState = MaterialSkin.MouseState.OUT;
            cbTypeWallet.Name = "cbTypeWallet";
            cbTypeWallet.Size = new Size(282, 49);
            cbTypeWallet.StartIndex = 0;
            cbTypeWallet.TabIndex = 9;
            // 
            // itemsBSTypeWallet
            // 
            itemsBSTypeWallet.DataMember = "Items";
            itemsBSTypeWallet.DataSource = selectableTypeWalletBindingSource;
            // 
            // selectableTypeWalletBindingSource
            // 
            selectableTypeWalletBindingSource.DataSource = typeof(Model.Item.WalletItem.SelectableTypeWallet);
            // 
            // cbCurrency
            // 
            cbCurrency.AutoResize = false;
            cbCurrency.BackColor = Color.FromArgb(255, 255, 255);
            cbCurrency.DataBindings.Add(new Binding("SelectedValue", accountModelBindingSource, "TypeCurrency", true));
            cbCurrency.DataSource = itemsBSCurrency;
            cbCurrency.Depth = 0;
            cbCurrency.Dock = DockStyle.Fill;
            cbCurrency.DrawMode = DrawMode.OwnerDrawVariable;
            cbCurrency.DropDownHeight = 174;
            cbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrency.DropDownWidth = 121;
            cbCurrency.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCurrency.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Hint = "Currency";
            cbCurrency.IntegralHeight = false;
            cbCurrency.ItemHeight = 43;
            cbCurrency.Location = new Point(3, 111);
            cbCurrency.MaxDropDownItems = 4;
            cbCurrency.MouseState = MaterialSkin.MouseState.OUT;
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(282, 49);
            cbCurrency.StartIndex = 0;
            cbCurrency.TabIndex = 10;
            // 
            // itemsBSCurrency
            // 
            itemsBSCurrency.DataMember = "Items";
            itemsBSCurrency.DataSource = selectableCurrencyWalletBindingSource;
            // 
            // selectableCurrencyWalletBindingSource
            // 
            selectableCurrencyWalletBindingSource.DataSource = typeof(Model.Item.WalletItem.SelectableCurrencyWallet);
            // 
            // tbDescription
            // 
            tbDescription.AnimateReadOnly = false;
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.DataBindings.Add(new Binding("Text", accountModelBindingSource, "Description", true));
            tbDescription.Depth = 0;
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDescription.Hint = "Description";
            tbDescription.LeadingIcon = null;
            tbDescription.Location = new Point(3, 219);
            tbDescription.MaxLength = 50;
            tbDescription.MouseState = MaterialSkin.MouseState.OUT;
            tbDescription.Multiline = false;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(282, 50);
            tbDescription.TabIndex = 11;
            tbDescription.Text = "";
            tbDescription.TrailingIcon = null;
            // 
            // btnSave
            // 
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.Dock = DockStyle.Bottom;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(10, 281);
            btnSave.Margin = new Padding(10);
            btnSave.MinimumSize = new Size(260, 36);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(268, 36);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click;
            // 
            // AccountCashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(tlpAccount);
            MinimumSize = new Size(300, 400);
            Name = "AccountCashForm";
            Text = "Account Cash";
            Load += AccountCash_Load;
            tlpAccount.ResumeLayout(false);
            tlpAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)accountModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBSTypeWallet).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectableTypeWalletBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBSCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)selectableCurrencyWalletBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        protected TableLayoutPanel tlpAccount;
        protected MaterialSkin.Controls.MaterialTextBox tbName;
        protected MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        protected MaterialSkin.Controls.MaterialTextBox tbBalance;
        protected MaterialSkin.Controls.MaterialComboBox cbTypeWallet;
        protected MaterialSkin.Controls.MaterialComboBox cbCurrency;
        protected MaterialSkin.Controls.MaterialTextBox tbDescription;
        protected MaterialSkin.Controls.MaterialButton btnSave;
        protected BindingSource selectableTypeWalletBindingSource;
        protected BindingSource itemsBSTypeWallet;
        protected BindingSource selectableCurrencyWalletBindingSource;
        protected BindingSource itemsBSCurrency;
        protected BindingSource accountModelBindingSource;
        private System.ComponentModel.IContainer components;
    }
}