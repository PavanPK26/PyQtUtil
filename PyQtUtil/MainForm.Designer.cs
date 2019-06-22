namespace PyQtUtil
{
    partial class MainForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Ui2Py_Page = new System.Windows.Forms.TabPage();
            this.UIBrowse_Btn = new System.Windows.Forms.Button();
            this.GenPy_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UIPath = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.Ui2Py_Page.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.Ui2Py_Page);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(320, 243);
            this.MainTabControl.TabIndex = 0;
            // 
            // Ui2Py_Page
            // 
            this.Ui2Py_Page.Controls.Add(this.UIBrowse_Btn);
            this.Ui2Py_Page.Controls.Add(this.GenPy_btn);
            this.Ui2Py_Page.Controls.Add(this.label1);
            this.Ui2Py_Page.Controls.Add(this.UIPath);
            this.Ui2Py_Page.Location = new System.Drawing.Point(4, 22);
            this.Ui2Py_Page.Name = "Ui2Py_Page";
            this.Ui2Py_Page.Padding = new System.Windows.Forms.Padding(3);
            this.Ui2Py_Page.Size = new System.Drawing.Size(312, 217);
            this.Ui2Py_Page.TabIndex = 0;
            this.Ui2Py_Page.Text = "UI to Py";
            this.Ui2Py_Page.UseVisualStyleBackColor = true;
            // 
            // UIBrowse_Btn
            // 
            this.UIBrowse_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.UIBrowse_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UIBrowse_Btn.ForeColor = System.Drawing.Color.White;
            this.UIBrowse_Btn.Location = new System.Drawing.Point(234, 32);
            this.UIBrowse_Btn.Name = "UIBrowse_Btn";
            this.UIBrowse_Btn.Size = new System.Drawing.Size(63, 23);
            this.UIBrowse_Btn.TabIndex = 3;
            this.UIBrowse_Btn.Text = "Browse";
            this.UIBrowse_Btn.UseVisualStyleBackColor = false;
            this.UIBrowse_Btn.Click += new System.EventHandler(this.UIBrowse_Btn_Click);
            // 
            // GenPy_btn
            // 
            this.GenPy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.GenPy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenPy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.GenPy_btn.ForeColor = System.Drawing.Color.White;
            this.GenPy_btn.Location = new System.Drawing.Point(176, 61);
            this.GenPy_btn.Name = "GenPy_btn";
            this.GenPy_btn.Size = new System.Drawing.Size(121, 33);
            this.GenPy_btn.TabIndex = 2;
            this.GenPy_btn.Text = "Generate .py";
            this.GenPy_btn.UseVisualStyleBackColor = false;
            this.GenPy_btn.Click += new System.EventHandler(this.GenPy_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter UI Path : ";
            // 
            // UIPath
            // 
            this.UIPath.Location = new System.Drawing.Point(8, 32);
            this.UIPath.Name = "UIPath";
            this.UIPath.Size = new System.Drawing.Size(220, 20);
            this.UIPath.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(45, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.IndianRed;
            this.ExitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(0, 220);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(320, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 243);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "PyQt Utility";
            this.MainTabControl.ResumeLayout(false);
            this.Ui2Py_Page.ResumeLayout(false);
            this.Ui2Py_Page.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage Ui2Py_Page;
        private System.Windows.Forms.Button GenPy_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UIPath;
        private System.Windows.Forms.Button UIBrowse_Btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.Button ExitBtn;
    }
}

