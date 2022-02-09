namespace chap1
{
    partial class frmEX_listview
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
            this.lsvData = new System.Windows.Forms.ListView();
            this.txtfrisname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຊື່";
            // 
            // lsvData
            // 
            this.lsvData.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvData.GridLines = true;
            this.lsvData.Location = new System.Drawing.Point(16, 218);
            this.lsvData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvData.Name = "lsvData";
            this.lsvData.Size = new System.Drawing.Size(704, 208);
            this.lsvData.TabIndex = 1;
            this.lsvData.UseCompatibleStateImageBehavior = false;
            this.lsvData.View = System.Windows.Forms.View.Details;
            // 
            // txtfrisname
            // 
            this.txtfrisname.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfrisname.Location = new System.Drawing.Point(33, 63);
            this.txtfrisname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfrisname.Multiline = true;
            this.txtfrisname.Name = "txtfrisname";
            this.txtfrisname.Size = new System.Drawing.Size(297, 32);
            this.txtfrisname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "ນາມສະກຸນ";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(33, 144);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlastname.Multiline = true;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(297, 32);
            this.txtlastname.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(557, 38);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 46);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ເພີ່ມລາຍການ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(557, 91);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(164, 46);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "ລຶບລາຍການ";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            this.btndelete.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(557, 144);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(164, 46);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "ລ້າງລາຍການ";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            this.btnclear.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_Paint);
            // 
            // frmEX_listview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 442);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfrisname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvData);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEX_listview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEX_listview";
            this.Load += new System.EventHandler(this.frmEX_listview_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEX_listview_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsvData;
        private System.Windows.Forms.TextBox txtfrisname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
    }
}