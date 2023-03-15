namespace Lab_1
{
    partial class Lab1_Bai8
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
            this.tb_dssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_format = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_max = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_min = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.tb_xl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_dtb = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_dssv
            // 
            this.tb_dssv.Location = new System.Drawing.Point(30, 51);
            this.tb_dssv.Name = "tb_dssv";
            this.tb_dssv.Size = new System.Drawing.Size(486, 30);
            this.tb_dssv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập danh sách điểm của sinh viên";
            // 
            // btn_format
            // 
            this.btn_format.Location = new System.Drawing.Point(522, 47);
            this.btn_format.Name = "btn_format";
            this.btn_format.Size = new System.Drawing.Size(159, 39);
            this.btn_format.TabIndex = 2;
            this.btn_format.Text = "Kiểm tra dữ liệu";
            this.btn_format.UseVisualStyleBackColor = true;
            this.btn_format.Click += new System.EventHandler(this.btn_format_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách điểm môn";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 136);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(191, 228);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm cao nhất";
            // 
            // tb_max
            // 
            this.tb_max.Location = new System.Drawing.Point(249, 136);
            this.tb_max.Name = "tb_max";
            this.tb_max.ReadOnly = true;
            this.tb_max.Size = new System.Drawing.Size(267, 30);
            this.tb_max.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Điểm thấp nhất";
            // 
            // tb_min
            // 
            this.tb_min.Location = new System.Drawing.Point(522, 136);
            this.tb_min.Name = "tb_min";
            this.tb_min.ReadOnly = true;
            this.tb_min.Size = new System.Drawing.Size(267, 30);
            this.tb_min.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Môn đậu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Môn rớt";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(249, 212);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(267, 108);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(522, 212);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(267, 108);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "";
            // 
            // tb_xl
            // 
            this.tb_xl.Location = new System.Drawing.Point(333, 334);
            this.tb_xl.Name = "tb_xl";
            this.tb_xl.ReadOnly = true;
            this.tb_xl.Size = new System.Drawing.Size(183, 30);
            this.tb_xl.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Xếp loại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "ĐTB";
            // 
            // tb_dtb
            // 
            this.tb_dtb.Location = new System.Drawing.Point(606, 336);
            this.tb_dtb.Name = "tb_dtb";
            this.tb_dtb.ReadOnly = true;
            this.tb_dtb.Size = new System.Drawing.Size(183, 30);
            this.tb_dtb.TabIndex = 8;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(688, 47);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 39);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Lab1_Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 376);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.tb_min);
            this.Controls.Add(this.tb_dtb);
            this.Controls.Add(this.tb_xl);
            this.Controls.Add(this.tb_max);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_format);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dssv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lab1_Bai8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1_Bai8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_dssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_format;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_min;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox tb_xl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_dtb;
        private System.Windows.Forms.Button btn_xoa;
    }
}