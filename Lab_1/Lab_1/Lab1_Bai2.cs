using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_st1.Text = "";
            tb_st2.Text = "";
            tb_st3.Text = "";
            tb_sln.Text = "";
            tb_snn.Text = "";
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            try
            {
                int num1, num2, num3;
                num1 = Int32.Parse(tb_st1.Text.Trim());
                num2 = Int32.Parse(tb_st2.Text.Trim());
                num3 = Int32.Parse(tb_st3.Text.Trim());
                tb_sln.Text = Math.Max(num1, Math.Max(num2, num3)).ToString();
                tb_snn.Text = Math.Min(num1, Math.Min(num2, num3)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
