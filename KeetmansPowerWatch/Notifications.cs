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
 
    public partial class Notifications : Form
    {
        public static Notifications Instance ; 
        public Notifications()
        {
            InitializeComponent();
            Instance = this;


        }

        private void Notifications_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();//hides  maindashboard when this is open
            //opens the notifications page 
            Notifications notification = new Notifications();
            notification.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();//hides login forms when maindashboard is open
                        //opens the bill page 
            Bill bill = new Bill();
            bill.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Hide();//hides login forms when maindashboard is open
                        //opens the bill page 
            MainDashboard MD = new MainDashboard();
            MD.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //statements to pull data from database
        }
    }
}
