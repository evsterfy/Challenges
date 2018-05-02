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
    public partial class frmFactorialFind : Form
    {
        public frmFactorialFind()
        {
            InitializeComponent();
        }

        private void btnSolveFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFactorialInput.Text, out int temp))
            {
                double input = (double)temp;

                if (input == 0 || input == 1)
                {
                    txtFactorialInput.Text = "1";
                }
                else
                {
                    int recurse = (int)input;
                    Factorial(input, recurse);
                }
            }
            else
            {
                txtFactorialInput.Text = "Invalid Input";
            }
        }

        private void Factorial(double input, int recurse)
        {
            if (recurse == 1)
            {
                txtFactorialInput.Text = Convert.ToString(input);
                return;
            }
            else
            {
                recurse--;
                input *= recurse;
                Factorial(input, recurse);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
