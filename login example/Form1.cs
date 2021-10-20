using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginDetails newLogin = new LoginDetails(usernameText.Text, passwordText.Text);       
            
            displayform displayLoginDetails = new displayform(newLogin); // creates new instance of the Display form with newLogin details

            //we need to pass in the LoginDetails object to display on the second form 

           
            displayLoginDetails.Show();
        }
    }
}
