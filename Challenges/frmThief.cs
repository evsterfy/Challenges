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
    public partial class frmThief : Form
    {
        public frmThief()
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
            lblError.Text = String.Empty;
            listCombos.Items.Clear();
            string input = txtDigits.Text;
            var output = listCombos.Items;
            string combo = String.Empty;
            int i = 0;
            int j = 0;
            int k = 0;
            int p = 0;
            int n = 0;

            if (input.Length > 5 || !int.TryParse(input, out int digits))
            {
                lblError.Text = "Invalid Input";
                return;
            }

            if (input.Length <= 5)
            {
                for (i = 0; i < input.Length; i++)
                {
                    combo = String.Empty;

                    combo += input[i];

                    if (input.Length >= 2)
                    {
                        for (j = 0; j < input.Length; j++)
                        {
                            if (j != i)
                            {
                                combo += input[j];

                                if (input.Length >= 3)
                                {
                                    for (k = 0; k < input.Length; k++)
                                    {
                                        if (k != i && k != j)
                                        {
                                            combo += input[k];

                                            if (input.Length >= 4)
                                            {
                                                for (p = 0; p < input.Length; p++)
                                                {
                                                    if (p != i && p != j && p != k)
                                                    {
                                                        combo += input[p];

                                                        if (input.Length == 5)
                                                        {
                                                            for (n = 0; n < input.Length; n++)
                                                            {
                                                                if (n != i && n != j && n != k && n != p)
                                                                {
                                                                    combo += input[n];

                                                                    if (combo.Length == input.Length &&
                                                                        listCombos.FindStringExact(combo) < 0)
                                                                    {
                                                                        output.Add(combo);
                                                                    }

                                                                    combo = combo.Remove(4, 1);
                                                                }
                                                            }
                                                        }

                                                        if (combo.Length == input.Length &&
                                                            listCombos.FindStringExact(combo) < 0)
                                                        {
                                                            output.Add(combo);
                                                        }

                                                        combo = combo.Remove(3, 1);
                                                    }
                                                }
                                            }

                                            if (combo.Length == input.Length &&
                                                listCombos.FindStringExact(combo) < 0)
                                            {
                                                output.Add(combo);
                                            }

                                            combo = combo.Remove(2, 1);
                                        }
                                    }
                                }

                                if (combo.Length == input.Length &&
                                    listCombos.FindStringExact(combo) < 0)
                                {
                                    output.Add(combo);
                                }

                                combo = combo.Remove(1, 1);
                            }
                        }
                    }

                    if (combo.Length == input.Length &&
                        listCombos.FindStringExact(combo) < 0)
                    {
                        output.Add(combo);
                    }

                    combo = combo.Remove(0, 1);
                }
            }

            lblCount.Text = output.Count.ToString() + " Combinations";
        }

    }
}
