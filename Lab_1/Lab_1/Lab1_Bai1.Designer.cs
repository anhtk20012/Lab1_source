namespace Lab_1
{
    partial class Lab1_Bai1
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
            this.tb_kq = new System.Windows.Forms.TextBox();
            this.btn_kq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số thứ 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kết Quả";
            // 
            // tb_st1
            // 
            this.tb_st1.Location = new System.Drawing.Point(135, 29);
            this.tb_st1.Name = "tb_st1";
            this.tb_st1.Size = new System.Drawing.Size(232, 30);
            this.tb_st1.TabIndex = 0;
            // 
            // tb_st2
            // 
            this.tb_st2.Location = new System.Drawing.Point(135, 83);
            this.tb_st2.Name = "tb_st2";
            this.tb_st2.Size = new System.Drawing.Size(232, 30);
            this.tb_st2.TabIndex = 1;
            // 
            // tb_kq
            // 
            this.tb_kq.Location = new System.Drawing.Point(135, 135);
            this.tb_kq.Name = "tb_kq";
            this.tb_kq.Size = new System.Drawing.Size(232, 30);
            this.tb_kq.TabIndex = 4;
            // 
            // btn_kq
            // 
            this.btn_kq.Location = new System.Drawing.Point(165, 187);
            this.btn_kq.Name = "btn_kq";
            this.btn_kq.Size = new System.Drawing.Size(104, 47);
            this.btn_kq.TabIndex = 3;
            this.btn_kq.Text = "Kết Quả";
            this.btn_kq.UseVisualStyleBackColor = true;
            this.btn_kq.Click += new System.EventHandler(this.btn_kq_Click);
            // 
            // Lab1_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 246);
            this.Controls.Add(this.btn_kq);
            this.Controls.Add(this.tb_kq);
            this.Controls.Add(this.tb_st2);
            this.Controls.Add(this.tb_st1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Lab1_Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1_Bai1";
            this.Load += new System.EventHandler(this.Lab1_Bai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_st1;
        private System.Windows.Forms.TextBox tb_st2;
        private System.Windows.Forms.TextBox tb_kq;
        private System.Windows.Forms.Button btn_kq;
    }
}