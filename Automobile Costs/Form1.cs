using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile_Costs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double loan = double.Parse(loanTextBox.Text); //gets input
            double insurance = double.Parse(insTextBox.Text);
            double gas = double.Parse(gasTextBox.Text);
            double oil = double.Parse(oilTextBox.Text);
            double tires = double.Parse(tiresTextBox.Text);
            double maintenance = double.Parse(maintenanceTextBox.Text);

            double monthly = loan + insurance + gas + oil + tires + maintenance; //calculates totals
            double annual = monthly * 12;

            outputLabel.Text = monthly.ToString("c"); //displays output
            annualOutput.Text = annual.ToString("c");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            loanTextBox.Text = ""; //clears textboxes
            insTextBox.Text = "";
            gasTextBox.Text = "";
            oilTextBox.Text = "";
            tiresTextBox.Text = "";
            maintenanceTextBox.Text = "";

            outputLabel.Text = "";   //clears output labels
            annualOutput.Text = "";
        }
    }
}
