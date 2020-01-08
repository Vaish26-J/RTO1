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

    public partial class LLR_application : Form
    {
        string gender;
        public LLR_application()
        {
            InitializeComponent();
        }
        public static string set1 = "";
        public static string set2 = "";
        public static string set3 = "";
        public static string set4 = "";
        public static string set5 = "";
        public static string set6 = "";
        public static string set7 = ""; public static string set10 = "";
        public static string set8 = ""; public static  string set11 = "";
        public static string set9 = ""; public static string set12 = ""; public static string set13 = "";
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            set1 = textBox1.Text;
            set2 = textBox8.Text;
            set3 = textBox7.Text;
            set4 = gender;
            set5 = textBox2.Text;
            set6 = textBox4.Text;
            set7 = textBox3.Text;
            set8 = textBox6.Text; set11 = textBox13.Text; 
            set9 = comboBox1.Text; set12 = textBox12.Text; 
            set10 = textBox10.Text; set13 = dateTimePicker1.Text;
            
           
            llr_add A = new llr_add();
            A.Show();
            this.Hide();
        }

        private void LLR_application_Load(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "male";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "female";
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Transgender";
        }
    }
}      
    
