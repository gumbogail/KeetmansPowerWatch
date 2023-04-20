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
    public partial class LOGIN : Form
    {
        public static LOGIN Instance;
        public LOGIN()
        {
            InitializeComponent();
            Instance=this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//hides login forms when maindashboard is open
            //opens the main dasshboard
            MainDashboard MD = new MainDashboard();
            MD.Show();
          
        }

        private void signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//hides login forms when maindashboard is open
            //opens the signup page 
            SIGNUP signUp = new SIGNUP();
            signUp.Show();
            
        }

        private void LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//terminates login program when closed
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
