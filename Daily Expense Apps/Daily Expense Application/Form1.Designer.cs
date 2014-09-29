namespace Daily_Expense_Application
{
    partial class DailyExpenseForm
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
            this.daileyEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.txtParticular = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.particularLabel = new System.Windows.Forms.Label();
            this.categoryLabel1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.viewCategoryWiseExpenseGroupBox = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.showListView = new System.Windows.Forms.ListView();
            this.amountColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.particularColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryComboBox2 = new System.Windows.Forms.ComboBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.categoryLabel2 = new System.Windows.Forms.Label();
            this.viewSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.viewSummaryShowButton = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.maximumExpenseTextBox = new System.Windows.Forms.TextBox();
            this.maximumExpenseLabel = new System.Windows.Forms.Label();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.daileyEntryGroupBox.SuspendLayout();
            this.viewCategoryWiseExpenseGroupBox.SuspendLayout();
            this.viewSummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // daileyEntryGroupBox
            // 
            this.daileyEntryGroupBox.Controls.Add(this.txtParticular);
            this.daileyEntryGroupBox.Controls.Add(this.saveButton);
            this.daileyEntryGroupBox.Controls.Add(this.categoryComboBox);
            this.daileyEntryGroupBox.Controls.Add(this.txtAmount);
            this.daileyEntryGroupBox.Controls.Add(this.particularLabel);
            this.daileyEntryGroupBox.Controls.Add(this.categoryLabel1);
            this.daileyEntryGroupBox.Controls.Add(this.amountLabel);
            this.daileyEntryGroupBox.Location = new System.Drawing.Point(12, 12);
            this.daileyEntryGroupBox.Name = "daileyEntryGroupBox";
            this.daileyEntryGroupBox.Size = new System.Drawing.Size(306, 188);
            this.daileyEntryGroupBox.TabIndex = 0;
            this.daileyEntryGroupBox.TabStop = false;
            this.daileyEntryGroupBox.Text = "Daily Expense Entry";
            // 
            // txtParticular
            // 
            this.txtParticular.Location = new System.Drawing.Point(82, 96);
            this.txtParticular.Multiline = true;
            this.txtParticular.Name = "txtParticular";
            this.txtParticular.Size = new System.Drawing.Size(218, 42);
            this.txtParticular.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(127, 144);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBox.Location = new System.Drawing.Point(83, 62);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(217, 21);
            this.categoryComboBox.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(83, 29);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // particularLabel
            // 
            this.particularLabel.AutoSize = true;
            this.particularLabel.Location = new System.Drawing.Point(25, 99);
            this.particularLabel.Name = "particularLabel";
            this.particularLabel.Size = new System.Drawing.Size(51, 13);
            this.particularLabel.TabIndex = 2;
            this.particularLabel.Text = "Particular";
            // 
            // categoryLabel1
            // 
            this.categoryLabel1.AutoSize = true;
            this.categoryLabel1.Location = new System.Drawing.Point(28, 62);
            this.categoryLabel1.Name = "categoryLabel1";
            this.categoryLabel1.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel1.TabIndex = 1;
            this.categoryLabel1.Text = "Category";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(34, 29);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            // 
            // viewCategoryWiseExpenseGroupBox
            // 
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.showButton);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.totalTextBox);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.showListView);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.categoryComboBox2);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.totalLabel);
            this.viewCategoryWiseExpenseGroupBox.Controls.Add(this.categoryLabel2);
            this.viewCategoryWiseExpenseGroupBox.Location = new System.Drawing.Point(334, 12);
            this.viewCategoryWiseExpenseGroupBox.Name = "viewCategoryWiseExpenseGroupBox";
            this.viewCategoryWiseExpenseGroupBox.Size = new System.Drawing.Size(312, 328);
            this.viewCategoryWiseExpenseGroupBox.TabIndex = 1;
            this.viewCategoryWiseExpenseGroupBox.TabStop = false;
            this.viewCategoryWiseExpenseGroupBox.Text = "View Categorywise Expense";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(145, 72);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 25);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(78, 294);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(124, 20);
            this.totalTextBox.TabIndex = 7;
            // 
            // showListView
            // 
            this.showListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.amountColumnHeader,
            this.particularColumnHeader});
            this.showListView.GridLines = true;
            this.showListView.Location = new System.Drawing.Point(78, 123);
            this.showListView.Name = "showListView";
            this.showListView.Size = new System.Drawing.Size(214, 155);
            this.showListView.TabIndex = 7;
            this.showListView.UseCompatibleStateImageBehavior = false;
            this.showListView.View = System.Windows.Forms.View.Details;
            // 
            // amountColumnHeader
            // 
            this.amountColumnHeader.Text = "Amount";
            // 
            // particularColumnHeader
            // 
            this.particularColumnHeader.Text = "Particular";
            this.particularColumnHeader.Width = 113;
            // 
            // categoryComboBox2
            // 
            this.categoryComboBox2.FormattingEnabled = true;
            this.categoryComboBox2.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBox2.Location = new System.Drawing.Point(78, 45);
            this.categoryComboBox2.Name = "categoryComboBox2";
            this.categoryComboBox2.Size = new System.Drawing.Size(214, 21);
            this.categoryComboBox2.TabIndex = 6;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(18, 297);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // categoryLabel2
            // 
            this.categoryLabel2.AutoSize = true;
            this.categoryLabel2.Location = new System.Drawing.Point(18, 48);
            this.categoryLabel2.Name = "categoryLabel2";
            this.categoryLabel2.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel2.TabIndex = 5;
            this.categoryLabel2.Text = "Category";
            // 
            // viewSummaryGroupBox
            // 
            this.viewSummaryGroupBox.Controls.Add(this.viewSummaryShowButton);
            this.viewSummaryGroupBox.Controls.Add(this.txtTotal);
            this.viewSummaryGroupBox.Controls.Add(this.maximumExpenseTextBox);
            this.viewSummaryGroupBox.Controls.Add(this.maximumExpenseLabel);
            this.viewSummaryGroupBox.Controls.Add(this.totalExpenseLabel);
            this.viewSummaryGroupBox.Location = new System.Drawing.Point(12, 206);
            this.viewSummaryGroupBox.Name = "viewSummaryGroupBox";
            this.viewSummaryGroupBox.Size = new System.Drawing.Size(306, 134);
            this.viewSummaryGroupBox.TabIndex = 1;
            this.viewSummaryGroupBox.TabStop = false;
            this.viewSummaryGroupBox.Text = "View Summary";
            // 
            // viewSummaryShowButton
            // 
            this.viewSummaryShowButton.Location = new System.Drawing.Point(94, 100);
            this.viewSummaryShowButton.Name = "viewSummaryShowButton";
            this.viewSummaryShowButton.Size = new System.Drawing.Size(75, 23);
            this.viewSummaryShowButton.TabIndex = 9;
            this.viewSummaryShowButton.Text = "Show";
            this.viewSummaryShowButton.UseVisualStyleBackColor = true;
            this.viewSummaryShowButton.Click += new System.EventHandler(this.viewSummaryShowButton_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(94, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(193, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // maximumExpenseTextBox
            // 
            this.maximumExpenseTextBox.Location = new System.Drawing.Point(94, 64);
            this.maximumExpenseTextBox.Name = "maximumExpenseTextBox";
            this.maximumExpenseTextBox.Size = new System.Drawing.Size(193, 20);
            this.maximumExpenseTextBox.TabIndex = 6;
            // 
            // maximumExpenseLabel
            // 
            this.maximumExpenseLabel.AutoSize = true;
            this.maximumExpenseLabel.Location = new System.Drawing.Point(-3, 64);
            this.maximumExpenseLabel.Name = "maximumExpenseLabel";
            this.maximumExpenseLabel.Size = new System.Drawing.Size(98, 13);
            this.maximumExpenseLabel.TabIndex = 4;
            this.maximumExpenseLabel.Text = "Maximum Expense:";
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Location = new System.Drawing.Point(10, 22);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(78, 13);
            this.totalExpenseLabel.TabIndex = 3;
            this.totalExpenseLabel.Text = "Total Expense:";
            // 
            // DailyExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 352);
            this.Controls.Add(this.viewSummaryGroupBox);
            this.Controls.Add(this.viewCategoryWiseExpenseGroupBox);
            this.Controls.Add(this.daileyEntryGroupBox);
            this.Name = "DailyExpenseForm";
            this.Text = "Daily Expense";
            this.Load += new System.EventHandler(this.DailyExpenseForm_Load);
            this.daileyEntryGroupBox.ResumeLayout(false);
            this.daileyEntryGroupBox.PerformLayout();
            this.viewCategoryWiseExpenseGroupBox.ResumeLayout(false);
            this.viewCategoryWiseExpenseGroupBox.PerformLayout();
            this.viewSummaryGroupBox.ResumeLayout(false);
            this.viewSummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox daileyEntryGroupBox;
        private System.Windows.Forms.GroupBox viewCategoryWiseExpenseGroupBox;
        private System.Windows.Forms.GroupBox viewSummaryGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label particularLabel;
        private System.Windows.Forms.Label categoryLabel1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ListView showListView;
        private System.Windows.Forms.ComboBox categoryComboBox2;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label categoryLabel2;
        private System.Windows.Forms.Button viewSummaryShowButton;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox maximumExpenseTextBox;
        private System.Windows.Forms.Label maximumExpenseLabel;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.TextBox txtParticular;
        private System.Windows.Forms.ColumnHeader amountColumnHeader;
        private System.Windows.Forms.ColumnHeader particularColumnHeader;
    }
}

