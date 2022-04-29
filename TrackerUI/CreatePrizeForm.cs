using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNameValue.Text,
                    placeNumberValue.Text,
                    prizeAmountValue.Text,
                    prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);
                
                placeNameValue.Text = "";
                placeNumberValue.Text = "";
                prizeAmountValue.Text = "0";
                prizePercentageValue.Text = "0";
            }
            else MessageBox.Show("This form has invalid information. Please check it and try again.");
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            decimal prizeAmount = 0;
            int prizePercentage = 0;

            if (int.TryParse(placeNumberValue.Text, out placeNumber) == false)
                output = false;
            if (placeNumber < 1)
                output = false;

            if (string.IsNullOrEmpty(placeNameValue.Text))
                output = false;

            if (decimal.TryParse(prizeAmountValue.Text, out prizeAmount) == false)
                output = false;
            if (prizeAmount < 0)
                output = false;

            if (int.TryParse(prizePercentageValue.Text, out prizePercentage) == false)
                output = false;
            if (prizePercentage < 0 || prizePercentage > 100)
                output = false;


            return output;
        }
    }
}
