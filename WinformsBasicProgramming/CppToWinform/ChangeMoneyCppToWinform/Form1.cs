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

        private void btnClick_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (int.TryParse(txbValue1.Text, out a))
            {
                a = int.Parse(txbValue1.Text);
                string[] B = txbValueMoney2.Text.Split(',');
                int[] b = Array.ConvertAll(B, s => int.Parse(s));
                MoneyChangeProgram change = new MoneyChangeProgram();
                change.moneyChange(a, b);
                txbValue3.Text = change.moneyChange(a,b).ToString();
            }
            else
            {
                MessageBox.Show("Mời nhập mệnh giá tờ tiền");
            }
            
        }
    }
}
