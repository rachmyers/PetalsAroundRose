/* Developer: Rachel Myers
 * Date: 8/27/2020
 * Project: Petals Around the Rose
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetalsAroundRose
{
    public partial class Form1 : Form
    {
        private int count = 0;
        private int guess = 0;
        private int currentResult = 0;
        private int bestRun = 0;
        private int correctCount = 0;
        private int wrongCount = 0;

        

        public Form1()
        {
            InitializeComponent();

        }



        public void init()
        {
            //Reset all fields
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;

            lblWrongNum.Text = "0";
            lblCorrectNum.Text = "0";
            lblBestNum.Text = "0";
        }

        private void txtBxGuessScore_TextChanged(object sender, EventArgs e)
        {

            //check if textbox is empty to prevent crashing on backspace
            if (string.IsNullOrEmpty(txtBxGuessScore.Text))
            {
                return;
            } 
           
            //guess = Convert.ToInt32(txtBxGuessScore.Text);

            



        }

        private void btRollDice_Click(object sender, EventArgs e)
        {
            //reset the currentResult variable
            currentResult = 0;

            //clear any error messages
            lblErrorMessage.Visible = false;

            //enable Guess Score text box
            txtBxGuessScore.Enabled = true;

            txtBxGuessScore.Text = ""; //clear the guess text box

            int[] rndArray = CreateRandomNum();

            AssignImage(img1, rndArray[0]);
            AssignImage(img2, rndArray[1]);
            AssignImage(img3, rndArray[2]);
            AssignImage(img4, rndArray[3]);
            AssignImage(img5, rndArray[4]);
            AssignImage(img6, rndArray[5]);

            btSubmitGuess.Enabled = true;
        }

        public int[] CreateRandomNum()
        {
            Random rnd = new Random(); //create new instance of Random class

            int[] rndArray = new int[6]; //create an int array to hold 6 ints
            int rndNumber;

            for(int i = 0; i < 6; i++)
            {
                rndNumber = rnd.Next(1, 6);
                rndArray[i] = rndNumber;

                if (rndNumber == 3)
                {
                    currentResult += 2;
                }

                if (rndNumber == 5)
                {
                    currentResult += 4;
                }
            }

            return rndArray;

        }


        public void AssignImage(PictureBox picture, int number)
        {
            switch(number)
            {
                case 1:
                    picture.Image = Properties.Resources._1;
                    break;
                case 2:
                    picture.Image = Properties.Resources._2;
                    break;
                case 3:
                    picture.Image = Properties.Resources._3;
                    break;
                case 4:
                    picture.Image = Properties.Resources._4;
                    break;
                case 5:
                    picture.Image = Properties.Resources._5;
                    break;
                case 6:
                    picture.Image = Properties.Resources._6;
                    break;
                default:
                    break;
            }
        }

        private void btSubmitGuess_Click(object sender, EventArgs e)
        {
            btSubmitGuess.Enabled = false; //prevent users from clicking twice
            txtBxGuessScore.Enabled = false; //disable Guess text box
            count++; //increment the count

            //while users have not entered an integer, display error message
            if (int.TryParse(txtBxGuessScore.Text, out guess) == false ||
               guess < 0)
            {
                lblErrorMessage.Text = "Please enter a postive whole number";
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = true;
                txtBxGuessScore.Text = "";
                btSubmitGuess.Enabled = true; //allow users to enter new value
                txtBxGuessScore.Enabled = true; 
                return;
            }

            if (guess == currentResult)
            {
                //if answer is correct, display correct text
                //and increment correct count and best run count
                lblResult.Text = "Correct!!!";
                lblResult.ForeColor = Color.Green;
                correctCount++;
                lblCorrectNum.Text = correctCount.ToString();
                bestRun++;
                lblBestNum.Text = bestRun.ToString();
            }
            else
            {
                //if answer is wrong, display wrong answer message
                //and reset bestRun and increment wrong answer count
                lblResult.Text = "Wrong answer! You answered "
                    + guess + "\r\nThe correct answer is" +
                    currentResult;
                lblResult.ForeColor = Color.Red;
                wrongCount++;
                lblWrongNum.Text = wrongCount.ToString();
                bestRun = 0;
                lblBestNum.Text = bestRun.ToString();
            }

            
        }

    }
}
