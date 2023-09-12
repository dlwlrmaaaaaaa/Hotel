using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brew
{   
    public partial class Form1 : Form
    {
        public string accomodation;
        public int total;
        public double discount;
        public int amountdue;
        public string roomDisc;
        public bool DisableDiscount = true;
        public Form1()
        {
            InitializeComponent();
        }
        public void Disabled()
        {
            cmdStandard.Enabled = false;
            cmdEconomy.Enabled = false; 
            cmdDeluxe.Enabled = false;  
            cmdExecutive.Enabled = false;


            //Disabled Permanently
            tBAmountDue.Enabled = false;
            tBDiscount.Enabled = false;
            tBTotalAmount.Enabled = false;
        }
        public void DisableDiscounts()
        {
            cmdNew.Enabled = false;
            cmdSenior.Enabled = false;
            cmdVIP.Enabled = false;
            cmdPWD.Enabled = false;
            cmdRegular.Enabled = false;
        }
        public void EnableDiscounts()
        {
            cmdNew.Enabled = true;
            cmdSenior.Enabled = true;
            cmdVIP.Enabled = true;
            cmdPWD.Enabled = true;
            cmdRegular.Enabled = true;
        }
        public void Unchecked()
        {
            cmdStandard.Checked = false;
            cmdEconomy.Checked = false;
            cmdDeluxe.Checked = false;
            cmdExecutive.Enabled = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
  

            if (DisableDiscount)
            {
                DisableDiscounts();
            }
            else
            {
                EnableDiscounts();
            }

            if (!string.IsNullOrWhiteSpace(tBName.Text) || !string.IsNullOrEmpty(tBName.Text))
            {
                EnableRadioButtons();
            }
            else
            {
                Disabled();
            }

        }



        private void gBAccomodation_Enter(object sender, EventArgs e)
        {
            cmdNew.Enabled = true;
            cmdSenior.Enabled = true;
            cmdVIP.Enabled = true;
            cmdPWD.Enabled = true;
            cmdRegular.Enabled = true;
        }
        public void StringToInt()
        {
            //Declaring str to TbTotalAmount
            String str = tBTotalAmount.Text;
            //Replacing dollar string into empty string, para maging number na lang
            String replaced = str.Replace("$", ""); 
            //Since number na lang pwede na natin ma convert into Integer
            int amount = int.Parse(replaced);
            //Getting the discount
            double discountTotal = amount * discount;
            //Displaying discount in input
            tBDiscount.Text = "$" + discountTotal.ToString();
            //Calculating the total
            int intDiscount = Convert.ToInt32(discountTotal);
            total = amount - intDiscount;
            tBAmountDue.Text = "$" + total;
        }
        private void cmdStandard_CheckedChanged(object sender, EventArgs e)
        {

            tBTotalAmount.Text = "$400";
            StringToInt();
            accomodation = "Standard";
        }

        private void cmdEconomy_CheckedChanged(object sender, EventArgs e)
        {
            tBTotalAmount.Text = "$300";
            StringToInt();
            accomodation = "Economy";

        }

        private void cmdDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            tBTotalAmount.Text = "$850";
            StringToInt();
            accomodation = "DeLuxe";
 
        }

        private void cmdExecutive_CheckedChanged(object sender, EventArgs e)
        {
            tBTotalAmount.Text = "$1000";
            StringToInt();
            accomodation = "Executive";
            
        }

        private void cmdNew_CheckedChanged(object sender, EventArgs e)
        {
            tBDiscount.Text = "$0";
            discount = 0;
            StringToInt();
            roomDisc = "New Customer";
        }

        private void cmdRegular_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.05;
            StringToInt();
            roomDisc = "Regular";
        }

        private void cmdSenior_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.2;
            StringToInt();
            roomDisc = "Senior Citizen";
        }

        private void cmdPWD_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.2;
            StringToInt();
            roomDisc = "PWD";
        }

        private void cmdVIP_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.4;
            StringToInt();
            roomDisc = "VIP";
        }
        public void fillUpInfo()
        {
            
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBPayment.Text)) {
                return;
            }
               
            int payment = int.Parse(tBPayment.Text);
            int change = payment - total;

            if (string.IsNullOrEmpty(tBContact.Text) || string.IsNullOrEmpty(tBName.Text))
            {
                MessageBox.Show("Please complete information before you pay!");
            }else if (payment < total)
            {
                MessageBox.Show("Ipon ka muna pera! :)");
            }
            else
            {
                MessageBox.Show(
                    "Hotel" + "\n\n" +
                    "Name\t\t\t: " + tBName.Text + "\n" +
                    "Contact\t\t\t: " + tBContact.Text + "\n" +
                    "Pax\t\t\t: " + upPax.Value + "\n" +
                    "Room Accomodation\t: " + accomodation + "\n" +
                    "Room Discount\t\t: " + roomDisc + "\n" +
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\n" +
                    "Total Amount\t\t: " + tBPayment.Text + "\n" +
                    "Total Discount\t\t: " + tBDiscount.Text + "\n" +
                    "Amount Due\t\t: " + tBAmountDue.Text + "\n\n" +
                    "Payment\t\t\t: $" + payment + "\n" +
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\n" +
                    "Change\t\t\t: $" + change
                                );
            }
        }
        private void EnableRadioButtons()
        {
            cmdEconomy.Enabled = true;
            cmdDeluxe.Enabled = true;
            cmdExecutive.Enabled = true;
            cmdStandard.Enabled = true;
        }
        private void nameKeypressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b') // '\b' is for backspace
            {
                e.Handled = true; // Discard the keypress if it's not a string character or space
            }
            Name += tBName.Text;
        }

        private void contactKeypressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }
        private void tBName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tBName.Text))
            {
                EnableRadioButtons();
                DisableDiscount = false;
            }
            else
            {         
                Disabled();
                Unchecked();
            }
        }

        private void Payment_Pressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form1_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

 
    }
}
