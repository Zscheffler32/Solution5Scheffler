using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Zach Scheffler
  ITD-2343 Obj-Oriented Programming
  6 June, 2023 */

namespace Project5Scheffler
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxLeft.Text = "";
            txtbxRight.Text = "";
            txtbxCheck.Text = "";
            lblUserMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbxLeft.Text, out int leftNumber) &&
                int.TryParse(txtbxRight.Text, out int rightNumber) &&
                int.TryParse(txtbxCheck.Text, out int targetNumber))

                //This is converting the string text to integer number

            {
                if (targetNumber == leftNumber && targetNumber == rightNumber)
                {
                    lblUserMessage.Text = "The target number is equal to both the lower and upper range limit.";
                    //checks to see if the target number is the same as both the upper and lower limit
                }
                else if (targetNumber == rightNumber)
                {
                    lblUserMessage.Text = "The target number is the same as the upper range limit.";
                    //checks if the target number is equal to the upper limit
                }
                else if (targetNumber == leftNumber)
                {
                    lblUserMessage.Text = "The target number is the same as the lower range limit.";
                    //checks if the target number is equal to the lower limit
                }
                else if (targetNumber < leftNumber)
                {
                    lblUserMessage.Text = "The target number is less than the lower range limit.";
                    //checks to see if the target number is less than lower limit
                }
                else if (targetNumber > rightNumber)
                {
                    lblUserMessage.Text = "The target number is greater than the upper range limit.";
                    //checks to see if the target number is greater than the upper limit
                }
                else if (leftNumber < targetNumber && targetNumber < rightNumber)
                {
                    lblUserMessage.Text = "The target number is between the lower range limit which is:" + leftNumber +
                        @", and the upper range limit which is:" + rightNumber;
                    //checks to see if the target number is between the upper and lower limits
                }
            }
            else
            {
                lblUserMessage.Text = "Invalid input, please re-enter an upper and lower limit, followed by a target number.";
                //if the user inputs anything other than numbers it will throw an error, or if they do not enter numbers it will throw an error
            }
        }

        private void btnCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck_Click(sender, e);
                //if the check button has focus and the user presses enter it will trigger the check event
            }
        }

        private void txtbxCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheck_Click(sender, e);
                //if the text box for the target number has focus and the user presses enter it will trigger the check event
            }
        }
    }
}
