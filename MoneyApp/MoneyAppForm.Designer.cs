namespace MoneyApp
{
    partial class MoneyAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            toolStripMenu = new ToolStripMenuItem();
            changeUserToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            mtcMoney = new MaterialSkin.Controls.MaterialTabControl();
            tpAccountsCash = new TabPage();
            tpAccountsCashBTN = new TableLayoutPanel();
            btnAddItem = new MaterialSkin.Controls.MaterialButton();
            btnEditItem = new MaterialSkin.Controls.MaterialButton();
            btnDeliteItem = new MaterialSkin.Controls.MaterialButton();
            tlpFirstWallet = new TableLayoutPanel();
            tcAccountCash = new TabControl();
            tabPageAccounts = new TabPage();
            listBoxAccounts = new MaterialSkin.Controls.MaterialListBox();
            tabPageDebit = new TabPage();
            listBoxDebit = new MaterialSkin.Controls.MaterialListBox();
            tpCategory = new TabPage();
            tabOperation = new TabPage();
            tabStatistics = new TabPage();
            menuStrip.SuspendLayout();
            mtcMoney.SuspendLayout();
            tpAccountsCash.SuspendLayout();
            tpAccountsCashBTN.SuspendLayout();
            tlpFirstWallet.SuspendLayout();
            tcAccountCash.SuspendLayout();
            tabPageAccounts.SuspendLayout();
            tabPageDebit.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenu });
            menuStrip.Location = new Point(3, 64);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(394, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip";
            // 
            // toolStripMenu
            // 
            toolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { changeUserToolStripMenuItem, exitToolStripMenuItem });
            toolStripMenu.Name = "toolStripMenu";
            toolStripMenu.Size = new Size(37, 20);
            toolStripMenu.Text = "File";
            // 
            // changeUserToolStripMenuItem
            // 
            changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            changeUserToolStripMenuItem.Size = new Size(141, 22);
            changeUserToolStripMenuItem.Text = "Change User";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // mtcMoney
            // 
            mtcMoney.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtcMoney.Controls.Add(tpAccountsCash);
            mtcMoney.Controls.Add(tpCategory);
            mtcMoney.Controls.Add(tabOperation);
            mtcMoney.Controls.Add(tabStatistics);
            mtcMoney.Depth = 0;
            mtcMoney.Location = new Point(7, 91);
            mtcMoney.MouseState = MaterialSkin.MouseState.HOVER;
            mtcMoney.Multiline = true;
            mtcMoney.Name = "mtcMoney";
            mtcMoney.SelectedIndex = 0;
            mtcMoney.Size = new Size(386, 403);
            mtcMoney.TabIndex = 1;
            // 
            // tpAccountsCash
            // 
            tpAccountsCash.Controls.Add(tpAccountsCashBTN);
            tpAccountsCash.Controls.Add(tlpFirstWallet);
            tpAccountsCash.Location = new Point(4, 24);
            tpAccountsCash.Name = "tpAccountsCash";
            tpAccountsCash.Padding = new Padding(3);
            tpAccountsCash.Size = new Size(378, 375);
            tpAccountsCash.TabIndex = 0;
            tpAccountsCash.Text = "Accounts Cash";
            tpAccountsCash.UseVisualStyleBackColor = true;
            // 
            // tpAccountsCashBTN
            // 
            tpAccountsCashBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tpAccountsCashBTN.ColumnCount = 3;
            tpAccountsCashBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tpAccountsCashBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tpAccountsCashBTN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tpAccountsCashBTN.Controls.Add(btnAddItem, 0, 0);
            tpAccountsCashBTN.Controls.Add(btnEditItem, 1, 0);
            tpAccountsCashBTN.Controls.Add(btnDeliteItem, 2, 0);
            tpAccountsCashBTN.Location = new Point(3, 332);
            tpAccountsCashBTN.Name = "tpAccountsCashBTN";
            tpAccountsCashBTN.RowCount = 1;
            tpAccountsCashBTN.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tpAccountsCashBTN.Size = new Size(369, 37);
            tpAccountsCashBTN.TabIndex = 2;
            // 
            // btnAddItem
            // 
            btnAddItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddItem.Depth = 0;
            btnAddItem.Dock = DockStyle.Fill;
            btnAddItem.HighEmphasis = true;
            btnAddItem.Icon = null;
            btnAddItem.Location = new Point(4, 6);
            btnAddItem.Margin = new Padding(4, 6, 4, 6);
            btnAddItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddItem.Name = "btnAddItem";
            btnAddItem.NoAccentTextColor = Color.Empty;
            btnAddItem.Size = new Size(115, 25);
            btnAddItem.TabIndex = 0;
            btnAddItem.Text = "Add";
            btnAddItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddItem.UseAccentColor = false;
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += BtnAddItem_Click;
            // 
            // btnEditItem
            // 
            btnEditItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditItem.Depth = 0;
            btnEditItem.Dock = DockStyle.Fill;
            btnEditItem.HighEmphasis = true;
            btnEditItem.Icon = null;
            btnEditItem.Location = new Point(127, 6);
            btnEditItem.Margin = new Padding(4, 6, 4, 6);
            btnEditItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditItem.Name = "btnEditItem";
            btnEditItem.NoAccentTextColor = Color.Empty;
            btnEditItem.Size = new Size(115, 25);
            btnEditItem.TabIndex = 1;
            btnEditItem.Text = "Edit";
            btnEditItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditItem.UseAccentColor = false;
            btnEditItem.UseVisualStyleBackColor = true;
            btnEditItem.Click += BtnEditItemAccountCash_Click;
            // 
            // btnDeliteItem
            // 
            btnDeliteItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeliteItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeliteItem.Depth = 0;
            btnDeliteItem.Dock = DockStyle.Fill;
            btnDeliteItem.HighEmphasis = true;
            btnDeliteItem.Icon = null;
            btnDeliteItem.Location = new Point(250, 6);
            btnDeliteItem.Margin = new Padding(4, 6, 4, 6);
            btnDeliteItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeliteItem.Name = "btnDeliteItem";
            btnDeliteItem.NoAccentTextColor = Color.Empty;
            btnDeliteItem.Size = new Size(115, 25);
            btnDeliteItem.TabIndex = 2;
            btnDeliteItem.Text = "Delite";
            btnDeliteItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeliteItem.UseAccentColor = false;
            btnDeliteItem.UseVisualStyleBackColor = true;
            btnDeliteItem.Click += BtnDeliteItem_Click;
            // 
            // tlpFirstWallet
            // 
            tlpFirstWallet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpFirstWallet.ColumnCount = 1;
            tlpFirstWallet.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFirstWallet.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFirstWallet.Controls.Add(tcAccountCash, 0, 0);
            tlpFirstWallet.Location = new Point(3, 3);
            tlpFirstWallet.MinimumSize = new Size(370, 320);
            tlpFirstWallet.Name = "tlpFirstWallet";
            tlpFirstWallet.RowCount = 1;
            tlpFirstWallet.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpFirstWallet.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFirstWallet.Size = new Size(370, 326);
            tlpFirstWallet.TabIndex = 1;
            // 
            // tcAccountCash
            // 
            tcAccountCash.Controls.Add(tabPageAccounts);
            tcAccountCash.Controls.Add(tabPageDebit);
            tcAccountCash.Dock = DockStyle.Fill;
            tcAccountCash.Location = new Point(3, 3);
            tcAccountCash.Name = "tcAccountCash";
            tcAccountCash.SelectedIndex = 0;
            tcAccountCash.Size = new Size(364, 320);
            tcAccountCash.TabIndex = 0;
            // 
            // tabPageAccounts
            // 
            tabPageAccounts.Controls.Add(listBoxAccounts);
            tabPageAccounts.Location = new Point(4, 24);
            tabPageAccounts.Name = "tabPageAccounts";
            tabPageAccounts.Padding = new Padding(3);
            tabPageAccounts.Size = new Size(356, 292);
            tabPageAccounts.TabIndex = 0;
            tabPageAccounts.Text = "Accounts";
            tabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // listBoxAccounts
            // 
            listBoxAccounts.BackColor = Color.White;
            listBoxAccounts.BorderColor = Color.LightGray;
            listBoxAccounts.Depth = 0;
            listBoxAccounts.Dock = DockStyle.Fill;
            listBoxAccounts.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxAccounts.Location = new Point(3, 3);
            listBoxAccounts.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxAccounts.Name = "listBoxAccounts";
            listBoxAccounts.SelectedIndex = -1;
            listBoxAccounts.SelectedItem = null;
            listBoxAccounts.Size = new Size(350, 286);
            listBoxAccounts.TabIndex = 0;
            // 
            // tabPageDebit
            // 
            tabPageDebit.Controls.Add(listBoxDebit);
            tabPageDebit.Location = new Point(4, 24);
            tabPageDebit.Name = "tabPageDebit";
            tabPageDebit.Padding = new Padding(3);
            tabPageDebit.Size = new Size(356, 292);
            tabPageDebit.TabIndex = 1;
            tabPageDebit.Text = "Debit";
            tabPageDebit.UseVisualStyleBackColor = true;
            // 
            // listBoxDebit
            // 
            listBoxDebit.BackColor = Color.White;
            listBoxDebit.BorderColor = Color.LightGray;
            listBoxDebit.Depth = 0;
            listBoxDebit.Dock = DockStyle.Fill;
            listBoxDebit.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxDebit.Location = new Point(3, 3);
            listBoxDebit.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxDebit.Name = "listBoxDebit";
            listBoxDebit.SelectedIndex = -1;
            listBoxDebit.SelectedItem = null;
            listBoxDebit.Size = new Size(350, 286);
            listBoxDebit.TabIndex = 0;
            // 
            // tpCategory
            // 
            tpCategory.Location = new Point(4, 24);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(3);
            tpCategory.Size = new Size(378, 375);
            tpCategory.TabIndex = 1;
            tpCategory.Text = "Category";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // tabOperation
            // 
            tabOperation.Location = new Point(4, 24);
            tabOperation.Name = "tabOperation";
            tabOperation.Padding = new Padding(3);
            tabOperation.Size = new Size(378, 375);
            tabOperation.TabIndex = 2;
            tabOperation.Text = "Operation";
            tabOperation.UseVisualStyleBackColor = true;
            // 
            // tabStatistics
            // 
            tabStatistics.Location = new Point(4, 24);
            tabStatistics.Name = "tabStatistics";
            tabStatistics.Padding = new Padding(3);
            tabStatistics.Size = new Size(378, 375);
            tabStatistics.TabIndex = 3;
            tabStatistics.Text = "Statistics";
            tabStatistics.UseVisualStyleBackColor = true;
            // 
            // MoneyAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 495);
            Controls.Add(mtcMoney);
            Controls.Add(menuStrip);
            DrawerTabControl = mtcMoney;
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(400, 495);
            Name = "MoneyAppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Money";
            Load += MoneyAppForm_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            mtcMoney.ResumeLayout(false);
            tpAccountsCash.ResumeLayout(false);
            tpAccountsCashBTN.ResumeLayout(false);
            tpAccountsCashBTN.PerformLayout();
            tlpFirstWallet.ResumeLayout(false);
            tcAccountCash.ResumeLayout(false);
            tabPageAccounts.ResumeLayout(false);
            tabPageDebit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenu;
        private ToolStripMenuItem changeUserToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialTabControl mtcMoney;
        private TabPage tpAccountsCash;
        private TabPage tpCategory;
        private TabPage tabOperation;
        private TabPage tabStatistics;
        private TableLayoutPanel tlpFirstWallet;
        private TableLayoutPanel tpAccountsCashBTN;
        private MaterialSkin.Controls.MaterialButton btnAddItem;
        private MaterialSkin.Controls.MaterialButton btnEditItem;
        private MaterialSkin.Controls.MaterialButton btnDeliteItem;
        private TabControl tcAccountCash;
        private TabPage tabPageAccounts;
        private TabPage tabPageDebit;
        private MaterialSkin.Controls.MaterialListBox listBoxAccounts;
        private MaterialSkin.Controls.MaterialListBox listBoxDebit;
    }
}
