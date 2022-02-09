namespace chap1
{
    partial class Exercise1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.cboProvince = new System.Windows.Forms.ComboBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(215, 68);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(321, 31);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.label1.Location = new System.Drawing.Point(107, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.label2.Location = new System.Drawing.Point(110, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "LastName";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.txtLastName.Location = new System.Drawing.Point(215, 121);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(321, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.label3.Location = new System.Drawing.Point(116, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Province";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.label4.Location = new System.Drawing.Point(126, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.optFemale.Location = new System.Drawing.Point(212, 164);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(54, 31);
            this.optFemale.TabIndex = 7;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "ຍິງ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.optMale.Location = new System.Drawing.Point(291, 164);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(64, 31);
            this.optMale.TabIndex = 8;
            this.optMale.TabStop = true;
            this.optMale.Text = "ຊາຍ";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // cboProvince
            // 
            this.cboProvince.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.cboProvince.FormattingEnabled = true;
            this.cboProvince.Items.AddRange(new object[] {
            "ຜົ້ງສາລີ",
            "ບໍ່ແກ້ວ",
            "ຫຼວງນໍ້າທາ",
            "ອຸດົມໄຊ",
            "ຫົວພັນ",
            "ຊຽງຂວາງ",
            "ໄຊຍະບຸລີ",
            "ຫຼວງພະບາງ",
            "ວຽງຈັນ",
            "ນະຄອນຫຼວງວຽງຈັນ",
            "ບໍລິຄໍາໄຊ",
            "ຄໍາມ່ວນ",
            "ໄຊສົມບູນ",
            "ສະຫວັນນະເຂດ",
            "ສາລະວັນ",
            "ເຊກອງ",
            "ຈໍາປາສັກ",
            "ອັດຕະປື"});
            this.cboProvince.Location = new System.Drawing.Point(212, 207);
            this.cboProvince.Name = "cboProvince";
            this.cboProvince.Size = new System.Drawing.Size(321, 35);
            this.cboProvince.TabIndex = 9;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.FlatAppearance.BorderSize = 0;
            this.cmdSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSubmit.Font = new System.Drawing.Font("Noto Serif ExtCond", 12F);
            this.cmdSubmit.Location = new System.Drawing.Point(212, 263);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(111, 44);
            this.cmdSubmit.TabIndex = 10;
            this.cmdSubmit.Text = "Submit";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.cmdSubmit_Click);
            this.cmdSubmit.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // Exercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 363);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.cboProvince);
            this.Controls.Add(this.optMale);
            this.Controls.Add(this.optFemale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Exercise1";
            this.Text = "Exercise1";
            this.Load += new System.EventHandler(this.Exercise1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.ComboBox cboProvince;
        private System.Windows.Forms.Button cmdSubmit;
    }
}