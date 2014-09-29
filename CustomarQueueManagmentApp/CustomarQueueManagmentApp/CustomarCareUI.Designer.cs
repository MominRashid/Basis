namespace CustomarQueueManagmentApp
{
    partial class CustomarCareUI
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
            this.Namelabel = new System.Windows.Forms.Label();
            this.Enqueuebutton = new System.Windows.Forms.Button();
            this.ComplaintextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.Complainlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dequeuebutton = new System.Windows.Forms.Button();
            this.ComplainDequeuetextBox = new System.Windows.Forms.TextBox();
            this.NameDequeuetextBox = new System.Windows.Forms.TextBox();
            this.SerialtextBox = new System.Windows.Forms.TextBox();
            this.ComplainDequeuelabel = new System.Windows.Forms.Label();
            this.NameDequeuelabel = new System.Windows.Forms.Label();
            this.Seriallabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Serialcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namecolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Complaincolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Namelabel);
            this.groupBox1.Controls.Add(this.Enqueuebutton);
            this.groupBox1.Controls.Add(this.ComplaintextBox);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.Complainlabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customar";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(18, 34);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(35, 13);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name";
            // 
            // Enqueuebutton
            // 
            this.Enqueuebutton.Location = new System.Drawing.Point(166, 182);
            this.Enqueuebutton.Name = "Enqueuebutton";
            this.Enqueuebutton.Size = new System.Drawing.Size(75, 23);
            this.Enqueuebutton.TabIndex = 4;
            this.Enqueuebutton.Text = "Enqueue";
            this.Enqueuebutton.UseVisualStyleBackColor = true;
            this.Enqueuebutton.Click += new System.EventHandler(this.Enqueuebutton_Click);
            // 
            // ComplaintextBox
            // 
            this.ComplaintextBox.Location = new System.Drawing.Point(121, 121);
            this.ComplaintextBox.Multiline = true;
            this.ComplaintextBox.Name = "ComplaintextBox";
            this.ComplaintextBox.Size = new System.Drawing.Size(208, 20);
            this.ComplaintextBox.TabIndex = 3;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(121, 19);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(120, 20);
            this.NametextBox.TabIndex = 2;
            // 
            // Complainlabel
            // 
            this.Complainlabel.AutoSize = true;
            this.Complainlabel.Location = new System.Drawing.Point(18, 128);
            this.Complainlabel.Name = "Complainlabel";
            this.Complainlabel.Size = new System.Drawing.Size(50, 13);
            this.Complainlabel.TabIndex = 1;
            this.Complainlabel.Text = "Complain";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dequeuebutton);
            this.groupBox2.Controls.Add(this.ComplainDequeuetextBox);
            this.groupBox2.Controls.Add(this.NameDequeuetextBox);
            this.groupBox2.Controls.Add(this.SerialtextBox);
            this.groupBox2.Controls.Add(this.ComplainDequeuelabel);
            this.groupBox2.Controls.Add(this.NameDequeuelabel);
            this.groupBox2.Controls.Add(this.Seriallabel);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customar";
            // 
            // Dequeuebutton
            // 
            this.Dequeuebutton.Location = new System.Drawing.Point(133, 191);
            this.Dequeuebutton.Name = "Dequeuebutton";
            this.Dequeuebutton.Size = new System.Drawing.Size(94, 23);
            this.Dequeuebutton.TabIndex = 6;
            this.Dequeuebutton.Text = "Dequeue";
            this.Dequeuebutton.UseVisualStyleBackColor = true;
            this.Dequeuebutton.Click += new System.EventHandler(this.Dequeuebutton_Click);
            // 
            // ComplainDequeuetextBox
            // 
            this.ComplainDequeuetextBox.Location = new System.Drawing.Point(133, 128);
            this.ComplainDequeuetextBox.Multiline = true;
            this.ComplainDequeuetextBox.Name = "ComplainDequeuetextBox";
            this.ComplainDequeuetextBox.Size = new System.Drawing.Size(204, 20);
            this.ComplainDequeuetextBox.TabIndex = 5;
            // 
            // NameDequeuetextBox
            // 
            this.NameDequeuetextBox.Location = new System.Drawing.Point(151, 84);
            this.NameDequeuetextBox.Name = "NameDequeuetextBox";
            this.NameDequeuetextBox.Size = new System.Drawing.Size(114, 20);
            this.NameDequeuetextBox.TabIndex = 4;
            // 
            // SerialtextBox
            // 
            this.SerialtextBox.Location = new System.Drawing.Point(151, 31);
            this.SerialtextBox.Name = "SerialtextBox";
            this.SerialtextBox.Size = new System.Drawing.Size(100, 20);
            this.SerialtextBox.TabIndex = 3;
            // 
            // ComplainDequeuelabel
            // 
            this.ComplainDequeuelabel.AutoSize = true;
            this.ComplainDequeuelabel.Location = new System.Drawing.Point(18, 128);
            this.ComplainDequeuelabel.Name = "ComplainDequeuelabel";
            this.ComplainDequeuelabel.Size = new System.Drawing.Size(50, 13);
            this.ComplainDequeuelabel.TabIndex = 2;
            this.ComplainDequeuelabel.Text = "Complain";
            // 
            // NameDequeuelabel
            // 
            this.NameDequeuelabel.AutoSize = true;
            this.NameDequeuelabel.Location = new System.Drawing.Point(18, 84);
            this.NameDequeuelabel.Name = "NameDequeuelabel";
            this.NameDequeuelabel.Size = new System.Drawing.Size(35, 13);
            this.NameDequeuelabel.TabIndex = 1;
            this.NameDequeuelabel.Text = "Name";
            // 
            // Seriallabel
            // 
            this.Seriallabel.AutoSize = true;
            this.Seriallabel.Location = new System.Drawing.Point(18, 38);
            this.Seriallabel.Name = "Seriallabel";
            this.Seriallabel.Size = new System.Drawing.Size(50, 13);
            this.Seriallabel.TabIndex = 0;
            this.Seriallabel.Text = "Serial No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Queue";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Serialcolumn,
            this.Namecolumn,
            this.Complaincolumn});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(678, 172);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Serialcolumn
            // 
            this.Serialcolumn.Text = "Serial No";
            // 
            // Namecolumn
            // 
            this.Namecolumn.Text = "Name";
            // 
            // Complaincolumn
            // 
            this.Complaincolumn.Text = "Complain";
            // 
            // CustomarCareUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 448);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CustomarCareUI";
            this.Text = "Customar Care";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Enqueuebutton;
        private System.Windows.Forms.TextBox ComplaintextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label Complainlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Dequeuebutton;
        private System.Windows.Forms.TextBox ComplainDequeuetextBox;
        private System.Windows.Forms.TextBox NameDequeuetextBox;
        private System.Windows.Forms.TextBox SerialtextBox;
        private System.Windows.Forms.Label ComplainDequeuelabel;
        private System.Windows.Forms.Label NameDequeuelabel;
        private System.Windows.Forms.Label Seriallabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Serialcolumn;
        private System.Windows.Forms.ColumnHeader Namecolumn;
        private System.Windows.Forms.ColumnHeader Complaincolumn;
    }
}

