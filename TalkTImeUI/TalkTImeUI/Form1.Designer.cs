namespace TalkTImeUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.balancrTextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.posPreComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.operatorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // balancrTextBox
            // 
            this.balancrTextBox.Location = new System.Drawing.Point(109, 45);
            this.balancrTextBox.Name = "balancrTextBox";
            this.balancrTextBox.Size = new System.Drawing.Size(121, 20);
            this.balancrTextBox.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(106, 230);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(9, 13);
            this.label.TabIndex = 2;
            this.label.Text = "l";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(67, 164);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(186, 38);
            this.button.TabIndex = 3;
            this.button.Text = "Calculate Talk Time";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Option";
            // 
            // posPreComboBox
            // 
            this.posPreComboBox.FormattingEnabled = true;
            this.posPreComboBox.Items.AddRange(new object[] {
            "Post Paid",
            "Prepaid"});
            this.posPreComboBox.Location = new System.Drawing.Point(109, 84);
            this.posPreComboBox.Name = "posPreComboBox";
            this.posPreComboBox.Size = new System.Drawing.Size(121, 21);
            this.posPreComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operator";
            // 
            // operatorComboBox
            // 
            this.operatorComboBox.FormattingEnabled = true;
            this.operatorComboBox.Items.AddRange(new object[] {
            "Grameen",
            "Airtel",
            "Robi",
            "Banglalink"});
            this.operatorComboBox.Location = new System.Drawing.Point(109, 122);
            this.operatorComboBox.Name = "operatorComboBox";
            this.operatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.operatorComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Talktime :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 305);
            this.Controls.Add(this.operatorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.posPreComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.balancrTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Talk Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox balancrTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox posPreComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox operatorComboBox;
        private System.Windows.Forms.Label label4;
    }
}

