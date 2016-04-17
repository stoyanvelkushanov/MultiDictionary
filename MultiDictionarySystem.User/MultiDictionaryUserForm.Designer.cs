namespace MultiDictionarySystem.User
{
    partial class MultiDictionaryUserForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGermanContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadEnglishContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToDbBtn = new System.Windows.Forms.Button();
            this.newWordTxtBox = new System.Windows.Forms.TextBox();
            this.removeWordTxtBox = new System.Windows.Forms.TextBox();
            this.removeFromDbBtn = new System.Windows.Forms.Button();
            this.searchWordTxtBox = new System.Windows.Forms.TextBox();
            this.searchFromDbBtn = new System.Windows.Forms.Button();
            this.originalWordsListBox = new System.Windows.Forms.ListBox();
            this.translatedWordsListBox = new System.Windows.Forms.ListBox();
            this.howItSoundsBtn = new System.Windows.Forms.Button();
            this.showAllBtn = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.informationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(757, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGermanContentToolStripMenuItem,
            this.loadEnglishContentToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadGermanContentToolStripMenuItem
            // 
            this.loadGermanContentToolStripMenuItem.Name = "loadGermanContentToolStripMenuItem";
            this.loadGermanContentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.loadGermanContentToolStripMenuItem.Text = "Load German Content";
            this.loadGermanContentToolStripMenuItem.Click += new System.EventHandler(this.loadGermanContentToolStripMenuItem_Click);
            // 
            // loadEnglishContentToolStripMenuItem
            // 
            this.loadEnglishContentToolStripMenuItem.Name = "loadEnglishContentToolStripMenuItem";
            this.loadEnglishContentToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.loadEnglishContentToolStripMenuItem.Text = "Load English Content";
            this.loadEnglishContentToolStripMenuItem.Click += new System.EventHandler(this.loadEnglishContentToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // addToDbBtn
            // 
            this.addToDbBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.addToDbBtn.Location = new System.Drawing.Point(140, 50);
            this.addToDbBtn.Name = "addToDbBtn";
            this.addToDbBtn.Size = new System.Drawing.Size(75, 23);
            this.addToDbBtn.TabIndex = 2;
            this.addToDbBtn.Text = "Add";
            this.addToDbBtn.UseVisualStyleBackColor = true;
            this.addToDbBtn.Visible = false;
            this.addToDbBtn.Click += new System.EventHandler(this.addToDbBtn_Click);
            // 
            // newWordTxtBox
            // 
            this.newWordTxtBox.Location = new System.Drawing.Point(12, 52);
            this.newWordTxtBox.Name = "newWordTxtBox";
            this.newWordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.newWordTxtBox.TabIndex = 3;
            this.newWordTxtBox.Visible = false;
            this.newWordTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyPressed);
            // 
            // removeWordTxtBox
            // 
            this.removeWordTxtBox.Location = new System.Drawing.Point(12, 118);
            this.removeWordTxtBox.Name = "removeWordTxtBox";
            this.removeWordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.removeWordTxtBox.TabIndex = 6;
            this.removeWordTxtBox.Visible = false;
            // 
            // removeFromDbBtn
            // 
            this.removeFromDbBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.removeFromDbBtn.Location = new System.Drawing.Point(140, 116);
            this.removeFromDbBtn.Name = "removeFromDbBtn";
            this.removeFromDbBtn.Size = new System.Drawing.Size(75, 23);
            this.removeFromDbBtn.TabIndex = 5;
            this.removeFromDbBtn.Text = "Remove";
            this.removeFromDbBtn.UseVisualStyleBackColor = true;
            this.removeFromDbBtn.Visible = false;
            this.removeFromDbBtn.Click += new System.EventHandler(this.removeFromDbBtn_Click);
            // 
            // searchWordTxtBox
            // 
            this.searchWordTxtBox.Location = new System.Drawing.Point(12, 184);
            this.searchWordTxtBox.Name = "searchWordTxtBox";
            this.searchWordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.searchWordTxtBox.TabIndex = 9;
            this.searchWordTxtBox.Visible = false;
            this.searchWordTxtBox.TextChanged += new System.EventHandler(this.AutoSearch);
            // 
            // searchFromDbBtn
            // 
            this.searchFromDbBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.searchFromDbBtn.Location = new System.Drawing.Point(140, 182);
            this.searchFromDbBtn.Name = "searchFromDbBtn";
            this.searchFromDbBtn.Size = new System.Drawing.Size(75, 23);
            this.searchFromDbBtn.TabIndex = 8;
            this.searchFromDbBtn.Text = "Search";
            this.searchFromDbBtn.UseVisualStyleBackColor = true;
            this.searchFromDbBtn.Visible = false;
            this.searchFromDbBtn.Click += new System.EventHandler(this.searchFromDbBtn_Click);
            // 
            // originalWordsListBox
            // 
            this.originalWordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalWordsListBox.FormattingEnabled = true;
            this.originalWordsListBox.ItemHeight = 20;
            this.originalWordsListBox.Location = new System.Drawing.Point(247, 38);
            this.originalWordsListBox.Name = "originalWordsListBox";
            this.originalWordsListBox.Size = new System.Drawing.Size(200, 484);
            this.originalWordsListBox.TabIndex = 10;
            this.originalWordsListBox.Visible = false;
            this.originalWordsListBox.SelectedIndexChanged += new System.EventHandler(this.originalWordsListBox_SelectedIndexChanged);
            this.originalWordsListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HowItSoundsCall);
            // 
            // translatedWordsListBox
            // 
            this.translatedWordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translatedWordsListBox.FormattingEnabled = true;
            this.translatedWordsListBox.ItemHeight = 20;
            this.translatedWordsListBox.Location = new System.Drawing.Point(453, 38);
            this.translatedWordsListBox.Name = "translatedWordsListBox";
            this.translatedWordsListBox.Size = new System.Drawing.Size(292, 484);
            this.translatedWordsListBox.TabIndex = 11;
            this.translatedWordsListBox.Visible = false;
            this.translatedWordsListBox.SelectedIndexChanged += new System.EventHandler(this.translatedWordsListBox_SelectedIndexChanged);
            // 
            // howItSoundsBtn
            // 
            this.howItSoundsBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.howItSoundsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howItSoundsBtn.Location = new System.Drawing.Point(12, 311);
            this.howItSoundsBtn.Name = "howItSoundsBtn";
            this.howItSoundsBtn.Size = new System.Drawing.Size(203, 59);
            this.howItSoundsBtn.TabIndex = 14;
            this.howItSoundsBtn.Text = "How It Sounds";
            this.howItSoundsBtn.UseVisualStyleBackColor = true;
            this.howItSoundsBtn.Visible = false;
            this.howItSoundsBtn.Click += new System.EventHandler(this.howItSoundsBtn_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.showAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Location = new System.Drawing.Point(12, 463);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Size = new System.Drawing.Size(203, 59);
            this.showAllBtn.TabIndex = 15;
            this.showAllBtn.Text = "Show all words";
            this.showAllBtn.UseVisualStyleBackColor = true;
            this.showAllBtn.Visible = false;
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(247, 19);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(13, 13);
            this.count.TabIndex = 16;
            this.count.Text = "0";
            this.count.Visible = false;
            // 
            // MultiDictionaryUserForm
            // 
            this.ClientSize = new System.Drawing.Size(757, 538);
            this.Controls.Add(this.count);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.howItSoundsBtn);
            this.Controls.Add(this.translatedWordsListBox);
            this.Controls.Add(this.originalWordsListBox);
            this.Controls.Add(this.searchWordTxtBox);
            this.Controls.Add(this.searchFromDbBtn);
            this.Controls.Add(this.removeWordTxtBox);
            this.Controls.Add(this.removeFromDbBtn);
            this.Controls.Add(this.newWordTxtBox);
            this.Controls.Add(this.addToDbBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MultiDictionaryUserForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGermanContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadEnglishContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button addToDbBtn;
        private System.Windows.Forms.TextBox newWordTxtBox;
        private System.Windows.Forms.TextBox removeWordTxtBox;
        private System.Windows.Forms.Button removeFromDbBtn;
        private System.Windows.Forms.TextBox searchWordTxtBox;
        private System.Windows.Forms.Button searchFromDbBtn;
        private System.Windows.Forms.ListBox originalWordsListBox;
        private System.Windows.Forms.ListBox translatedWordsListBox;
        private System.Windows.Forms.Button howItSoundsBtn;
        private System.Windows.Forms.Button showAllBtn;
        private System.Windows.Forms.Label count;
    }
}

