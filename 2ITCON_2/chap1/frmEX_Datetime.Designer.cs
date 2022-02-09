namespace chap1
{
    partial class frmEX_Datetime
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
            this.optInvaraint = new System.Windows.Forms.RadioButton();
            this.optCurrentInfo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStyle = new System.Windows.Forms.ComboBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.optInvaraint);
            this.groupBox1.Controls.Add(this.optCurrentInfo);
            this.groupBox1.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(508, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ກໍານົດລັກສະນະ";
            // 
            // optInvaraint
            // 
            this.optInvaraint.AutoSize = true;
            this.optInvaraint.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInvaraint.Location = new System.Drawing.Point(80, 107);
            this.optInvaraint.Margin = new System.Windows.Forms.Padding(4);
            this.optInvaraint.Name = "optInvaraint";
            this.optInvaraint.Size = new System.Drawing.Size(421, 37);
            this.optInvaraint.TabIndex = 0;
            this.optInvaraint.TabStop = true;
            this.optInvaraint.Text = "ແບບ DataTimeFormat.InvaraintInfo";
            this.optInvaraint.UseVisualStyleBackColor = true;
            // 
            // optCurrentInfo
            // 
            this.optCurrentInfo.AutoSize = true;
            this.optCurrentInfo.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCurrentInfo.Location = new System.Drawing.Point(80, 66);
            this.optCurrentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.optCurrentInfo.Name = "optCurrentInfo";
            this.optCurrentInfo.Size = new System.Drawing.Size(404, 37);
            this.optCurrentInfo.TabIndex = 0;
            this.optCurrentInfo.TabStop = true;
            this.optCurrentInfo.Text = "ແບບ DataTimeFormat.currentInfo";
            this.optCurrentInfo.UseVisualStyleBackColor = true;
            this.optCurrentInfo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຜົນໄດ້ຮັບ:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplay.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(608, 137);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(185, 34);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "ກໍານົດຮູບເເບບ";
            // 
            // cboStyle
            // 
            this.cboStyle.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStyle.FormattingEnabled = true;
            this.cboStyle.Location = new System.Drawing.Point(164, 254);
            this.cboStyle.Margin = new System.Windows.Forms.Padding(4);
            this.cboStyle.Name = "cboStyle";
            this.cboStyle.Size = new System.Drawing.Size(389, 41);
            this.cboStyle.TabIndex = 2;
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.White;
            this.btnFormat.Font = new System.Drawing.Font("Noto Serif Lao SemCond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.Location = new System.Drawing.Point(608, 252);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(123, 38);
            this.btnFormat.TabIndex = 3;
            this.btnFormat.Text = "ຈັດຮູບເເບບ";
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            this.btnFormat.Paint += new System.Windows.Forms.PaintEventHandler(this.btnFormat_Paint);
            // 
            // frmEX_Datetime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 391);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.cboStyle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEX_Datetime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEX_Datetime";
            this.Load += new System.EventHandler(this.frmEX_Datetime_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optInvaraint;
        private System.Windows.Forms.RadioButton optCurrentInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboStyle;
        private System.Windows.Forms.Button btnFormat;
    }
}