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
    public partial class frmSpeedTracker : Form
    {
        public frmSpeedTracker()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain form = new frmMain();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            bool hourOneBool = false;
            bool hourTwoBool = false;
            bool minOneBool = false;
            bool minTwoBool = false;
            bool secondOneBool = false;
            bool secondTwoBool = false;
            string license = txtLicense.Text;
            int licenseLength = 7;

            txtValid.Text = String.Empty;
            txtSpeed.Text = String.Empty;

            if ((hourOneBool = double.TryParse(txtHourFirst.Text, out double hourOne)) &&
                (hourTwoBool = double.TryParse(txtHourSecond.Text, out double hourTwo)) &&
                (minOneBool = double.TryParse(txtMinFirst.Text, out double minOne)) &&
                (minTwoBool = double.TryParse(txtMinSecond.Text, out double minTwo)) &&
                (secondOneBool = double.TryParse(txtSecondFirst.Text, out double secondOne)) &&
                (secondTwoBool = double.TryParse(txtSecondSecond.Text, out double secondTwo)))
            {
                lblError.Text = String.Empty;
                double hourDiff = 0;
                double minDiff = 0;
                double secondDiff = 0;
                double speedAverage = 0;

                if ((cbAmPmFirst.Text == "AM" || cbAmPmFirst.Text == "PM") &&
                    (cbAmPmSecond.Text == "AM" || cbAmPmSecond.Text == "PM"))
                {
                    if ((cbAmPmFirst.Text != cbAmPmSecond.Text) && 
                        hourTwo != 12)
                    {
                        hourDiff = (hourTwo += 12) - hourOne;
                    }
                    else
                    {
                        hourDiff = hourTwo - hourOne;
                    }

                    minDiff = minTwo - minOne;
                    secondDiff = secondTwo - secondOne;

                    while (hourDiff >= 0 && (minDiff < 0 || secondDiff < 0))
                    {
                        if (minDiff < 0)
                        {
                            minDiff += 60;
                            hourDiff -= 1;
                        }
                        if (secondDiff < 0)
                        {
                            secondDiff += 60;
                            minDiff -= 1;
                        }
                    }

                    speedAverage = 1 / (hourDiff + (minDiff / 60) + (secondDiff / 60 / 60));
                    txtSpeed.Text = Convert.ToString(speedAverage);
                }
                else
                {
                    lblError.Text = "Select AM or PM";
                }

                if ((license.Length != licenseLength) && (license.Length != 0))
                {
                    txtValid.Text = "Invalid";
                    return;
                }
                else if (license.Length == 0)
                {
                    txtValid.Text = String.Empty;
                    return;
                }

                for (int i = 0; i < license.Length; i++)
                {
                    int licenseSeperator = 3;

                    if ((!Char.IsLetterOrDigit(license[i]) && (i != licenseSeperator)) ||
                        (Char.IsLetterOrDigit(license[i]) && i == licenseSeperator))
                    {
                        txtValid.Text = "Invalid";
                        return;
                    }
                }

                txtValid.Text = "Valid";
                return;
            }
            else
            {
                if (!hourOneBool)
                {
                    lblError.Text = "First Time Hour Invalid";
                }
                else if (!hourTwoBool)
                {
                    lblError.Text = "Second Time Hour Invalid";
                }
                else if (!minOneBool)
                {
                    lblError.Text = "First Time Minutes Invalid";
                }
                else if (!minTwoBool)
                {
                    lblError.Text = "Second Time Minutes Invalid";
                }
                else if (!secondOneBool)
                {
                    lblError.Text = "First Time Seconds Invalid";
                }
                else if (!secondTwoBool)
                {
                    lblError.Text = "Second Time Seconds Invalid";
                }
                else
                {
                    lblError.Text = "Invalid Format";
                }
            }
        }
    }
}
