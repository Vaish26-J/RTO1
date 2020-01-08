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
    public partial class llr_class : Form
    {
        public llr_class()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect = connection1.GetConnection();
            MySqlCommand cmdDataBase = new MySqlCommand("insert into vaish.llr (username,first_name,last_name,gender,age,birthplace,country,qualification,bloodgp,mobile,identity1,identity2,dob,state,district,town,h_no,street,landmark,pincode,class) values('"+ LLR_application .set1+ "','" + LLR_application.set2 + "','" + LLR_application.set3 + "','" + LLR_application.set4 + "','" + LLR_application.set5+ "','" + LLR_application.set6 + "','" + LLR_application.set7 + "','" + LLR_application.set8 + "','" + LLR_application.set9 + "','" + LLR_application.set10 + "','" + LLR_application.set11 + "','" + LLR_application.set12 + "','" + LLR_application.set13 + "','" + llr_add.setValue1 + "','" + llr_add.setValue2 + "','" + llr_add.setValue3 + "','" + llr_add.setValue4 + "','" + llr_add.setValue5 + "','" + llr_add.setValue6 + "','" + llr_add.setValue7 + "','" + this.comboBox1.Text + "');", connect);
            MySqlDataReader myReader;
            try
            {
                connect.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {

                }
                
                MessageBox.Show("Registered successfully");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
