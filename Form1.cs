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
        public Form1()
        {
            InitializeComponent();
        }
        public void Disabled()
        {
            cmdStandard.Enabled = false;
            cmdRegular.Enabled = false; 
            cmdEconomy.Enabled = false; 
            cmdDeluxe.Enabled = false;  
            cmdExecutive.Enabled = false;
            cmdNew.Enabled = false;
            cmdSenior.Enabled = false;
            cmdVIP.Enabled = false;
            cmdPWD.Enabled = false;

            //Disabled Permanently
            tBAmountDue.Enabled = false;
            tBDiscount.Enabled = false;
            tBTotalAmount.Enabled = false;
        }
        public void DisabledInteger()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Disabled();
        }

        private void tBName_TextChanged(object sender, EventArgs e)
        {
            cmdEconomy.Enabled = true;
            cmdDeluxe.Enabled = true;
            cmdExecutive.Enabled = true;
            cmdStandard.Enabled = true;
        }

        private void tBContact_TextChanged(object sender, EventArgs e)
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
        }

        private void contactKeypressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
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
        }

        private void cmdDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            tBTotalAmount.Text = "$850";
            StringToInt();
        }

        private void cmdExecutive_CheckedChanged(object sender, EventArgs e)
        {
            tBTotalAmount.Text = "$1000";
            StringToInt();
        }

        private void cmdNew_CheckedChanged(object sender, EventArgs e)
        {
            tBDiscount.Text = "$0";
            StringToInt();
        }

        private void cmdRegular_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.05;
            StringToInt();
        }

        private void cmdSenior_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.2;
            StringToInt();
        }

        private void cmdPWD_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.2;
            StringToInt();
        }

        private void cmdVIP_CheckedChanged(object sender, EventArgs e)
        {
            discount = 0.4;
            StringToInt();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int payment = int.Parse(tBPayment.Text);
            if (payment < total)
            {
                MessageBox.Show("Ipon ka muna pera! :)");
            }
            else
            {
                MessageBox.Show(
                    "Name\t: " + tBName.Text +
                    "Contact\t: " + tBContact.Text +
                    "Age\t: " + updAge.Value +
                    "Pax\t: " + upPax.Value +
                    "Accomodation\t: "+cmd  +
                    "" +
                    "" +
                    "" +
                    "");
            }
        }
    }
}
