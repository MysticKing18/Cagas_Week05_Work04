namespace Product_Name
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
            this.lblbarcode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lbldescrip = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdlocal = new System.Windows.Forms.RadioButton();
            this.rdabroad = new System.Windows.Forms.RadioButton();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtmarkup = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Location = new System.Drawing.Point(63, 46);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(50, 13);
            this.lblbarcode.TabIndex = 0;
            this.lblbarcode.Text = "Barcode:";
            this.lblbarcode.Click += new System.EventHandler(this.lblbarcode_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(63, 78);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(38, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Name:";
            this.lblname.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbldescrip
            // 
            this.lbldescrip.AutoSize = true;
            this.lbldescrip.Location = new System.Drawing.Point(63, 115);
            this.lbldescrip.Name = "lbldescrip";
            this.lbldescrip.Size = new System.Drawing.Size(63, 13);
            this.lbldescrip.TabIndex = 3;
            this.lbldescrip.Text = "Description:";
            this.lbldescrip.Click += new System.EventHandler(this.lbldescrip_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(61, 193);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(63, 232);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(37, 13);
            this.lblOrigin.TabIndex = 5;
            this.lblOrigin.Text = "Origin:";
            this.lblOrigin.Click += new System.EventHandler(this.lblOrigin_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(63, 314);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(63, 352);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost";
            this.lblCost.Click += new System.EventHandler(this.lblCost_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(202, 352);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(351, 352);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(57, 13);
            this.lblMarkup.TabIndex = 9;
            this.lblMarkup.Text = "Markup(%)";
            this.lblMarkup.Click += new System.EventHandler(this.lblMarkup_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(126, 43);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(344, 20);
            this.txtBarcode.TabIndex = 10;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 20);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(130, 114);
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(337, 57);
            this.txtDescript.TabIndex = 12;
            this.txtDescript.TextChanged += new System.EventHandler(this.txtDescript_TextChanged);
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(126, 190);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(340, 21);
            this.cmbcategory.TabIndex = 13;
            this.cmbcategory.SelectedIndexChanged += new System.EventHandler(this.cmbcategory_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdabroad);
            this.groupBox1.Controls.Add(this.rdlocal);
            this.groupBox1.Location = new System.Drawing.Point(128, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 65);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manufactured";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdlocal
            // 
            this.rdlocal.AutoSize = true;
            this.rdlocal.Location = new System.Drawing.Point(54, 30);
            this.rdlocal.Name = "rdlocal";
            this.rdlocal.Size = new System.Drawing.Size(51, 17);
            this.rdlocal.TabIndex = 0;
            this.rdlocal.TabStop = true;
            this.rdlocal.Text = "Local";
            this.rdlocal.UseVisualStyleBackColor = true;
            // 
            // rdabroad
            // 
            this.rdabroad.AutoSize = true;
            this.rdabroad.Location = new System.Drawing.Point(178, 30);
            this.rdabroad.Name = "rdabroad";
            this.rdabroad.Size = new System.Drawing.Size(59, 17);
            this.rdabroad.TabIndex = 1;
            this.rdabroad.TabStop = true;
            this.rdabroad.Text = "Abroad";
            this.rdabroad.UseVisualStyleBackColor = true;
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(138, 314);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(56, 17);
            this.checkbox.TabIndex = 15;
            this.checkbox.Text = "Active";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(68, 375);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(114, 20);
            this.txtcost.TabIndex = 16;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(205, 375);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(114, 20);
            this.txtprice.TabIndex = 17;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtmarkup
            // 
            this.txtmarkup.Location = new System.Drawing.Point(354, 375);
            this.txtmarkup.Name = "txtmarkup";
            this.txtmarkup.Size = new System.Drawing.Size(114, 20);
            this.txtmarkup.TabIndex = 18;
            this.txtmarkup.TextChanged += new System.EventHandler(this.txtmarkup_TextChanged);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(107, 432);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(205, 432);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(306, 432);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 21;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 501);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtmarkup);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbcategory);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lbldescrip);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblbarcode);
            this.Name = "Form1";
            this.Text = "Product Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lbldescrip;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdabroad;
        private System.Windows.Forms.RadioButton rdlocal;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtmarkup;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
    }
}

