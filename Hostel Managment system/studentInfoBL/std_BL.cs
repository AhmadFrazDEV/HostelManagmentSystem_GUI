using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalManagmentSystem.stdudentInfoBL
{
    public class  std_BL
    {
        private string Fname;
        private string fathname;
        private string dob;
        private string phoneNo;
        private string address;
        private string matricMarks;
        private string FscMarks;
        private string ecatMarks;
        private string aggregate;


        public std_BL(string Fname, string fathname, string dob, string phoneNo, string address, string matricMarks, string FscMarks, string ecatMarks , string aggregate)
        {
            this.Fname1 = Fname;
            this.Fathname = fathname;
            this.Dob = dob;
            this.PhoneNo = phoneNo;
            this.Address = address;
            this.MatricMarks = matricMarks;
            this.FscMarks1 = FscMarks;
            this.EcatMarks = ecatMarks;
            this.aggregate = aggregate;
        }

        public std_BL(string Fname, string fathname, string dob, string phoneNo, string address, string matricMarks, string FscMarks, string ecatMarks)
        {
            this.Fname1 = Fname;
            this.Fathname = fathname;
            this.Dob = dob;
            this.PhoneNo = phoneNo;
            this.Address = address;
            this.MatricMarks = matricMarks;
            this.FscMarks1 = FscMarks;
            this.EcatMarks = ecatMarks;
        }
        public string Fname1 { get => Fname; set => Fname = value; }
        public string Fathname { get => fathname; set => fathname = value; }
        public string Dob { get => dob; set => dob = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Address { get => address; set => address = value; }
        public string MatricMarks { get => matricMarks; set => matricMarks = value; }
        public string FscMarks1 { get => FscMarks; set => FscMarks = value; }
        public string EcatMarks { get => ecatMarks; set => ecatMarks = value; }
        public string Aggregate { get => aggregate; set => aggregate = value; }
    }
}
