using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Member;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Button2_Click_1(object sender, EventArgs e)
        {
            Register f = new Register();
            f.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }
    }
}
