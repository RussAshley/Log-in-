using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace login_example
{
    public partial class displayform : Form
    {

        private LoginDetails detailsToDisplay; //this sets up the details in the LoginDetails object locally- needs to be then 
                                               // encapsulated as a property (highlight, lightbulb, encapsulate. result is line 16 here
                                               // effectively the form now has the proprty of 'detailsToDisplay')
        public LoginDetails DetailsToDisplay { get => detailsToDisplay; set => detailsToDisplay = value; }


        public displayform()
        {
            InitializeComponent();
        }


        public displayform(LoginDetails currentLogin) // creates display form with login data passed in called 'currentLogin')

        {
            InitializeComponent();  // builds components
            this.DetailsToDisplay = currentLogin; // sets detailsToDisplay object equal to current login
            PopulatingFormLabels(); // initiates the function that populates all the labels taken from the instance of the object 
                                             // created in the login form 
        }

        //building a function to populate the form

        public void PopulatingFormLabels()
        {
            userNameLabel.Text = DetailsToDisplay.UserName;
            passwordLabel.Text = DetailsToDisplay.Password;
            dateLabel.Text = DetailsToDisplay.LoginTime.ToString();
        }

    }
}
