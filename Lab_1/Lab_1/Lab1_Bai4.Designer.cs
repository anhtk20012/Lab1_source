namespace Lab_1
{
    partial class Lab1_Bai4
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
            this.tb_tien = new System.Windows.Forms.TextBox();
            this.cbb_dvtt = new System.Windows.Forms.ComboBox();
            this.btn_cd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_stcd = new System.Windows.Forms.TextBox();
            this.l_quydoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền cần chuyển đổi";
            // 
            // tb_tien
            // 
            this.tb_tien.Location = new System.Drawing.Point(12, 53);
            this.tb_tien.Multiline = true;
            this.tb_tien.Name = "tb_tien";
            this.tb_tien.Size = new System.Drawing.Size(349, 33);
            this.tb_tien.TabIndex = 2;
            // 
            // cbb_dvtt
            // 
            this.cbb_dvtt.FormattingEnabled = true;
            this.cbb_dvtt.Items.AddRange(new object[] {
            "Wave Alpha",
            "Sirius",
            "Vision",
            "Lead",
            "Winner",
            "AirBlade",
            "Xe tải 9 tấn"});
            this.cbb_dvtt.Location = new System.Drawing.Point(367, 53);
            this.cbb_dvtt.Name = "cbb_dvtt";
            this.cbb_dvtt.Size = new System.Drawing.Size(137, 33);
            this.cbb_dvtt.TabIndex = 3;
            // 
            // btn_cd
            // 
            this.btn_cd.Location = new System.Drawing.Point(12, 102);
            this.btn_cd.Name = "btn_cd";
            this.btn_cd.Size = new System.Drawing.Size(492, 44);
            this.btn_cd.TabIndex = 4;
            this.btn_cd.Text = "Chuyển đổi";
            this.btn_cd.UseVisualStyleBackColor = true;
            this.btn_cd.Click += new System.EventHandler(this.btn_cd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số tiền cần đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tỷ giá quy đổi:";
            // 
            // tb_stcd
            // 
            this.tb_stcd.Location = new System.Drawing.Point(154, 180);
            this.tb_stcd.Multiline = true;
            this.tb_stcd.Name = "tb_stcd";
            this.tb_stcd.Size = new System.Drawing.Size(350, 30);
            this.tb_stcd.TabIndex = 6;
            // 
            // l_quydoi
            // 
            this.l_quydoi.AutoSize = true;
            this.l_quydoi.Location = new System.Drawing.Point(149, 237);
            this.l_quydoi.Name = "l_quydoi";
            this.l_quydoi.Size = new System.Drawing.Size(0, 25);
            this.l_quydoi.TabIndex = 5;
            // 
            // Lab1_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 294);
            this.Controls.Add(this.tb_stcd);
            this.Controls.Add(this.l_quydoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cd);
            this.Controls.Add(this.cbb_dvtt);
            this.Controls.Add(this.tb_tien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lab1_Bai4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1_Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tien;
        private System.Windows.Forms.ComboBox cbb_dvtt;
        private System.Windows.Forms.Button btn_cd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_stcd;
        private System.Windows.Forms.Label l_quydoi;
    }
}