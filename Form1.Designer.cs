namespace tx_multipledocumentprint
{
    partial class Form1
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
            this.textControl1 = new TXTextControl.TextControl();
            this.buttonBar1 = new TXTextControl.ButtonBar();
            this.rulerBar2 = new TXTextControl.RulerBar();
            this.statusBar1 = new TXTextControl.StatusBar();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.page2Rows2ColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pages3Rows2ColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pages4Rows4ColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pages3Rows3ColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pages4Rows4ColumnsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pages8Rows4ColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.ButtonBar = this.buttonBar1;
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(25, 77);
            this.textControl1.Name = "textControl1";
            this.textControl1.RulerBar = this.rulerBar2;
            this.textControl1.Size = new System.Drawing.Size(850, 355);
            this.textControl1.StatusBar = this.statusBar1;
            this.textControl1.TabIndex = 0;
            this.textControl1.VerticalRulerBar = this.rulerBar1;
            // 
            // buttonBar1
            // 
            this.buttonBar1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBar1.Location = new System.Drawing.Point(0, 24);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(875, 28);
            this.buttonBar1.TabIndex = 1;
            this.buttonBar1.Text = "buttonBar1";
            // 
            // rulerBar2
            // 
            this.rulerBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar2.Location = new System.Drawing.Point(0, 52);
            this.rulerBar2.Name = "rulerBar2";
            this.rulerBar2.Size = new System.Drawing.Size(875, 25);
            this.rulerBar2.TabIndex = 4;
            this.rulerBar2.Text = "rulerBar2";
            // 
            // statusBar1
            // 
            this.statusBar1.BackColor = System.Drawing.SystemColors.Control;
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 432);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(875, 22);
            this.statusBar1.TabIndex = 2;
            // 
            // rulerBar1
            // 
            this.rulerBar1.Alignment = TXTextControl.RulerBarAlignment.Left;
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.rulerBar1.Location = new System.Drawing.Point(0, 77);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(25, 355);
            this.rulerBar1.TabIndex = 3;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem1});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageToolStripMenuItem,
            this.toolStripMenuItem2,
            this.page2Rows2ColumnsToolStripMenuItem,
            this.pages3Rows2ColumnsToolStripMenuItem,
            this.pages4Rows4ColumnsToolStripMenuItem,
            this.pages3Rows3ColumnsToolStripMenuItem,
            this.pages4Rows4ColumnsToolStripMenuItem1,
            this.pages8Rows4ColumnsToolStripMenuItem});
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem1.Text = "PrintPreview";
            // 
            // pageToolStripMenuItem
            // 
            this.pageToolStripMenuItem.Name = "pageToolStripMenuItem";
            this.pageToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pageToolStripMenuItem.Tag = "1";
            this.pageToolStripMenuItem.Text = "1 page";
            this.pageToolStripMenuItem.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItem2.Tag = "2";
            this.toolStripMenuItem2.Text = "2 pages (2 rows, 1 column)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // page2Rows2ColumnsToolStripMenuItem
            // 
            this.page2Rows2ColumnsToolStripMenuItem.Name = "page2Rows2ColumnsToolStripMenuItem";
            this.page2Rows2ColumnsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.page2Rows2ColumnsToolStripMenuItem.Tag = "4";
            this.page2Rows2ColumnsToolStripMenuItem.Text = "4 pages (2 rows, 2 columns)";
            this.page2Rows2ColumnsToolStripMenuItem.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // pages3Rows2ColumnsToolStripMenuItem
            // 
            this.pages3Rows2ColumnsToolStripMenuItem.Name = "pages3Rows2ColumnsToolStripMenuItem";
            this.pages3Rows2ColumnsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pages3Rows2ColumnsToolStripMenuItem.Tag = "6";
            this.pages3Rows2ColumnsToolStripMenuItem.Text = "6 pages (3 rows, 2 columns)";
            this.pages3Rows2ColumnsToolStripMenuItem.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // pages4Rows4ColumnsToolStripMenuItem
            // 
            this.pages4Rows4ColumnsToolStripMenuItem.Name = "pages4Rows4ColumnsToolStripMenuItem";
            this.pages4Rows4ColumnsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pages4Rows4ColumnsToolStripMenuItem.Tag = "8";
            this.pages4Rows4ColumnsToolStripMenuItem.Text = "8 pages (4 rows, 4 columns)";
            this.pages4Rows4ColumnsToolStripMenuItem.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // pages3Rows3ColumnsToolStripMenuItem
            // 
            this.pages3Rows3ColumnsToolStripMenuItem.Name = "pages3Rows3ColumnsToolStripMenuItem";
            this.pages3Rows3ColumnsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pages3Rows3ColumnsToolStripMenuItem.Tag = "9";
            this.pages3Rows3ColumnsToolStripMenuItem.Text = "9 pages (3 rows, 3 columns)";
            this.pages3Rows3ColumnsToolStripMenuItem.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // pages4Rows4ColumnsToolStripMenuItem1
            // 
            this.pages4Rows4ColumnsToolStripMenuItem1.Name = "pages4Rows4ColumnsToolStripMenuItem1";
            this.pages4Rows4ColumnsToolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.pages4Rows4ColumnsToolStripMenuItem1.Tag = "16";
            this.pages4Rows4ColumnsToolStripMenuItem1.Text = "16 pages (4 rows, 4 columns)";
            this.pages4Rows4ColumnsToolStripMenuItem1.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // pages8Rows4ColumnsToolStripMenuItem
            // 
            this.pages8Rows4ColumnsToolStripMenuItem.Name = "pages8Rows4ColumnsToolStripMenuItem";
            this.pages8Rows4ColumnsToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.pages8Rows4ColumnsToolStripMenuItem.Tag = "32";
            this.pages8Rows4ColumnsToolStripMenuItem.Text = "32 pages (8 rows, 4 columns)";
            this.pages8Rows4ColumnsToolStripMenuItem.Click += new System.EventHandler(this.PrintMenuItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 454);
            this.Controls.Add(this.textControl1);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.rulerBar2);
            this.Controls.Add(this.buttonBar1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "TX Text Control Sample: Printing multiple pages on a sheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.ButtonBar buttonBar1;
        private TXTextControl.RulerBar rulerBar2;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem page2Rows2ColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pages3Rows2ColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pages4Rows4ColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pages3Rows3ColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pages4Rows4ColumnsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pages8Rows4ColumnsToolStripMenuItem;
    }
}

