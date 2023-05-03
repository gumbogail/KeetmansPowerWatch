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
    public partial class MainDashboard : Form
    {
        //creates object of type maindashboard
        public static MainDashboard instance;
        public MainDashboard()
        {
            InitializeComponent();
            instance = this;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }

       // private void label1_Click(object sender, EventArgs e)
       

       // private void notifications_Click(object sender, EventArgs e)
        

      //  private void averagecons_Click(object sender, EventArgs e)
        

       // private void account_Click(object sender, EventArgs e)
        
       // private void logout_Click(object sender, EventArgs e)
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();//hides login forms when maindashboard is open
                        //opens the bill page 
            Bill bill = new Bill();
            bill.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();//hides  maindashboard when this is open
            //opens the notifications page 
            AccountDetails AD = new AccountDetails();
            AD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();//hides  maindashboard when this is open
            //opens the average consumption page 
            average_consumption av = new average_consumption();
            av.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();//hides  maindashboard when this is open
            //opens the notifications page 
            Notifications notification = new Notifications();
            notification.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();//hides login forms when maindashboard is open
            //opens the main dasshboard
            LOGIN log = new LOGIN();
            log.Show();
        }
    }
}