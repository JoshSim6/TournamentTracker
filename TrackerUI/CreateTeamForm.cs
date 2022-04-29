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

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel model = new PersonModel(
                    firstNameValue.Text,
                    lastNameValue.Text,
                    emailValue.Text,
                    cellPhoneValue.Text);

                GlobalConfig.Connection.CreatePerson(model);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }

            else
                MessageBox.Show("You need to fill in all the fields properly");
            
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (String.IsNullOrWhiteSpace(firstNameValue.Text))
                output = false;
            if (String.IsNullOrWhiteSpace(lastNameValue.Text))
                output = false;
            if (String.IsNullOrWhiteSpace(emailValue.Text) || !emailValue.Text.Contains("@"))
            {
                MessageBox.Show("Your email is missing an '@' symbol");
                output = false;
            }

            return output;
        }
    }
}
