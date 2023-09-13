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
            tpCategory = new TabPage();
            tabOperation = new TabPage();
            tabStatistics = new TabPage();
            menuStrip.SuspendLayout();
            mtcMoney.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenu });
            menuStrip.Location = new Point(3, 64);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(394, 24);
            menuStrip.TabIndex = 2;
            menuStrip.Text = "menuStrip1";
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
            mtcMoney.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            tpAccountsCash.Location = new Point(4, 24);
            tpAccountsCash.Name = "tpAccountsCash";
            tpAccountsCash.Padding = new Padding(3);
            tpAccountsCash.Size = new Size(378, 375);
            tpAccountsCash.TabIndex = 0;
            tpAccountsCash.Text = "Accounts Cash";
            tpAccountsCash.UseVisualStyleBackColor = true;
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
            ClientSize = new Size(400, 500);
            Controls.Add(mtcMoney);
            Controls.Add(menuStrip);
            DrawerTabControl = mtcMoney;
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(400, 500);
            Name = "MoneyAppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Money";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            mtcMoney.ResumeLayout(false);
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
    }
}
