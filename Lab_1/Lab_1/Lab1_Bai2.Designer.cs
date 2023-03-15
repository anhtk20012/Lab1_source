namespace Lab_1
{
    partial class Lab1_Bai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_st1 = new System.Windows.Forms.TextBox();
            this.tb_st2 = new System.Windows.Forms.TextBox();
            this.tb_st3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_sln = new System.Windows.Forms.TextBox();
            this.tb_snn = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số thứ 3";
            // 
            // tb_st1
            // 
            this.tb_st1.Location = new System.Drawing.Point(98, 12);
            this.tb_st1.Name = "tb_st1";
            this.tb_st1.Size = new System.Drawing.Size(203, 30);
            this.tb_st1.TabIndex = 1;
            // 
            // tb_st2
            // 
            this.tb_st2.Location = new System.Drawing.Point(98, 61);
            this.tb_st2.Name = "tb_st2";
            this.tb_st2.Size = new System.Drawing.Size(203, 30);
            this.tb_st2.TabIndex = 1;
            // 
            // tb_st3
            // 
            this.tb_st3.Location = new System.Drawing.Point(98, 111);
            this.tb_st3.Name = "tb_st3";
            this.tb_st3.Size = new System.Drawing.Size(203, 30);
            this.tb_st3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lớn nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số nhỏ nhất";
            // 
            // tb_sln
            // 
            this.tb_sln.Location = new System.Drawing.Point(12, 190);
            this.tb_sln.Name = "tb_sln";
            this.tb_sln.ReadOnly = true;
            this.tb_sln.Size = new System.Drawing.Size(289, 30);
            this.tb_sln.TabIndex = 2;
            // 
            // tb_snn
            // 
            this.tb_snn.Location = new System.Drawing.Point(12, 261);
            this.tb_snn.Name = "tb_snn";
            this.tb_snn.ReadOnly = true;
            this.tb_snn.Size = new System.Drawing.Size(289, 30);
            this.tb_snn.TabIndex = 2;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(342, 12);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(122, 52);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(342, 116);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(122, 52);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(342, 239);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(122, 52);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Lab1_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 314);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.tb_snn);
            this.Controls.Add(this.tb_sln);
            this.Controls.Add(this.tb_st3);
            this.Controls.Add(this.tb_st2);
            this.Controls.Add(this.tb_st1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lab1_Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1_Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_st1;
        private System.Windows.Forms.TextBox tb_st2;
        private System.Windows.Forms.TextBox tb_st3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_sln;
        private System.Windows.Forms.TextBox tb_snn;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_thoat;
    }
}