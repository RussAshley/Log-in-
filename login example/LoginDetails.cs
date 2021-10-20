using System;
using System.Collections.Generic;
using System.Text;

namespace login_example
{
     public class LoginDetails
    {
        private string userName;
        private string password;
        private DateTime loginTime;

        public LoginDetails(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.loginTime = DateTime.Now;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public DateTime LoginTime { get => loginTime; set => loginTime = value; }
    }
}
