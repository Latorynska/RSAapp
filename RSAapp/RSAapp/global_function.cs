using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace RSAapp
{
    class global_function
    {
        public static bool isprime(int x)
        {
            for (int i = 2; i <= Convert.ToInt32(Math.Sqrt(x)); i++)
                if (x % i == 0) return false;
            return true;
        }
        public static void msg(string x)
        {
            MessageBox.Show(x);
        }
        public static void set_warning_txt(TextBox x)
        {
            x.BackColor = Color.Red;
        }
        public static void unset_warning_txt(TextBox x)
        {
            x.BackColor = Color.White;
        }
    }
}
