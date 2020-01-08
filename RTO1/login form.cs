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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        } 

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = connection1.GetConnection();
            MySqlCommand cmdDataBase = new MySqlCommand("select * from vaish.user where username='" + this.username.Text + "'and password='" + this.password.Text + "';", connect);
            MySqlDataReader myReader;
            try
            {
                connect.Open();
                myReader = cmdDataBase.ExecuteReader();
                int count = 0;
                while (myReader.Read()) 
                {
                    count = count + 1;
                }
                if(count==1)
                {
                    MessageBox.Show("Username and password are correct");
                }
                else if(count>1)
                {
                    MessageBox.Show("Duplicate values present");

                }
                else
                {
                    MessageBox.Show("Username and password are incorrect...Please try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
