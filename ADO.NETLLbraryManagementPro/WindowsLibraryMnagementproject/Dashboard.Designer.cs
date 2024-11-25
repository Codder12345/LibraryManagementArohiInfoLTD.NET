namespace WindowsLibraryMnagementproject
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtclose = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.txtclose.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(10, 10);
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // booksToolStripMenuItem
            // 
            resources.ApplyResources(this.booksToolStripMenuItem, "booksToolStripMenuItem");
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBookToolStripMenuItem});
            this.booksToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.book;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            // 
            // addNewBookToolStripMenuItem
            // 
            this.addNewBookToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.addBook;
            resources.ApplyResources(this.addNewBookToolStripMenuItem, "addNewBookToolStripMenuItem");
            this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.search_book;
            resources.ApplyResources(this.viewBookToolStripMenuItem, "viewBookToolStripMenuItem");
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentDetailToolStripMenuItem});
            this.studentToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.student;
            resources.ApplyResources(this.studentToolStripMenuItem, "studentToolStripMenuItem");
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.Addstudent;
            resources.ApplyResources(this.addStudentToolStripMenuItem, "addStudentToolStripMenuItem");
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewStudentDetailToolStripMenuItem
            // 
            this.viewStudentDetailToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.viewstudent;
            resources.ApplyResources(this.viewStudentDetailToolStripMenuItem, "viewStudentDetailToolStripMenuItem");
            this.viewStudentDetailToolStripMenuItem.Name = "viewStudentDetailToolStripMenuItem";
            this.viewStudentDetailToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDetailToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueBookToolStripMenuItem1,
            this.returnBookToolStripMenuItem});
            this.issueBookToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.issuebook;
            resources.ApplyResources(this.issueBookToolStripMenuItem, "issueBookToolStripMenuItem");
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Click += new System.EventHandler(this.issueBookToolStripMenuItem_Click);
            // 
            // issueBookToolStripMenuItem1
            // 
            this.issueBookToolStripMenuItem1.Image = global::WindowsLibraryMnagementproject.Properties.Resources.issue1;
            resources.ApplyResources(this.issueBookToolStripMenuItem1, "issueBookToolStripMenuItem1");
            this.issueBookToolStripMenuItem1.Name = "issueBookToolStripMenuItem1";
            this.issueBookToolStripMenuItem1.Click += new System.EventHandler(this.issueBookToolStripMenuItem1_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.returnbook1;
            resources.ApplyResources(this.returnBookToolStripMenuItem, "returnBookToolStripMenuItem");
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // bookDetailsToolStripMenuItem
            // 
            this.bookDetailsToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.complete;
            resources.ApplyResources(this.bookDetailsToolStripMenuItem, "bookDetailsToolStripMenuItem");
            this.bookDetailsToolStripMenuItem.Name = "bookDetailsToolStripMenuItem";
            this.bookDetailsToolStripMenuItem.Click += new System.EventHandler(this.bookDetailsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WindowsLibraryMnagementproject.Properties.Resources.exit;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            // 
            // txtclose
            // 
            this.txtclose.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.txtclose.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            resources.ApplyResources(this.txtclose, "txtclose");
            this.txtclose.GripMargin = new System.Windows.Forms.Padding(0);
            this.txtclose.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.txtclose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.bookDetailsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.txtclose.Name = "txtclose";
            this.txtclose.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.txtclose_ItemClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::WindowsLibraryMnagementproject.Properties.Resources.Library;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtclose);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.txtclose;
            this.Name = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.txtclose.ResumeLayout(false);
            this.txtclose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip txtclose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
    }
}