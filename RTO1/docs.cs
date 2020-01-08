using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RTO1
{
    public partial class docs : Form
    {
        public docs()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            llr_class a = new llr_class();
            a.Show();
            this.Hide();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
             
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }
    }
}
