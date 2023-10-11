namespace MoneyApp.AdditionalForms
{
    partial class MoneyTransactionForm
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
            tlpTypeTransaction = new TableLayoutPanel();
            labelFirstToWallet = new MaterialSkin.Controls.MaterialLabel();
            labelFirstFromTransaction = new MaterialSkin.Controls.MaterialLabel();
            labelSecondToWallet = new MaterialSkin.Controls.MaterialLabel();
            labelSecondFromTransaction = new MaterialSkin.Controls.MaterialLabel();
            tlpTypeMoneyTransaction = new TableLayoutPanel();
            labelDebit = new MaterialSkin.Controls.MaterialLabel();
            labelTansaction = new MaterialSkin.Controls.MaterialLabel();
            tbTransactionMoney = new MaterialSkin.Controls.MaterialTextBox2();
            tbDebitMoney = new MaterialSkin.Controls.MaterialTextBox2();
            tbComment = new MaterialSkin.Controls.MaterialTextBox();
            btnOk = new MaterialSkin.Controls.MaterialButton();
            btnCancle = new MaterialSkin.Controls.MaterialButton();
            dateTimePicker = new DateTimePicker();
            tlbTransactionMoneyButton = new TableLayoutPanel();
            tlpTypeTransaction.SuspendLayout();
            tlpTypeMoneyTransaction.SuspendLayout();
            tlbTransactionMoneyButton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpTypeTransaction
            // 
            tlpTypeTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpTypeTransaction.ColumnCount = 2;
            tlpTypeTransaction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTypeTransaction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTypeTransaction.Controls.Add(labelFirstToWallet, 0, 0);
            tlpTypeTransaction.Controls.Add(labelFirstFromTransaction, 1, 0);
            tlpTypeTransaction.Controls.Add(labelSecondToWallet, 0, 1);
            tlpTypeTransaction.Controls.Add(labelSecondFromTransaction, 1, 1);
            tlpTypeTransaction.Location = new Point(10, 70);
            tlpTypeTransaction.Name = "tlpTypeTransaction";
            tlpTypeTransaction.RowCount = 2;
            tlpTypeTransaction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTypeTransaction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTypeTransaction.Size = new Size(310, 70);
            tlpTypeTransaction.TabIndex = 0;
            // 
            // labelFirstToWallet
            // 
            labelFirstToWallet.AutoSize = true;
            labelFirstToWallet.BackColor = Color.Cyan;
            labelFirstToWallet.Depth = 0;
            labelFirstToWallet.Dock = DockStyle.Fill;
            labelFirstToWallet.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFirstToWallet.Location = new Point(5, 5);
            labelFirstToWallet.Margin = new Padding(5);
            labelFirstToWallet.MouseState = MaterialSkin.MouseState.HOVER;
            labelFirstToWallet.Name = "labelFirstToWallet";
            labelFirstToWallet.Size = new Size(145, 25);
            labelFirstToWallet.TabIndex = 0;
            labelFirstToWallet.Text = "From account";
            labelFirstToWallet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFirstFromTransaction
            // 
            labelFirstFromTransaction.AutoSize = true;
            labelFirstFromTransaction.BackColor = Color.Plum;
            labelFirstFromTransaction.Depth = 0;
            labelFirstFromTransaction.Dock = DockStyle.Fill;
            labelFirstFromTransaction.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelFirstFromTransaction.Location = new Point(160, 5);
            labelFirstFromTransaction.Margin = new Padding(5);
            labelFirstFromTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            labelFirstFromTransaction.Name = "labelFirstFromTransaction";
            labelFirstFromTransaction.Size = new Size(145, 25);
            labelFirstFromTransaction.TabIndex = 1;
            labelFirstFromTransaction.Text = "Per category for";
            labelFirstFromTransaction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSecondToWallet
            // 
            labelSecondToWallet.AutoSize = true;
            labelSecondToWallet.BackColor = Color.Cyan;
            labelSecondToWallet.Depth = 0;
            labelSecondToWallet.Dock = DockStyle.Fill;
            labelSecondToWallet.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSecondToWallet.Location = new Point(5, 40);
            labelSecondToWallet.Margin = new Padding(5);
            labelSecondToWallet.MouseState = MaterialSkin.MouseState.HOVER;
            labelSecondToWallet.Name = "labelSecondToWallet";
            labelSecondToWallet.Size = new Size(145, 25);
            labelSecondToWallet.TabIndex = 2;
            labelSecondToWallet.Text = "Account";
            labelSecondToWallet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSecondFromTransaction
            // 
            labelSecondFromTransaction.AutoSize = true;
            labelSecondFromTransaction.BackColor = Color.Plum;
            labelSecondFromTransaction.Depth = 0;
            labelSecondFromTransaction.Dock = DockStyle.Fill;
            labelSecondFromTransaction.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelSecondFromTransaction.Location = new Point(160, 40);
            labelSecondFromTransaction.Margin = new Padding(5);
            labelSecondFromTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            labelSecondFromTransaction.Name = "labelSecondFromTransaction";
            labelSecondFromTransaction.Size = new Size(145, 25);
            labelSecondFromTransaction.TabIndex = 3;
            labelSecondFromTransaction.Text = "Type";
            labelSecondFromTransaction.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpTypeMoneyTransaction
            // 
            tlpTypeMoneyTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpTypeMoneyTransaction.ColumnCount = 2;
            tlpTypeMoneyTransaction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTypeMoneyTransaction.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpTypeMoneyTransaction.Controls.Add(labelDebit, 0, 0);
            tlpTypeMoneyTransaction.Controls.Add(labelTansaction, 1, 0);
            tlpTypeMoneyTransaction.Controls.Add(tbTransactionMoney, 1, 1);
            tlpTypeMoneyTransaction.Controls.Add(tbDebitMoney, 0, 1);
            tlpTypeMoneyTransaction.Location = new Point(10, 146);
            tlpTypeMoneyTransaction.Name = "tlpTypeMoneyTransaction";
            tlpTypeMoneyTransaction.RowCount = 2;
            tlpTypeMoneyTransaction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTypeMoneyTransaction.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpTypeMoneyTransaction.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpTypeMoneyTransaction.Size = new Size(310, 112);
            tlpTypeMoneyTransaction.TabIndex = 1;
            // 
            // labelDebit
            // 
            labelDebit.AutoSize = true;
            labelDebit.BackColor = Color.Cyan;
            labelDebit.Depth = 0;
            labelDebit.Dock = DockStyle.Fill;
            labelDebit.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelDebit.Location = new Point(5, 5);
            labelDebit.Margin = new Padding(5);
            labelDebit.MouseState = MaterialSkin.MouseState.HOVER;
            labelDebit.Name = "labelDebit";
            labelDebit.Size = new Size(145, 46);
            labelDebit.TabIndex = 1;
            labelDebit.Text = "Debit";
            labelDebit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTansaction
            // 
            labelTansaction.AutoSize = true;
            labelTansaction.Depth = 0;
            labelTansaction.Dock = DockStyle.Fill;
            labelTansaction.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelTansaction.Location = new Point(160, 5);
            labelTansaction.Margin = new Padding(5);
            labelTansaction.MouseState = MaterialSkin.MouseState.HOVER;
            labelTansaction.Name = "labelTansaction";
            labelTansaction.Size = new Size(145, 46);
            labelTansaction.TabIndex = 4;
            labelTansaction.Text = "Transaction";
            labelTansaction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbTransactionMoney
            // 
            tbTransactionMoney.AnimateReadOnly = false;
            tbTransactionMoney.BackgroundImageLayout = ImageLayout.None;
            tbTransactionMoney.CharacterCasing = CharacterCasing.Normal;
            tbTransactionMoney.Depth = 0;
            tbTransactionMoney.Dock = DockStyle.Fill;
            tbTransactionMoney.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbTransactionMoney.HideSelection = true;
            tbTransactionMoney.Hint = "Money";
            tbTransactionMoney.LeadingIcon = null;
            tbTransactionMoney.Location = new Point(158, 59);
            tbTransactionMoney.MaxLength = 32767;
            tbTransactionMoney.MouseState = MaterialSkin.MouseState.OUT;
            tbTransactionMoney.Name = "tbTransactionMoney";
            tbTransactionMoney.PasswordChar = '\0';
            tbTransactionMoney.PrefixSuffixText = null;
            tbTransactionMoney.ReadOnly = false;
            tbTransactionMoney.RightToLeft = RightToLeft.No;
            tbTransactionMoney.SelectedText = "";
            tbTransactionMoney.SelectionLength = 0;
            tbTransactionMoney.SelectionStart = 0;
            tbTransactionMoney.ShortcutsEnabled = true;
            tbTransactionMoney.Size = new Size(149, 48);
            tbTransactionMoney.TabIndex = 5;
            tbTransactionMoney.TabStop = false;
            tbTransactionMoney.TextAlign = HorizontalAlignment.Center;
            tbTransactionMoney.TrailingIcon = null;
            tbTransactionMoney.UseSystemPasswordChar = false;
            // 
            // tbDebitMoney
            // 
            tbDebitMoney.AnimateReadOnly = false;
            tbDebitMoney.BackgroundImageLayout = ImageLayout.None;
            tbDebitMoney.CharacterCasing = CharacterCasing.Normal;
            tbDebitMoney.Depth = 0;
            tbDebitMoney.Dock = DockStyle.Fill;
            tbDebitMoney.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbDebitMoney.HideSelection = true;
            tbDebitMoney.Hint = "Money";
            tbDebitMoney.LeadingIcon = null;
            tbDebitMoney.Location = new Point(3, 59);
            tbDebitMoney.MaxLength = 32767;
            tbDebitMoney.MouseState = MaterialSkin.MouseState.OUT;
            tbDebitMoney.Name = "tbDebitMoney";
            tbDebitMoney.PasswordChar = '\0';
            tbDebitMoney.PrefixSuffixText = null;
            tbDebitMoney.ReadOnly = false;
            tbDebitMoney.RightToLeft = RightToLeft.No;
            tbDebitMoney.SelectedText = "";
            tbDebitMoney.SelectionLength = 0;
            tbDebitMoney.SelectionStart = 0;
            tbDebitMoney.ShortcutsEnabled = true;
            tbDebitMoney.Size = new Size(149, 48);
            tbDebitMoney.TabIndex = 6;
            tbDebitMoney.TabStop = false;
            tbDebitMoney.TextAlign = HorizontalAlignment.Center;
            tbDebitMoney.TrailingIcon = null;
            tbDebitMoney.UseSystemPasswordChar = false;
            // 
            // tbComment
            // 
            tbComment.AccessibleDescription = "";
            tbComment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbComment.AnimateReadOnly = false;
            tbComment.BorderStyle = BorderStyle.None;
            tbComment.Depth = 0;
            tbComment.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbComment.LeadingIcon = null;
            tbComment.Location = new Point(10, 264);
            tbComment.MaxLength = 50;
            tbComment.MouseState = MaterialSkin.MouseState.OUT;
            tbComment.Multiline = false;
            tbComment.Name = "tbComment";
            tbComment.Size = new Size(310, 50);
            tbComment.TabIndex = 3;
            tbComment.Tag = "Comment";
            tbComment.Text = "";
            tbComment.TrailingIcon = null;
            // 
            // btnOk
            // 
            btnOk.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnOk.Depth = 0;
            btnOk.Dock = DockStyle.Fill;
            btnOk.HighEmphasis = true;
            btnOk.Icon = null;
            btnOk.Location = new Point(4, 6);
            btnOk.Margin = new Padding(4, 6, 4, 6);
            btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            btnOk.Name = "btnOk";
            btnOk.NoAccentTextColor = Color.Empty;
            btnOk.Size = new Size(82, 28);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnOk.UseAccentColor = false;
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            btnCancle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancle.Depth = 0;
            btnCancle.Dock = DockStyle.Fill;
            btnCancle.HighEmphasis = true;
            btnCancle.Icon = null;
            btnCancle.Location = new Point(224, 6);
            btnCancle.Margin = new Padding(4, 6, 4, 6);
            btnCancle.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancle.Name = "btnCancle";
            btnCancle.NoAccentTextColor = Color.Empty;
            btnCancle.Size = new Size(82, 28);
            btnCancle.TabIndex = 2;
            btnCancle.Text = "Cancle";
            btnCancle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancle.UseAccentColor = false;
            btnCancle.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Dock = DockStyle.Fill;
            dateTimePicker.Location = new Point(93, 8);
            dateTimePicker.Margin = new Padding(3, 8, 3, 8);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(124, 23);
            dateTimePicker.TabIndex = 5;
            // 
            // tlbTransactionMoneyButton
            // 
            tlbTransactionMoneyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlbTransactionMoneyButton.ColumnCount = 3;
            tlbTransactionMoneyButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlbTransactionMoneyButton.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tlbTransactionMoneyButton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlbTransactionMoneyButton.Controls.Add(dateTimePicker, 1, 0);
            tlbTransactionMoneyButton.Controls.Add(btnCancle, 2, 0);
            tlbTransactionMoneyButton.Controls.Add(btnOk, 0, 0);
            tlbTransactionMoneyButton.Location = new Point(10, 320);
            tlbTransactionMoneyButton.Name = "tlbTransactionMoneyButton";
            tlbTransactionMoneyButton.RowCount = 1;
            tlbTransactionMoneyButton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlbTransactionMoneyButton.Size = new Size(310, 40);
            tlbTransactionMoneyButton.TabIndex = 6;
            // 
            // MoneyTransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 365);
            Controls.Add(tlbTransactionMoneyButton);
            Controls.Add(tbComment);
            Controls.Add(tlpTypeMoneyTransaction);
            Controls.Add(tlpTypeTransaction);
            MinimumSize = new Size(330, 365);
            Name = "MoneyTransactionForm";
            Text = "Transaction Money";
            tlpTypeTransaction.ResumeLayout(false);
            tlpTypeTransaction.PerformLayout();
            tlpTypeMoneyTransaction.ResumeLayout(false);
            tlpTypeMoneyTransaction.PerformLayout();
            tlbTransactionMoneyButton.ResumeLayout(false);
            tlbTransactionMoneyButton.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpTypeTransaction;
        private MaterialSkin.Controls.MaterialLabel labelFirstToWallet;
        private MaterialSkin.Controls.MaterialLabel labelFirstFromTransaction;
        private MaterialSkin.Controls.MaterialLabel labelSecondToWallet;
        private MaterialSkin.Controls.MaterialLabel labelSecondFromTransaction;
        private TableLayoutPanel tlpTypeMoneyTransaction;
        private MaterialSkin.Controls.MaterialLabel labelDebit;
        private MaterialSkin.Controls.MaterialLabel labelTansaction;
        private MaterialSkin.Controls.MaterialTextBox tbComment;
        private MaterialSkin.Controls.MaterialTextBox2 tbTransactionMoney;
        private MaterialSkin.Controls.MaterialTextBox2 tbDebitMoney;
        private MaterialSkin.Controls.MaterialButton btnOk;
        private MaterialSkin.Controls.MaterialButton btnCancle;
        private DateTimePicker dateTimePicker;
        private TableLayoutPanel tlbTransactionMoneyButton;
    }
}