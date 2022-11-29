using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SashaHeyburgh_19336832_GADE5111
{
    public partial class LandSimulator : Form
    {
        public int randomNumber;                                        //variable initialization
        int[] generatedMana = new int[Constant.colourNumbers];
        int[] tappedManaPool = new int[Constant.colourNumbers];
        List<string> colours = new List<string>() {" White Mana", " Black Mana", " Red Mana", " Blue Mana", " Green Mana"};

        public static class Constant
        {
            public const int colourNumbers = 5;                             //constant declaration
        }

        public LandSimulator()
        {
            InitializeComponent();
        }

        private void LandSimulator_Load(object sender, EventArgs e)
        {
            int[] generatedMana = new int[Constant.colourNumbers];          //array initialization
            int[] tappedManaPool = new int[Constant.colourNumbers];
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Random numberColours = new Random();
            randomNumber = numberColours.Next(Constant.colourNumbers + 1);          //randomization

            DoSwitch();                                             //calling the switch function
        }

        private void DoSwitch()                         //switch function for the mana colour pool
        {
            switch(randomNumber)
            {
                case 0:

                    lblWhite.Text = (generatedMana[0] += 1) + " White Mana";                  
                    break;

                case 1:

                    lblBlack.Text = (generatedMana[1] += 1) + " Black Mana";
                    break;

                case 2:

                    lblRed.Text = (generatedMana[2] += 1) + " Red Mana";
                    break;

                case 3:

                    lblBlue.Text = (generatedMana[3] += 1) + " Blue Mana";
                    break;

                case 4:

                    lblGreen.Text = (generatedMana[4] += 1) + " Green Mana";
                    break;

                case 5:

                    lblOutput.Text = "You drew a creature. No mana was added to the pool";
                    break;

                default:
                    break;
            }
        }

        private void btnTap2_Click(object sender, EventArgs e)          //black mana tap button
        {
            if (generatedMana[1] == 0)
            {
                lblTapped.Text = "Tapped Land: \r\n There is no mana to use";
            }
            else
            {
                lblBlack.Text = (generatedMana[1] -= 1) + " Black Mana";
                tappedManaPool[1] += 1;                                                             //moving generatedMana array values to tappedManaPool array
                lblOutput.Text = "You have used one black mana";
                lblTapped.Text = "Tapped Land: ";
            }

            if (tappedManaPool[1] == 0)
            {
                //nothing
            }
            else
            {
                for (int i = 0; i < 5; i++)                                                                         //looping through the tappedManaPool array
                    if (tappedManaPool[i] == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        lblTapped.Text = lblTapped.Text + "\r\n" + tappedManaPool[i] + " " + colours[i];            //adding colours to the Tapped Land label
                    }
            }
        }

        private void btnTap1_Click_1(object sender, EventArgs e)            //white mana tap button
        {
            if (generatedMana[0] == 0)
            {
                lblTapped.Text = "Tapped Land: \r\n There is no mana to use";
            }
            else
            {
                lblWhite.Text = (generatedMana[0] -= 1) + " White Mana";
                tappedManaPool[0] += 1;                                                             //moving generatedMana array values to tappedManaPool array
                lblOutput.Text = "You have used one white mana";
                lblTapped.Text = "Tapped Land: ";
            }

            if (tappedManaPool[0] == 0)
            {
                //nothing
            }
            else
            {
                for (int i = 0; i < 5; i++)                                                                         //looping through the tappedManaPool array
                    if (tappedManaPool[i] == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        lblTapped.Text = lblTapped.Text + "\r\n" + tappedManaPool[i] + " " + colours[i];            //adding colours to the Tapped Land label
                    }
            }
        }

        private void btnTap3_Click(object sender, EventArgs e)          //red mana tap button
        {
            if (generatedMana[2] == 0)
            {
                lblTapped.Text = "Tapped Land: \r\n There is no mana to use";
            }
            else
            {
                lblRed.Text = (generatedMana[2] -= 1) + " Red Mana";
                tappedManaPool[2] += 1;                                                             //moving generatedMana array values to tappedManaPool array
                lblOutput.Text = "You have used one red mana";
                lblTapped.Text = "Tapped Land: ";
            }

            if (tappedManaPool[2] == 0)
            {
                //nothing
            }
            else
            {
                for (int i = 0; i < 5; i++)                                                                         //looping through the tappedManaPool array
                    if (tappedManaPool[i] == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        lblTapped.Text = lblTapped.Text + "\r\n" + tappedManaPool[i] + " " + colours[i];            //adding colours to the Tapped Land label
                    }
            }
        }

        private void btnTap4_Click(object sender, EventArgs e)          //blue mana tap button
        {
            if (generatedMana[3] == 0)
            {
                lblTapped.Text = "Tapped Land: \r\n There is no mana to use";
            }
            else
            {
                lblBlue.Text = (generatedMana[3] -= 1) + " Blue Mana";
                tappedManaPool[3] += 1;                                                             //moving generatedMana array values to tappedManaPool array
                lblOutput.Text = "You have used one blue mana";
                lblTapped.Text = "Tapped Land: ";
            }

            if (tappedManaPool[3] == 0)
            {
                //nothing
            }
            else
            {
                for (int i = 0; i < 5; i++)                                                                         //looping through the tappedManaPool array
                    if (tappedManaPool[i] == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        lblTapped.Text = lblTapped.Text + "\r\n" + tappedManaPool[i] + " " + colours[i];            //adding colours to the Tapped Land label
                    }
            }
        }

        private void btnTap5_Click(object sender, EventArgs e)          //green mana tap button
        {
            if (generatedMana[4] == 0)
            {
                lblTapped.Text = "Tapped Land: \r\n There is no mana to use";
            }
            else
            {
                lblGreen.Text = (generatedMana[4] -= 1) + " Green Mana";
                tappedManaPool[4] += 1;                                                             //moving generatedMana array values to tappedManaPool array
                lblOutput.Text = "You have used one green mana";
                lblTapped.Text = "Tapped Land: ";
            }

            if (tappedManaPool[4] == 0)
            {
                //nothing
            }
            else
            {
                for (int i = 0; i < 5; i++)                                                                         //looping through the tappedManaPool array
                    if (tappedManaPool[i] == 0)
                    {
                        //nothing
                    }
                    else
                    {
                        lblTapped.Text = lblTapped.Text + "\r\n" + tappedManaPool[i] + " " + colours[i];            //adding colours to the Tapped Land label
                    }
            }
        }

        private void btnUntap_Click(object sender, EventArgs e)                                 //moving tapped mana array values back to generated mana array
        {
            lblWhite.Text = generatedMana[0] + tappedManaPool[0] + " White Mana";
            generatedMana[0] += tappedManaPool[0];

            lblBlack.Text = generatedMana[1] + tappedManaPool[1] + " Black Mana";
            generatedMana[1] += tappedManaPool[1];

            lblRed.Text = generatedMana[2] + tappedManaPool[2] + " Red Mana";
            generatedMana[2] += tappedManaPool[2];

            lblBlue.Text = generatedMana[3] + tappedManaPool[3] + " Blue Mana";
            generatedMana[3] += tappedManaPool[3];

            lblGreen.Text = generatedMana[4] + tappedManaPool[4] + " Green Mana";
            generatedMana[4] += tappedManaPool[4];

            Array.Clear(tappedManaPool, 0, tappedManaPool.Length);
            lblTapped.Text = "Tapped Land: \r\n You have untapped all your land";
        }
    }
}
