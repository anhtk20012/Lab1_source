using System;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Lab1_Bai1 : Form
    {
        public Lab1_Bai1()
        {
            InitializeComponent();
        }

        private void Lab1_Bai1_Load(object sender, EventArgs e)
        {
            tb_kq.ReadOnly = true;            
        }

        private void btn_kq_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2;
                long sum = 0;
                num1 = Int32.Parse(tb_st1.Text.Trim());
                num2 = Int32.Parse(tb_st2.Text.Trim());
                sum = num1 + num2;
                tb_kq.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
