using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load();
        }

        private bool Validate(string first, string last)
        {
            if (!double.TryParse(first, out _) || !double.TryParse(last, out _))
            {
                MessageBox.Show("Nhập sai rồi, nhập lại đêeeeee!");
                return false;
            }

            return true;
        }

        private void Load()
        {
            List<RadioButton> radioList = new List<RadioButton>()
            {
                CongRadiobtn,
                TruRadiobtn,
                NhanRadiobtn,
                ChiaRadiobtn
            };

            foreach (RadioButton radio in radioList)
            {
                radio.CheckedChanged += (sender, e) =>
                {
                    // Kiểm tra nếu radio được chọn, tránh sự kiện CheckedChanged lặp lại không cần thiết
                    if (radio.Checked)
                    {
                        string firstNum = FirstNumtxb.Text;
                        string lastNum = LastNumtxb.Text;

                        bool isValid = Validate(firstNum, lastNum);

                        if (isValid)
                        {
                            double num1 = double.Parse(firstNum);
                            double num2 = double.Parse(lastNum);

                            switch (radio.Name)
                            {
                                case "CongRadiobtn":
                                    Resulttxb.Text = (num1 + num2).ToString();
                                    break;
                                case "TruRadiobtn":
                                    Resulttxb.Text = (num1 - num2).ToString();
                                    break;
                                case "NhanRadiobtn":
                                    Resulttxb.Text = (num1 * num2).ToString();
                                    break;
                                case "ChiaRadiobtn":
                                    // Kiểm tra chia cho 0
                                    if (num2 != 0)
                                        Resulttxb.Text = (num1 / num2).ToString();
                                    else
                                        MessageBox.Show("Không thể chia cho 0!");
                                    break;
                            }
                        }
                    }
                };
            }
        }
    }
}
