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
    public partial class AccountDetails : Form
    {
        public static AccountDetails  AcD;
        public AccountDetails()
        {
            InitializeComponent();
            AcD = this;
        }

        private void AccountDetails_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();//hides login forms when maindashboard is open
                        //opens the bill page 
            MainDashboard MD = new MainDashboard();
            MD.Show();
        }
    }
}
