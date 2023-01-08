using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManagmentSystem.BL
{
    class Muser
    {
        private string userName;
        private string password;
        private string roll;

        public string getName() { return userName; }
        public string getPassword() { return password; }
        public string getRoll() { return roll; }



        public Muser(string userName, string password, string roll)
        {
            this.userName = userName;
            this.password = password;
            this.roll = roll;
        }
        public Muser(string userName, string password)
        {
            this.userName = userName;
            this.password = password;

        }
    }
}
