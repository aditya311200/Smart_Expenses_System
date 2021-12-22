namespace StudentChallenge_051_076
{
    partial class FormInputExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputExpenses));
            this.labelCurrency = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.textBoxExpenses = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.comboBoxExpensesType = new System.Windows.Forms.ComboBox();
            this.labelColon4 = new System.Windows.Forms.Label();
            this.labelColon3 = new System.Windows.Forms.Label();
            this.labelColon2 = new System.Windows.Forms.Label();
            this.labelColon1 = new System.Windows.Forms.Label();
            this.labelGaris = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelExpenses = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelBackground = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrency.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrency.ForeColor = System.Drawing.Color.White;
            this.labelCurrency.Location = new System.Drawing.Point(417, 409);
            this.labelCurrency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(31, 19);
            this.labelCurrency.TabIndex = 13;
            this.labelCurrency.Text = "Rp";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(898, 470);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(95, 27);
            this.buttonClose.TabIndex = 19;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.Location = new System.Drawing.Point(686, 470);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(95, 27);
            this.buttonConfirm.TabIndex = 18;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.HorizontalScrollbar = true;
            this.listBoxInfo.ItemHeight = 17;
            this.listBoxInfo.Location = new System.Drawing.Point(686, 255);
            this.listBoxInfo.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(309, 174);
            this.listBoxInfo.TabIndex = 17;
            // 
            // textBoxExpenses
            // 
            this.textBoxExpenses.Location = new System.Drawing.Point(421, 306);
            this.textBoxExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxExpenses.Name = "textBoxExpenses";
            this.textBoxExpenses.Size = new System.Drawing.Size(171, 20);
            this.textBoxExpenses.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(452, 408);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(140, 20);
            this.textBoxPrice.TabIndex = 14;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(497, 470);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(95, 27);
            this.buttonCheck.TabIndex = 15;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // comboBoxExpensesType
            // 
            this.comboBoxExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpensesType.FormattingEnabled = true;
            this.comboBoxExpensesType.Items.AddRange(new object[] {
            "Education",
            "Food",
            "Others"});
            this.comboBoxExpensesType.Location = new System.Drawing.Point(421, 360);
            this.comboBoxExpensesType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxExpensesType.Name = "comboBoxExpensesType";
            this.comboBoxExpensesType.Size = new System.Drawing.Size(171, 21);
            this.comboBoxExpensesType.TabIndex = 10;
            // 
            // labelColon4
            // 
            this.labelColon4.AutoSize = true;
            this.labelColon4.BackColor = System.Drawing.Color.Transparent;
            this.labelColon4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon4.ForeColor = System.Drawing.Color.White;
            this.labelColon4.Location = new System.Drawing.Point(372, 409);
            this.labelColon4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColon4.Name = "labelColon4";
            this.labelColon4.Size = new System.Drawing.Size(15, 19);
            this.labelColon4.TabIndex = 12;
            this.labelColon4.Text = ":";
            // 
            // labelColon3
            // 
            this.labelColon3.AutoSize = true;
            this.labelColon3.BackColor = System.Drawing.Color.Transparent;
            this.labelColon3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon3.ForeColor = System.Drawing.Color.White;
            this.labelColon3.Location = new System.Drawing.Point(372, 360);
            this.labelColon3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColon3.Name = "labelColon3";
            this.labelColon3.Size = new System.Drawing.Size(15, 19);
            this.labelColon3.TabIndex = 9;
            this.labelColon3.Text = ":";
            // 
            // labelColon2
            // 
            this.labelColon2.AutoSize = true;
            this.labelColon2.BackColor = System.Drawing.Color.Transparent;
            this.labelColon2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon2.ForeColor = System.Drawing.Color.White;
            this.labelColon2.Location = new System.Drawing.Point(372, 307);
            this.labelColon2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColon2.Name = "labelColon2";
            this.labelColon2.Size = new System.Drawing.Size(15, 19);
            this.labelColon2.TabIndex = 6;
            this.labelColon2.Text = ":";
            // 
            // labelColon1
            // 
            this.labelColon1.AutoSize = true;
            this.labelColon1.BackColor = System.Drawing.Color.Transparent;
            this.labelColon1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColon1.ForeColor = System.Drawing.Color.White;
            this.labelColon1.Location = new System.Drawing.Point(372, 255);
            this.labelColon1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelColon1.Name = "labelColon1";
            this.labelColon1.Size = new System.Drawing.Size(15, 19);
            this.labelColon1.TabIndex = 3;
            this.labelColon1.Text = ":";
            // 
            // labelGaris
            // 
            this.labelGaris.BackColor = System.Drawing.Color.White;
            this.labelGaris.Location = new System.Drawing.Point(633, 213);
            this.labelGaris.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGaris.Name = "labelGaris";
            this.labelGaris.Size = new System.Drawing.Size(8, 319);
            this.labelGaris.TabIndex = 16;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(252, 409);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 19);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Price";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.ForeColor = System.Drawing.Color.White;
            this.labelType.Location = new System.Drawing.Point(252, 360);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(49, 19);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Type";
            // 
            // labelExpenses
            // 
            this.labelExpenses.AutoSize = true;
            this.labelExpenses.BackColor = System.Drawing.Color.Transparent;
            this.labelExpenses.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenses.ForeColor = System.Drawing.Color.White;
            this.labelExpenses.Location = new System.Drawing.Point(252, 307);
            this.labelExpenses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpenses.Name = "labelExpenses";
            this.labelExpenses.Size = new System.Drawing.Size(83, 19);
            this.labelExpenses.TabIndex = 5;
            this.labelExpenses.Text = "Expenses";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(252, 255);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 19);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date";
            // 
            // labelBackground
            // 
            this.labelBackground.BackColor = System.Drawing.Color.Black;
            this.labelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBackground.Location = new System.Drawing.Point(229, 173);
            this.labelBackground.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(807, 398);
            this.labelBackground.TabIndex = 1;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(421, 255);
            this.dateTimePickerDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerDate.TabIndex = 4;
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(12, 57);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(1252, 46);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Tell us About Your Expenses!";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInputExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.textBoxExpenses);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.comboBoxExpensesType);
            this.Controls.Add(this.labelColon4);
            this.Controls.Add(this.labelColon3);
            this.Controls.Add(this.labelColon2);
            this.Controls.Add(this.labelColon1);
            this.Controls.Add(this.labelGaris);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelExpenses);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelBackground);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInputExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Your Expenses";
            this.Load += new System.EventHandler(this.FormInputExpenses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.TextBox textBoxExpenses;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ComboBox comboBoxExpensesType;
        private System.Windows.Forms.Label labelColon4;
        private System.Windows.Forms.Label labelColon3;
        private System.Windows.Forms.Label labelColon2;
        private System.Windows.Forms.Label labelColon1;
        private System.Windows.Forms.Label labelGaris;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelExpenses;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelHeader;
    }
}