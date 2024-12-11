using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaiThucHanh3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TinhUocSo(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    ListBox.Items.Add(i);
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string num = txbInput.Text;

            bool isValid = true;

            if (!int.TryParse(num, out _))
            {
                isValid = false;
                MessageBox.Show("Nhập sai dữ liệu rồi");
            }

            if (isValid)
            {
                HistoriesCbb.Items.Add(num);
            }

            TinhUocSo(Convert.ToInt32(num));
        }

        private void TotalBtn_Click(object sender, EventArgs e)
        {
            int sum = 0;

            foreach (var item in ListBox.Items)
            {
                sum += Convert.ToInt32(item.ToString()); 
            }

            MessageBox.Show($"Tổng các ước số là : {sum.ToString()}");
        }

        private void QuantityEvenBtn_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var item in ListBox.Items)
            {
                if (Convert.ToInt32(item.ToString()) % 2 == 0)
                {
                    count++;
                }
            }

            MessageBox.Show($"Số lượng ước số chẵn là: {count.ToString()}");
        }

        private void QuantityPrimeBtn_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (var item in ListBox.Items)
            {
                int num = Convert.ToInt32(item.ToString());
                bool isPrime = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    count++;
                }
            }

            MessageBox.Show($"Số các số nguyên tố là: {count}");
        }
    }
}
