namespace WindowsFormsApplication1
{
    partial class EmployeeSalaryForm
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.salaryAccountTextBox = new System.Windows.Forms.TextBox();
            this.salaryAccountLabel = new System.Windows.Forms.Label();
            this.totalAccountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.employeeShowListBox = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(12, 23);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(110, 20);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(277, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(110, 55);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(277, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(78, 62);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID";
            // 
            // salaryAccountTextBox
            // 
            this.salaryAccountTextBox.Location = new System.Drawing.Point(110, 85);
            this.salaryAccountTextBox.Name = "salaryAccountTextBox";
            this.salaryAccountTextBox.Size = new System.Drawing.Size(277, 20);
            this.salaryAccountTextBox.TabIndex = 5;
            // 
            // salaryAccountLabel
            // 
            this.salaryAccountLabel.AutoSize = true;
            this.salaryAccountLabel.Location = new System.Drawing.Point(17, 88);
            this.salaryAccountLabel.Name = "salaryAccountLabel";
            this.salaryAccountLabel.Size = new System.Drawing.Size(79, 13);
            this.salaryAccountLabel.TabIndex = 4;
            this.salaryAccountLabel.Text = "Salary Account";
            // 
            // totalAccountTextBox
            // 
            this.totalAccountTextBox.Location = new System.Drawing.Point(263, 342);
            this.totalAccountTextBox.Name = "totalAccountTextBox";
            this.totalAccountTextBox.Size = new System.Drawing.Size(124, 20);
            this.totalAccountTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Account";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(312, 124);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(312, 153);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // employeeShowListBox
            // 
            this.employeeShowListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.idHeader,
            this.accountSalary});
            this.employeeShowListBox.GridLines = true;
            this.employeeShowListBox.Location = new System.Drawing.Point(20, 193);
            this.employeeShowListBox.Name = "employeeShowListBox";
            this.employeeShowListBox.Size = new System.Drawing.Size(367, 129);
            this.employeeShowListBox.TabIndex = 11;
            this.employeeShowListBox.UseCompatibleStateImageBehavior = false;
            this.employeeShowListBox.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Employee Name";
            this.nameHeader.Width = 111;
            // 
            // idHeader
            // 
            this.idHeader.Text = "ID";
            this.idHeader.Width = 61;
            // 
            // accountSalary
            // 
            this.accountSalary.Text = "Account Salary";
            this.accountSalary.Width = 187;
            // 
            // EmployeeSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 374);
            this.Controls.Add(this.employeeShowListBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalAccountTextBox);
            this.Controls.Add(this.salaryAccountTextBox);
            this.Controls.Add(this.salaryAccountLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeNameLabel);
            this.Name = "EmployeeSalaryForm";
            this.Text = "Employee Salarty";
            this.Load += new System.EventHandler(this.EmployeeSalaryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox salaryAccountTextBox;
        private System.Windows.Forms.Label salaryAccountLabel;
        private System.Windows.Forms.TextBox totalAccountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListView employeeShowListBox;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader idHeader;
        private System.Windows.Forms.ColumnHeader accountSalary;
    }
}

