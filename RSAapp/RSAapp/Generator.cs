using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSAapp
{
    public class Generator
    {
        private int p, q;
        private int n;

        private int e, d, phi_n, k;
        public Generator(int p, int q)
        {
                this.p = (int)p;
                this.q = (int)q;
                this.calc_n();
                this.calc_phi_n();
                this.calc_e();
                this.calc_d();
        }
        public Generator(int x, int n, bool isencrypt)
        {
            if (isencrypt)
            {
                this.e = x;
            }
            else
            {
                this.d = x;
            }
            this.n = n;
        }

        private int pbb(int a, int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }
        private long modular(int b, int exp, int mod)
        {
            long x = 1;
            int i;
            long power = b % mod;

            for (i = 0; i < sizeof(int) * 8; i++)
            {
                int least_sig_bit = 0x00000001 & (exp >> i);
                if (Convert.ToBoolean(least_sig_bit))
                    x = (x * power) % mod;
                power = (power * power) % mod;
            }

            return x;
        }
        private void calc_n()
        {
            this.n = this.p * this.q;
        }
        private void calc_phi_n()
        {
            this.phi_n = (this.p - 1) * (this.q - 1);
        }
        private bool calc_e()
        {
            this.e = 2;
            int[] candidate = new int[3];
            int ccount = 0;
            while ((this.pbb(this.e, this.phi_n) != 1 || ccount < 3) && this.e < this.phi_n)
            {
                this.e++;
                if (pbb(this.e, this.phi_n) == 1)
                {
                    candidate[ccount] = this.e;
                    ccount++;
                }
            }
            Random rnd = new Random();
            int rndindx = rnd.Next(ccount);
            this.e = candidate[rndindx];

            if(this.e >= phi_n)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void calc_d()
        {
            this.k = 1;
            while (((this.k * this.phi_n) + 1) % this.e != 0)
                this.k++;
            this.d = ((this.k * this.phi_n) + 1) / this.e;
        }
        private string enc_char(char msg)
        {
            long c = modular(Convert.ToInt32(msg), e, n);
            int nlen = Convert.ToInt32(Math.Floor(Math.Log10(n) + 1));
            string final = c.ToString();
            if (final.Length < nlen)
            {
                final = final.PadLeft(nlen,'0');
            }
            return final;
        }
        private char dec_char(string msg)
        {
            long m = 0;
            try
            {
                m = modular(Convert.ToInt32(msg), d, n);
            }
            catch(Exception err)
            {
                global_function.msg(err.Message.ToString());
            }
            return (char)m;
        }
        public string dec(string msg)
        {
            int nlen = Convert.ToInt32(Math.Floor(Math.Log10(n) + 1));
            int cipher_len = msg.Length;
            string result = "";
            for (int i = 0; i < (cipher_len / nlen); i++)
            {
                result += dec_char(msg.Substring(0, nlen));
                msg = msg.Remove(0, nlen);
            }
            return result;
        }
        public string enc(string x)
        {
            int xlen = x.Length;
            string result = "";
            for (int i = 0; i < xlen; i++)
            {
                result += enc_char(Convert.ToChar(x.Substring(i,1)));
            }
            return result;
        }

        public int getn()
        {
            return this.n;
        }
        public int gete()
        {
            return this.e;
        }
        public int get_phi_n()
        {
            return this.phi_n;
        }
        public int getd()
        {
            return this.d;
        }
        public int getp()
        {
            return this.p;
        }
        public int getq()
        {
            return this.q;
        }
        public int getk()
        {
            return this.k;
        }
    }
}
