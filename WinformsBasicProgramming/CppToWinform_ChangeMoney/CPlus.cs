using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CppToWinform_ChangeMoney
{
    public class CPlus
    {
        public int ChangeMoney(int value)
        {
            int[] a = new int[] { 1, 2, 5, 10, 20, 50, 100, 200, 500, 1000 };
            int check = 0, i = 0;
            while (value >= 0)
            {
                value = value - a[i];
                i++;
                check++;
            }
            return check;
        }
        static void Main()
        {
        }
    }
}
