using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment3
{
    public partial class sacda : Form
    {
        public sacda()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //creating a variable 
            string custamename;
            double previouesreading, currentreading, priceperunit,electricityusage,
                electricitycharge,
                Taxamount, totalbill;

            //constant variable
            const double taxtpercentage = 00.7;
            const double fixedcharge = 5;

            //assign variable
            custamename = txtcustomer.Text;
            previouesreading = double.Parse(txtprevious.Text);
            currentreading = double.Parse(txtcurrent.Text);
            priceperunit = double.Parse(txtunitprice.Text);

            //calculating electricity usage
            electricityusage = currentreading - previouesreading;

            // calculating electricity charge
            electricitycharge = electricityusage * priceperunit;

            //calculating   Taxamount
            Taxamount = electricitycharge * taxtpercentage;

            //calculating total bill
            totalbill = electricitycharge + Taxamount + fixedcharge;

            //display results
            lblusage.Text = electricityusage.ToString("0");
            lblamount.Text = "$" + Taxamount.ToString("0.00");
            lbltotal.Text = "$" + totalbill.ToString("0.00");
            







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lbltax_Click(object sender, EventArgs e)
        {
             
        }

        private void txttotal_Click(object sender, EventArgs e)
        {

        }

        private void lbltotal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblusage_Click(object sender, EventArgs e)
        {

        }
    }
}
