namespace chap1
{
    partial class Form2
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
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtRaduis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalculat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(264, 138);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(296, 36);
            this.txtArea.TabIndex = 6;
            // 
            // txtRaduis
            // 
            this.txtRaduis.Location = new System.Drawing.Point(264, 89);
            this.txtRaduis.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaduis.Multiline = true;
            this.txtRaduis.Name = "txtRaduis";
            this.txtRaduis.Size = new System.Drawing.Size(296, 36);
            this.txtRaduis.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ສະເເດງເນື້ອທີ່";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "ລັດສະໝີ";
            // 
            // btncalculat
            // 
            this.btncalculat.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculat.Location = new System.Drawing.Point(264, 182);
            this.btncalculat.Margin = new System.Windows.Forms.Padding(4);
            this.btncalculat.Name = "btncalculat";
            this.btncalculat.Size = new System.Drawing.Size(181, 53);
            this.btncalculat.TabIndex = 8;
            this.btncalculat.Text = "ຄໍານວນເນື້ອທີ່";
            this.btncalculat.UseVisualStyleBackColor = true;
            this.btncalculat.Click += new System.EventHandler(this.button1_Click);
            this.btncalculat.Paint += new System.Windows.Forms.PaintEventHandler(this.btncalculat_Paint);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 327);
            this.Controls.Add(this.btncalculat);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRaduis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtRaduis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalculat;
    }
}