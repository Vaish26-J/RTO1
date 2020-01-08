using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RTO1
{
    public partial class llr_add : Form
    {
        public llr_add()
        {
            InitializeComponent();
        }
        public static string setValue1 = "";
        public static string setValue2 = "";
        public static string setValue3 = "";
        public static string setValue4 = "";
        public static string setValue5 = "";
        public static string setValue6 = "";
        public static string setValue7 = "";

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           setValue1 = textBox1.Text;
            setValue2 = textBox7.Text;
            setValue3 = textBox6.Text;
            setValue4 = textBox2.Text;
            setValue5 = textBox3.Text;
            setValue6 = textBox4.Text;
           setValue7 = textBox5.Text;
             
             docs a = new docs();
             a.Show();
            this.Hide();

        }


    }
    
}
