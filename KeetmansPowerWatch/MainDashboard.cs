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
    }
}
