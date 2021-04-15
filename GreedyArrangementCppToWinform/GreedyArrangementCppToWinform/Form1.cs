using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreedyArrangementCppToWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] A = txbValueArray1.Text.Split(',');
            int[] a = Array.ConvertAll(A, s => int.Parse(s));
            string[] B = txbValueArray1.Text.Split(',');
            int[] b = Array.ConvertAll(B, s => int.Parse(s));
            GreedyArrangement greedyArrangement = new GreedyArrangement();
            if (greedyArrangement.GreddyArray(a, b) == a.Length)
            {
                MessageBox.Show("Mảng có thể sắp xếp bằng cách đảo ngược");
            }
            else
            {
                MessageBox.Show("Mảng không thể sắp xếp bằng cách đảo ngược");
            }
        }
    }
}
