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
    

    public partial class average_consumption : Form
    {
        public static average_consumption instance;
        public average_consumption()
        {
            InitializeComponent();
            instance = this;
        }

        private void average_consumption_Load(object sender, EventArgs e)
        {
            //statements to pull from database
        }

        private void HomepictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();//hides login forms when maindashboard is open
                        //opens the bill page 
            MainDashboard MD = new MainDashboard();
            MD.Show();
        }

        private void averagecons_Click(object sender, EventArgs e)
        {
            //statements to pull from database
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //statements to pull from database
        }
    }
}
