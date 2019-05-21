namespace Employee_Database_Sim
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddEmployee = new System.Windows.Forms.Button();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.CBoxEmployeeSelector = new System.Windows.Forms.ComboBox();
            this.TxtEmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // BtnAddEmployee
            // 
            this.BtnAddEmployee.BackColor = System.Drawing.Color.Silver;
            this.BtnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddEmployee.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEmployee.Location = new System.Drawing.Point(121, 230);
            this.BtnAddEmployee.Name = "BtnAddEmployee";
            this.BtnAddEmployee.Size = new System.Drawing.Size(107, 23);
            this.BtnAddEmployee.TabIndex = 2;
            this.BtnAddEmployee.Text = "ADD...";
            this.BtnAddEmployee.UseVisualStyleBackColor = false;
            this.BtnAddEmployee.Click += new System.EventHandler(this.BtnAddEmployee_Click);
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(99, 91);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 21);
            this.TxtFirstName.TabIndex = 3;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(99, 133);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 21);
            this.TxtLastName.TabIndex = 4;
            // 
            // CBoxEmployeeSelector
            // 
            this.CBoxEmployeeSelector.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CBoxEmployeeSelector.FormattingEnabled = true;
            this.CBoxEmployeeSelector.Items.AddRange(new object[] {
            "Employee Type",
            "1 - Sales",
            "2 - Contract",
            "3 - Hourly",
            "4 - Salary"});
            this.CBoxEmployeeSelector.Location = new System.Drawing.Point(26, 46);
            this.CBoxEmployeeSelector.Name = "CBoxEmployeeSelector";
            this.CBoxEmployeeSelector.Size = new System.Drawing.Size(121, 21);
            this.CBoxEmployeeSelector.TabIndex = 5;
            this.CBoxEmployeeSelector.Text = "--Select--";
            this.CBoxEmployeeSelector.SelectedIndexChanged += new System.EventHandler(this.CBoxEmployeeSelector_SelectedIndexChanged);
            // 
            // TxtEmpID
            // 
            this.TxtEmpID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtEmpID.Location = new System.Drawing.Point(172, 46);
            this.TxtEmpID.Name = "TxtEmpID";
            this.TxtEmpID.Size = new System.Drawing.Size(100, 21);
            this.TxtEmpID.TabIndex = 6;
            this.TxtEmpID.Text = "Employee ID";
            this.TxtEmpID.TextChanged += new System.EventHandler(this.TxtEmpID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(33, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(300, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEmpID);
            this.Controls.Add(this.CBoxEmployeeSelector);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Controls.Add(this.BtnAddEmployee);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Archon Industries";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button BtnAddEmployee;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.ComboBox CBoxEmployeeSelector;
        private System.Windows.Forms.TextBox TxtEmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

