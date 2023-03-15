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
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void btn_cd_Click(object sender, EventArgs e)
        {
            try
            {
                IDictionary<double, string> dvtt = new Dictionary<double, string>() {
                    { 22.772,"USD"},
                        { 28.132,"EUR"},
                            { 31.538,"GBP"},
                                { 17.286,"SGD"},
                                    { 214,"JPY"},
                };
                double num1 = double.Parse(tb_tien.Text.Trim());
                bool checknull = true;
                foreach (var kvp in dvtt)
                {
                    if (kvp.Value == cbb_dvtt.Text)
                    {
                        double sum = num1 * kvp.Key;
                        tb_stcd.Text = sum.ToString();
                        l_quydoi.Text = "1 " + kvp.Value + " = " + kvp.Key + " VND";
                        checknull = false;
                        break;
                    }
                }
                if (checknull == true) MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
