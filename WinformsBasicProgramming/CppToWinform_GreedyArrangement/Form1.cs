using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CppToWinform_GreedyArrangement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = new int[];
            int[] a = Convert.ToInt32(txbValueArray1.Text.Split(','));
            String b = txbValueArray2.Text;
            a.Split(',');
            GreedyArrangement greedyArrangement = new GreedyArrangement();
            if (greedyArrangement.GreddyArray(a,b) == a.Length)
            {
                MessageBox.Show("Mảng có thể sắp xếp bằng cách đảo ngược");
            }
            else
            {
                MessageBox.Show("Mảng không có thể sắp xếp bằng cách đảo ngược");
            }
        }
    }
}
