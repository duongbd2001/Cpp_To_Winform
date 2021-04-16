using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace ChangeMoneyCppToWinform
{
    class MoneyChangeProgram
    {
        public void moneyChange(int n, int[] a)
        {
            List<string> b = new List<string>();           //mảng b là mảng gồm những mệnh giá đã đổi được, được in ra ở textBox3
            int check = 0, j = 0;
            for (int i = 0; i < 10; i++)    //vòng lặp đếm tổng số tờ tiền đổi được
            {
                while (a[i] <= n)
                {
                    n = n - a[i]; check++;
                    b.Add(a[i].ToString());
                }
            }
            string[] B = b.Select(x => x.ToString()).ToArray();         //convert mảng b sang dạng string
            string separator = ", ";
            Form1 f = new Form1();
            f.txbValue3.Text = string.Join(separator, B);
            MessageBox.Show("Đổi được "+check.ToString()+" tờ tiền.");
            MessageBox.Show(f.txbValue3.Text, "Mệnh giá đổi được: ");
        }
    }
}
