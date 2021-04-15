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
        public int moneyChange(int n, int[] a)
        {
            int m = 100;
            int[] b = new int[m];
            int check = 0, j = 0;
            for (int i = 9; i >= 0; i--)
            {
                while (a[i] <= n)
                {
                    n = n - a[i];
                    b[j] = a[i];
                    j++;
                    check++;
                }
            }
            for (int i = 0; i < m; i++)
            {
                if (b[i] == 0)
                {
                    m--;
                    i = i - 1;
                }
            }
            MessageBox.Show("Đổi được "+check.ToString()+" tờ tiền.");
            return b;
        }
    }
}
