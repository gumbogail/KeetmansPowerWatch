using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeetmansPowerWatch
{
    public partial class SIGNUP : Form
    {

        //creates an object of type signup
        public static SIGNUP instance;
        public SIGNUP()
        {
            InitializeComponent();
            instance = this;
        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//hides aignup forms when maindashboard is open
            //opens the main dasshboard
            MainDashboard MD = new MainDashboard();
            MD.Show();
        }
    }
}
