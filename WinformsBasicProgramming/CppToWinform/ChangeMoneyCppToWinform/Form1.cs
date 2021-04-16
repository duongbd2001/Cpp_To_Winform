using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeMoneyCppToWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //textBox1: mệnh giá tờ tiền cần đổi
        //textBox2: mệnh giá tờ tiền có sẵn: 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000
        //textBox3: tất cả mệnh giá đã đổi được

        private void btnClick_Click(object sender, EventArgs e)
        {
            int a = 0;                                      //a là mệnh giá tờ tiền cần đổi
            if (int.TryParse(txbValue1.Text, out a))        //nếu textBox1 là số thì show ra số tờ đổi được, in ra tất cả mệnh giá đổi được ở textBox3
            {
                a = int.Parse(txbValue1.Text);
                string[] B = txbValueMoney2.Text.Split(',');                //ép kiểu string sang int cho textBox2
                int[] b = Array.ConvertAll(B, s => int.Parse(s));
                MoneyChangeProgram change = new MoneyChangeProgram();
                change.moneyChange(a, b);                                       
                //txbValue3.Text = change.moneyChange(a,b).ToString();            //dòng này muốn in ra các mệnh giá đổi được ở textBox3
            }
            else                                                                 //nếu textBox1 ko phải là số thì yêu cầu nhập lại           
            {
                MessageBox.Show("Mời nhập mệnh giá tờ tiền");
            }
            
        }
    }
}
