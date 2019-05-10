namespace CPSC_332_Assignment_5
{
    partial class Main
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cb_Records = new System.Windows.Forms.ComboBox();
            this.btn_Displayrecord = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.cb_Sort = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(33, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(573, 136);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cb_Records
            // 
            this.cb_Records.DisplayMember = "2";
            this.cb_Records.FormattingEnabled = true;
            this.cb_Records.Items.AddRange(new object[] {
            "Artist",
            "Contact Info",
            "Customer",
            "Location Info",
            "Preferences",
            "Shows",
            "Style",
            "Work"});
            this.cb_Records.Location = new System.Drawing.Point(33, 231);
            this.cb_Records.Name = "cb_Records";
            this.cb_Records.Size = new System.Drawing.Size(215, 21);
            this.cb_Records.TabIndex = 1;
            this.cb_Records.Text = "Record";
            // 
            // btn_Displayrecord
            // 
            this.btn_Displayrecord.Location = new System.Drawing.Point(33, 265);
            this.btn_Displayrecord.Name = "btn_Displayrecord";
            this.btn_Displayrecord.Size = new System.Drawing.Size(215, 23);
            this.btn_Displayrecord.TabIndex = 3;
            this.btn_Displayrecord.Text = "Display Record";
            this.btn_Displayrecord.UseVisualStyleBackColor = true;
            this.btn_Displayrecord.Click += new System.EventHandler(this.btn_Displayrecord_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(644, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(344, 265);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(153, 23);
            this.btn_Sort.TabIndex = 7;
            this.btn_Sort.Text = "Sort";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // cb_Sort
            // 
            this.cb_Sort.FormattingEnabled = true;
            this.cb_Sort.Location = new System.Drawing.Point(344, 231);
            this.cb_Sort.Name = "cb_Sort";
            this.cb_Sort.Size = new System.Drawing.Size(153, 21);
            this.cb_Sort.TabIndex = 8;
            this.cb_Sort.Text = "Sort By";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 335);
            this.Controls.Add(this.cb_Sort);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_Displayrecord);
            this.Controls.Add(this.cb_Records);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Art Gallery Database";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cb_Records;
        private System.Windows.Forms.Button btn_Displayrecord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox cb_Sort;
    }
}