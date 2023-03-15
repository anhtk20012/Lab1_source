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
    public partial class Lab1_Bai8 : Form
    {
        public Lab1_Bai8()
        {
            InitializeComponent();
        }

        private void btn_format_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_dssv.Text.Trim() == "")
                {
                    MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool[] checkdtb = {true, true, true, true};
                    string dl = tb_dssv.Text;
                    double tmp;
                    bool checktmp = false;
                    string[] arrdl = dl.Split(',');
                    IDictionary<string, double> list = new Dictionary<string, double>();
                    for (int i = 0; i < arrdl.Length; i++)
                    {
                        tmp = Double.Parse(arrdl[i]);
                        if (tmp < 0 || tmp > 10)
                        {
                            MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            checktmp = true;
                            break;
                        }
                        list.Add("Môn " + (i + 1).ToString() + " : ", tmp);
                    }  
                    if (checktmp == false)
                    {
                        richTextBox1.Clear();
                        double tmp1 = 0, tmp2 = 10, tmp3 = 0;
                        foreach (var vkl in list)
                        {
                            richTextBox1.Text += vkl.Key + vkl.Value.ToString() + "\n";
                            if (vkl.Value < 6.5) 
                            { 
                                checkdtb[0] = false;
                            }
                            if (vkl.Value < 5)
                            {
                                richTextBox3.Text += vkl.Key + vkl.Value.ToString() + "\n";
                                checkdtb[1] = false;
                            }
                            else
                            {
                                richTextBox2.Text += vkl.Key + vkl.Value.ToString() + "\n";
                            }
                            if (vkl.Value < 3.5)
                            {
                                checkdtb[2] = false;
                            }
                            if (vkl.Value < 2)
                            {
                                checkdtb[3] = false;
                            }
                            
                            tmp1 += vkl.Value;
                            tmp2 = Math.Min(tmp2, vkl.Value);
                            tmp3 = Math.Max(tmp3, vkl.Value);
                        }
                        tb_min.Text = tmp2.ToString();
                        tb_max.Text = tmp3.ToString();
                        double dtb = tmp1 / list.Count;
                        tb_dtb.Text = dtb.ToString();
                        if (dtb >= 8 && checkdtb[0] == true)
                        {
                            tb_xl.Text = "Giỏi";
                        }
                        else
                        if (dtb >= 6.5 && checkdtb[1] == true)
                        {
                            tb_xl.Text = "Khá";
                        }
                        else
                        if (dtb >= 5 && checkdtb[2] == true)
                        {
                            tb_xl.Text = "Trung Bình";
                        }
                        else
                        if (dtb >= 3.5 && checkdtb[3] == true)
                        {
                            tb_xl.Text = "Yếu";
                        }
                        else tb_xl.Text = "Kém";
                    }   
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(e.ToString(), "Dữ liệu nhập bị lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tb_dtb.Text = tb_dssv.Text = tb_max.Text = tb_min.Text = tb_xl.Text = "";
            richTextBox1.Text = richTextBox2.Text = richTextBox3.Text = "";
        }
    }
}
