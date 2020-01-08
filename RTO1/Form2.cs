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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            MySqlConnection dbConnect = connection1.GetConnection();
            MySqlCommand cmdDataBase = new MySqlCommand("insert into vaish.user (fullname,email,phone,age,username,password,roles) values('" + this.fullname_txt.Text + "','" + this.email_txt.Text + "','" + this.phone_txt.Text + "','" + this.age_txt.Text + "','" + this.username_txt.Text + "','" + this.password_txt.Text + "','user');", dbConnect);
            MySqlDataReader myReader;
            try
            {
                dbConnect.Open();
                myReader = cmdDataBase.ExecuteReader();
                while(myReader.Read())
                {
                    if(myReader.HasRows==true)
                    {
                        MessageBox.Show("username already exists");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dbConnect.Close();
            this.Hide();
            FrontPage a = new FrontPage();
            a.Show();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
