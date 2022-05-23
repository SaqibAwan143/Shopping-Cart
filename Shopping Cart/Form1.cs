using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_Cart
{
    public partial class Form1 : Form
    {
        string sts;
        string shs;
        string pts;
        float shirts = 0;
        float shoes = 0;
        float pants = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            sts = textBox6.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            shirts = float.Parse(sts) * 9.95f;
            shoes = float.Parse(shs) * 19.95f;
            pants = float.Parse(pts) * 14.95f;
            textBox11.Text = shirts.ToString();
            textBox10.Text = shoes.ToString();
            textBox9.Text = pants.ToString();
            float total = shirts + shoes + pants;
            textBox5.Text ="Total : $"+ total.ToString();
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            shs = textBox7.Text;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            pts = textBox8.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            shirts = 0;
            pants = 0;
            shoes = 0;
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "$";
            textBox10.Text = "$";
            textBox11.Text = "$";
            textBox5.Text = "$";
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
