using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsBasicProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txbValue.Text, out num))
            {
                MessageBox.Show("bình phương của số cần tính là: " + (num * num).ToString());
            }
            else
            {
                //btnClick.Text = "Mời nhập số!!!";               
                DialogResult result = MessageBox.Show("Mời nhập số!!!", "", MessageBoxButtons.YesNoCancel);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    
                }
            }
        }
    }
}
