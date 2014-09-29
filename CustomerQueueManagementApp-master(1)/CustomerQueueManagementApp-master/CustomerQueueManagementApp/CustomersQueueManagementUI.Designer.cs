namespace CustomerQueueManagementApp
{
    partial class CustomersQueueManagementUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enquComplainTextBox = new System.Windows.Forms.TextBox();
            this.enquNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dequCompTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dequNameTextBox = new System.Windows.Forms.TextBox();
            this.dequSerialTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.queueList = new System.Windows.Forms.ListView();
            this.serialColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complaintsColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.enquComplainTextBox);
            this.groupBox1.Controls.Add(this.enquNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer :";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(68, 119);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Complain :";
            // 
            // enquComplainTextBox
            // 
            this.enquComplainTextBox.Location = new System.Drawing.Point(68, 61);
            this.enquComplainTextBox.Multiline = true;
            this.enquComplainTextBox.Name = "enquComplainTextBox";
            this.enquComplainTextBox.Size = new System.Drawing.Size(348, 52);
            this.enquComplainTextBox.TabIndex = 2;
            // 
            // enquNameTextBox
            // 
            this.enquNameTextBox.Location = new System.Drawing.Point(68, 35);
            this.enquNameTextBox.Name = "enquNameTextBox";
            this.enquNameTextBox.Size = new System.Drawing.Size(348, 20);
            this.enquNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Controls.Add(this.dequCompTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dequNameTextBox);
            this.groupBox2.Controls.Add(this.dequSerialTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(440, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Serial No:";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(68, 119);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 5;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequCompTextBox
            // 
            this.dequCompTextBox.Location = new System.Drawing.Point(68, 79);
            this.dequCompTextBox.Multiline = true;
            this.dequCompTextBox.Name = "dequCompTextBox";
            this.dequCompTextBox.Size = new System.Drawing.Size(348, 34);
            this.dequCompTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Complain :";
            // 
            // dequNameTextBox
            // 
            this.dequNameTextBox.Location = new System.Drawing.Point(68, 53);
            this.dequNameTextBox.Name = "dequNameTextBox";
            this.dequNameTextBox.Size = new System.Drawing.Size(348, 20);
            this.dequNameTextBox.TabIndex = 7;
            // 
            // dequSerialTextBox
            // 
            this.dequSerialTextBox.Location = new System.Drawing.Point(68, 27);
            this.dequSerialTextBox.Name = "dequSerialTextBox";
            this.dequSerialTextBox.ReadOnly = true;
            this.dequSerialTextBox.Size = new System.Drawing.Size(87, 20);
            this.dequSerialTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.queueList);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(850, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue :";
            // 
            // queueList
            // 
            this.queueList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialColumn,
            this.nameColumn,
            this.complaintsColumn});
            this.queueList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queueList.FullRowSelect = true;
            this.queueList.GridLines = true;
            this.queueList.Location = new System.Drawing.Point(3, 16);
            this.queueList.Name = "queueList";
            this.queueList.Size = new System.Drawing.Size(844, 247);
            this.queueList.TabIndex = 0;
            this.queueList.UseCompatibleStateImageBehavior = false;
            this.queueList.View = System.Windows.Forms.View.Details;
            // 
            // serialColumn
            // 
            this.serialColumn.Text = "Serial No";
            this.serialColumn.Width = 83;
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 225;
            // 
            // complaintsColumn
            // 
            this.complaintsColumn.Text = "Complaints";
            this.complaintsColumn.Width = 530;
            // 
            // CustomerQueueManagementUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 457);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomerQueueManagementUI";
            this.Text = "Customer Queue Management ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enquComplainTextBox;
        private System.Windows.Forms.TextBox enquNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequCompTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dequNameTextBox;
        private System.Windows.Forms.TextBox dequSerialTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView queueList;
        private System.Windows.Forms.ColumnHeader serialColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader complaintsColumn;
    }
}

