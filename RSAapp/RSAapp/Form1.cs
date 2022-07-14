using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAapp
{
    public partial class Form1 : Form
    {
        Generator RSA;
        string mode;
        public Form1()
        {
            InitializeComponent();
        }
        private void clear_init()
        {
            GBKeyGen.Enabled = false;
            GBKeyInf.Enabled = false;
            GBTextInp.Enabled = false;
            GBTextOut.Enabled = true;
            Calc_text_btn.Enabled = false;

            raw_input_txt.Text = "";
            output_txt.Text = "";

            GK_P_txt.Text = "";
            GK_Q_txt.Text = "";

            NKey_txt.Text = "";
            PhKey_txt.Text = "";
            KKey_txt.Text = "";
            EKey_txt.Text = "";
            DKey_txt.Text = "";

            PhKey_txt.ReadOnly = true;
            KKey_txt.ReadOnly = true;
            NKey_txt.ReadOnly = false;
            EKey_txt.ReadOnly = false;
            DKey_txt.ReadOnly = false;

            PhKey_txt.Enabled = true;
            KKey_txt.Enabled = true;
            NKey_txt.Enabled = true;
            EKey_txt.Enabled = true;
            DKey_txt.Enabled = true;


            warning_lbl.Text = "";

            global_function.unset_warning_txt(GK_P_txt);
            global_function.unset_warning_txt(GK_Q_txt);
            global_function.unset_warning_txt(NKey_txt);
            global_function.unset_warning_txt(PhKey_txt);
            global_function.unset_warning_txt(KKey_txt);
            global_function.unset_warning_txt(EKey_txt);
            global_function.unset_warning_txt(DKey_txt);
        }
        private void clearkeyinf()
        {
            NKey_txt.Text = "";
            PhKey_txt.Text = "";
            KKey_txt.Text = "";
            EKey_txt.Text = "";
            DKey_txt.Text = "";
            Calc_text_btn.Enabled = false;
        }

        //button switch mode
        private void button1_Click(object sender, EventArgs e)
        {
            this.clear_init();
            GBKeyInf.Enabled = true;
            GBKeyGen.Enabled = true;


            NKey_txt.ReadOnly = true;
            EKey_txt.ReadOnly = true;
            DKey_txt.ReadOnly = true;

            SetKey_btn.Enabled = false;
        }
        private void ENCKey_button_Click(object sender, EventArgs e)
        {
            this.clear_init();
            GBKeyInf.Enabled = true;
            GBKeyGen.Enabled = false;

            NKey_txt.Enabled = true;
            EKey_txt.Enabled = true;
            DKey_txt.Enabled = false;

            mode = "enc";

            SetKey_btn.Enabled = true;

        }
        private void DECKey_button_Click(object sender, EventArgs e)
        {
            this.clear_init();
            GBKeyInf.Enabled = true;
            GBKeyGen.Enabled = false;

            NKey_txt.Enabled = true;
            EKey_txt.Enabled = false;
            DKey_txt.Enabled = true;

            mode = "dec";

            SetKey_btn.Enabled = true;
        }
        private void All_btn_Click(object sender, EventArgs e)
        {
            this.clear_init();
            GBKeyInf.Enabled = true;
            GBKeyGen.Enabled = true;
        }


        //button generate key
        private void button5_Click(object sender, EventArgs e)
        {
            this.clearkeyinf();
            if(GK_P_txt.Text == "" || GK_Q_txt.Text == "")
            {
                if (GK_P_txt.Text == "") global_function.set_warning_txt(GK_P_txt);
                if (GK_Q_txt.Text == "") global_function.set_warning_txt(GK_Q_txt);
                warning_lbl.Text = "Silahkan Isi Nilai P dan Q dengan benar";
            }
            else if( !global_function.isprime(int.Parse(GK_P_txt.Text)) || !global_function.isprime(int.Parse(GK_P_txt.Text)))
            {
                warning_lbl.Text = "Nilai P dan Q Haruslah bilangan prima";
                MessageBox.Show("Nilai P atau Q terdeteksi bukan bilangan prima!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(GK_P_txt.Text.ToString()) * int.Parse(GK_P_txt.Text.ToString()) < 256)
            {
                warning_lbl.Text = "Nilai P dan Q terlalu Kecil!";
                MessageBox.Show("Nilai P dan Q terlalu Kecil!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                warning_lbl.Text = "";
                RSA = new Generator(int.Parse(GK_P_txt.Text),int.Parse(GK_Q_txt.Text));
                NKey_txt.Text = RSA.getn().ToString();
                PhKey_txt.Text = RSA.get_phi_n().ToString();
                KKey_txt.Text = RSA.getk().ToString();
                EKey_txt.Text = RSA.gete().ToString();
                DKey_txt.Text = RSA.getd().ToString();
                GBTextInp.Enabled = true;
                Calc_text_btn.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GK_P_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (GK_P_txt.Text != "") global_function.unset_warning_txt(GK_P_txt);
        }

        private void GK_Q_txt_KeyUp(object sender, KeyEventArgs e)
        {
            if (GK_Q_txt.Text != "") global_function.unset_warning_txt(GK_Q_txt);
        }

        private void GK_P_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GK_Q_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Calc_text_btn_Click(object sender, EventArgs e)
        {
            if(mode == "dec")
            {
                output_txt.Text = RSA.dec(raw_input_txt.Text);
            }
            else
            {
                try
                {
                    output_txt.Text = RSA.enc(raw_input_txt.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }

        private void SetKey_btn_Click(object sender, EventArgs e)
        {
            if(mode == "dec")
            {
                if(NKey_txt.Text == "" || DKey_txt.Text == "")
                {
                    if (NKey_txt.Text == "") global_function.set_warning_txt(NKey_txt);
                    if (DKey_txt.Text == "") global_function.set_warning_txt(DKey_txt);
                    warning_lbl.Text = "Silahkan Isi Nilai d dan n";
                }
                else
                {
                    global_function.unset_warning_txt(NKey_txt);
                    global_function.unset_warning_txt(DKey_txt);
                    warning_lbl.Text = "";
                    GBTextInp.Enabled = true;
                    Calc_text_btn.Enabled = true;
                    RSA = new Generator(Convert.ToInt32(DKey_txt.Text), Convert.ToInt32(NKey_txt.Text), false);
                }
            }
            else if(mode == "enc")
            {
                if (NKey_txt.Text == "" || EKey_txt.Text == "")
                {
                    if (NKey_txt.Text == "") global_function.set_warning_txt(NKey_txt);
                    if (EKey_txt.Text == "") global_function.set_warning_txt(EKey_txt);
                    warning_lbl.Text = "Silahkan Isi Nilai e dan n";
                }
                else
                {
                    global_function.unset_warning_txt(NKey_txt);
                    global_function.unset_warning_txt(EKey_txt);
                    warning_lbl.Text = "";
                    GBTextInp.Enabled = true;
                    Calc_text_btn.Enabled = true;
                    RSA = new Generator(Convert.ToInt32(EKey_txt.Text), Convert.ToInt32(NKey_txt.Text), true);
                }
            }
        }
    }
}
