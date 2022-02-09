namespace chap1
{
    partial class Exercise3
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
            this.btsavedata = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtjob = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvData = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsavedata
            // 
            this.btsavedata.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsavedata.Location = new System.Drawing.Point(8, 262);
            this.btsavedata.Margin = new System.Windows.Forms.Padding(4);
            this.btsavedata.Name = "btsavedata";
            this.btsavedata.Size = new System.Drawing.Size(189, 46);
            this.btsavedata.TabIndex = 9;
            this.btsavedata.Text = "ບັນທຶກຂໍ້ມູນລົງໄຟລ";
            this.btsavedata.UseVisualStyleBackColor = true;
            this.btsavedata.Click += new System.EventHandler(this.btsavedata_Click);
            this.btsavedata.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(8, 95);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(189, 46);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "ລຶບລາຍການ";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            this.btndelete.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(8, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(189, 46);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ເພີ່ມລາຍການ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // txtjob
            // 
            this.txtjob.Font = new System.Drawing.Font("Noto Serif SemCond", 12F);
            this.txtjob.Location = new System.Drawing.Point(513, 87);
            this.txtjob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtjob.Multiline = true;
            this.txtjob.Name = "txtjob";
            this.txtjob.Size = new System.Drawing.Size(381, 32);
            this.txtjob.TabIndex = 7;
            // 
            // txtfullname
            // 
            this.txtfullname.Font = new System.Drawing.Font("Noto Serif SemCond", 12F);
            this.txtfullname.Location = new System.Drawing.Point(63, 87);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfullname.Multiline = true;
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(381, 32);
            this.txtfullname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "ອາຊີບ";
            // 
            // lsvData
            // 
            this.lsvData.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvData.GridLines = true;
            this.lsvData.Location = new System.Drawing.Point(63, 156);
            this.lsvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvData.Name = "lsvData";
            this.lsvData.Size = new System.Drawing.Size(597, 330);
            this.lsvData.TabIndex = 6;
            this.lsvData.UseCompatibleStateImageBehavior = false;
            this.lsvData.View = System.Windows.Forms.View.Details;
            this.lsvData.SelectedIndexChanged += new System.EventHandler(this.lsvData_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "ຊື່ ແລະ ນາມສະກຸນ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btsavedata);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(699, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(205, 331);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // Exercise3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtjob);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvData);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exercise3";
            this.Text = "testdata";
            this.Load += new System.EventHandler(this.testdata_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btsavedata;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtjob;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}