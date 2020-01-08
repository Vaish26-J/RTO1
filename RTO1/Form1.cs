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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NAME_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblpara_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Signin_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
                f2.Show();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
         
                
            this.Hide();
            login_form a = new login_form();
            a.Show();
        }

        private void LearnersLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LLR_application L = new LLR_application();
            L.Show();
            this.Hide();
        }
    }
     

    
}
static class connection1
{
    static MySqlConnection connect;
    public static MySqlConnection GetConnection()
    {

        if (connect == null)
        {
            connect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=26082000");

            return connect;
        }
        else
        {

            return connect;

        }
    }
}