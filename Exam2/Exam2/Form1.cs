using System;
using System.Windows.Forms;


/// <summary>
/// Developer:  Jordan J. Gilmore
/// Date:       10/14/2017
/// FileName:   Form1.cs
/// </summary>
namespace Exam2
{

    public partial class Form1 : Form
    {
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myGambler = new Gambler();
        }
        private void rollBtn_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;

            Slot mySlot1 = new Slot(rand);
            picBx1.Image = mySlot1.Picture;

            Slot mySlot2 = new Slot(rand);
            picBx2.Image = mySlot2.Picture;

            mySlot2 = CheckSlots(mySlot1, mySlot2);

            Slot mySlot3 = new Slot(rand);
            picBx3.Image = mySlot3.Picture;

           // MessageBox.Show(mySlot1.RandValue.ToString() + mySlot2.RandValue.ToString() + mySlot3.RandValue.ToString(), "Title");
            //Game logic
            //JackPot if statement
            if (mySlot1.RandValue == 0 && mySlot2.RandValue == 0 && mySlot3.RandValue == 0)
            {
                MessageBox.Show("You got the Jackpot! 100 cash add to you.", "Jackpot");
                lblMessage.Text = "Holy cow stranger, You ain't cheatin' are ya?";
                myGambler.Cash += 100;
                txtBtnCurrentCash.Text = myGambler.Cash.ToString();
                myGambler.Gain += 100;
                txtBtnGain.Text = myGambler.Gain.ToString();

            }
            // Three of a kind
            else if (mySlot1.PictureValue == mySlot2.PictureValue &&
                        mySlot2.PictureValue == mySlot3.PictureValue)
            {
                lblMessage.Text = "Wouldn't be feeling generous, would ya...Stranger? " +
                            "\n* 1.00 Added to Cash *";
                myGambler.Cash += 1.00;
                txtBtnCurrentCash.Text = myGambler.Cash.ToString();
                myGambler.Gain += 1.00;
                txtBtnGain.Text = myGambler.Gain.ToString();
            }
            //Two of a kind
            else if (mySlot1.PictureValue == mySlot2.PictureValue ||
                mySlot2.PictureValue == mySlot3.PictureValue ||
                mySlot1.PictureValue == mySlot3.PictureValue)
            {
                lblMessage.Text = "Not bad stranger, here's a nickel \n* 0.05 Added to Cash *";
                myGambler.Cash += .10;
                txtBtnCurrentCash.Text = myGambler.Cash.ToString();
                myGambler.Gain += .10;
                txtBtnGain.Text = myGambler.Gain.ToString();
            }
            // Complete Failure 
            else
            {
                lblMessage.Text = "Better luck next time stranger... \n* 1.50 Deducted from Cash *";
                myGambler.Cash -= 1.00;
                txtBtnCurrentCash.Text = myGambler.Cash.ToString();
                myGambler.Loss -= 1.00;
                txtBtnLoss.Text = myGambler.Loss.ToString();
            }
            //Losing Screen. Closes form
            if (myGambler.Cash < 0.10)
            {
                lblMessage.Text = "Hehe.... See ya, stranger";
                MessageBox.Show("Not enough cash, Stranger! Comeback again.", "Losing Screen");
                Close();
            }
        }

        public Slot CheckSlots(Slot slot1, Slot slot2)
        {
            if (slot1.PictureValue == slot2.PictureValue)
            {
                slot2 = new Slot(rand);
                picBx2.Image = slot2.Picture;
            }
            return slot2;
        }
        /// <summary>
        /// Initialization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gamblerBtn_Click(object sender, EventArgs e)
        {
            double userValue;
            if (txtBtnStarting.Text == "" || Convert.ToDouble(txtBtnStarting.Text) < 0.10
                                || Convert.ToDouble(txtBtnStarting.Text) > 10.0)
            {
                MessageBox.Show("Please Enter in a value between $0.10 & $10.00", "Gambler Error");
            }
            else
            {
                //Disabling Gambler Panel
                startPanel.Visible = false;
                startPanel.Enabled = false;

                // Starting Gambler
                userValue = Convert.ToDouble(txtBtnStarting.Text);
                myGambler.Cash = userValue;
                myGambler.StartingCash = userValue;
                // Enabling StatusPanel
                statsPanel.Enabled = true;
                statsPanel.Visible = true;
                txtBtnStartingCash.Text = myGambler.StartingCash.ToString();
                txtBtnCurrentCash.Text = myGambler.Cash.ToString();
                txtBtnGain.Text = myGambler.Gain.ToString();
                txtBtnLoss.Text = myGambler.Loss.ToString();
                // Enabling Roll Button
                rollBtn.Enabled = true;
                rollBtn.Visible = true;
                //PictureBoxes
                picBx1.Enabled = true;
                picBx1.Visible = true;
                picBx2.Enabled = true;
                picBx2.Visible = true;
                picBx3.Enabled = true;
                picBx3.Visible = true;

            }
        }

       
    }
}
