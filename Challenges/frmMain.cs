using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenges
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFactorialFind_Click(object sender, EventArgs e)
        {
            frmFactorialFind form = new frmFactorialFind();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void btnSpeedTrack_Click(object sender, EventArgs e)
        {
            frmSpeedTracker form = new frmSpeedTracker();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void btnThief_Click(object sender, EventArgs e)
        {
            frmThief form = new frmThief();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
