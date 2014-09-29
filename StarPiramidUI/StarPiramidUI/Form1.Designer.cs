namespace StarPiramidUI
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
            this.levelTextBOx = new System.Windows.Forms.TextBox();
            this.piramidButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Level";
            // 
            // levelTextBOx
            // 
            this.levelTextBOx.Location = new System.Drawing.Point(98, 30);
            this.levelTextBOx.Name = "levelTextBOx";
            this.levelTextBOx.Size = new System.Drawing.Size(100, 20);
            this.levelTextBOx.TabIndex = 1;
            // 
            // piramidButton
            // 
            this.piramidButton.Location = new System.Drawing.Point(224, 28);
            this.piramidButton.Name = "piramidButton";
            this.piramidButton.Size = new System.Drawing.Size(114, 23);
            this.piramidButton.TabIndex = 2;
            this.piramidButton.Text = "Make Piramid";
            this.piramidButton.UseVisualStyleBackColor = true;
            this.piramidButton.Click += new System.EventHandler(this.piramidButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(33, 88);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(286, 199);
            this.listBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 309);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.piramidButton);
            this.Controls.Add(this.levelTextBOx);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox levelTextBOx;
        private System.Windows.Forms.Button piramidButton;
        private System.Windows.Forms.ListBox listBox;
    }
}

