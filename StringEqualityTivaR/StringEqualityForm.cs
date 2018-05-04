using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 02-05-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - String Equality
 * This program allows the user to enter two numbers and then compares...
 * ... them in uppercase and lowercase to see if they are the same.
*/

namespace StringEqualityTivaR
{
    public partial class frmStringEquality : Form
    {
        string wordOne, wordTwo;

        public frmStringEquality()
        {
            InitializeComponent();
            lblStringsEqualAns.Hide();
        }

        // Procedure: StringsAreEqual
        // Input: stringOne and stringTwo
        // Output: bool isEqual
        // Description: It checks to see if the strings are equal in length...
        // ... and when they are both capitalized
        private bool StringsAreEqual ()
        {
            // Declare local Variables
            bool isEqual = false;
            string upcaseWordOne, upcaseWordTwo;

            // To find their length
            if (wordOne.Length == wordTwo.Length )
            {
                // Convert the strings to upper case and then compare them
                upcaseWordOne = wordOne.ToUpper();
                upcaseWordTwo = wordTwo.ToUpper();

                // See if they are the same still
                if (upcaseWordOne == upcaseWordTwo)
                {
                    // If they are the same set the boolean to true
                    isEqual = true;
                }

            }


            return isEqual;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Define local variables
            bool areSame;
            // Get the strings from the boxes
            wordOne = (this.txtString1.Text);
            wordTwo = (this.txtString2.Text);

            // Call on the procedure
            areSame = StringsAreEqual();

            // To show user if strings are the same 
            if (areSame == true)
            {
                lblStringsEqualAns.Show();
                lblStringsEqualAns.Text = ("These strings are equal.");
            }
            else
            {
                lblStringsEqualAns.Show();
                lblStringsEqualAns.Text = ("These strings are NOT equal!");
            }
        }
    }
}
