using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal principal;
            double rate;
            int year;
            decimal amount;
            string output;

            principal = Convert.ToDecimal(principalTextbox.Text);
            rate = Convert.ToDouble(InterestRateTextbox.Text);
            year = Convert.ToInt32(yearsTextBox.Value);

            output = "Year\tAmount on Deposit\r\n";

            for(int yearCounter = 1; yearCounter <= year; yearCounter++)
            {
                amount = principal * ( (decimal) Math.Pow(1 + rate / 100, yearCounter));

                output += (yearCounter + "\t" + string.Format("{0:C}", amount) + "\r\n");
            }

            displayTextbox.Text = output;


        }

        
    }
}
