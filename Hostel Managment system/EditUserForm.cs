using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostalManagmentSystem.studentInfoDL;
using HostalManagmentSystem.stdudentInfoBL;
namespace Hostel_Managment_system
{
    public partial class EditUserForm : Form
    {
        private std_BL previous;
        public  EditUserForm(std_BL previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            fname.Text = previous.Fname1;
            fathname.Text = previous.Fathname;
            dobbox.Text = previous.Dob;
            phonbox.Text = previous.PhoneNo;
            addressbox.Text = previous.Address;
            matricbox.Text = previous.MatricMarks;
            fscbox.Text = previous.FscMarks1;
            ecatbox.Text = previous.EcatMarks;

        }

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            std_BL update = new std_BL(fname.Text, fathname.Text, dobbox.Text, phonbox.Text, addressbox.Text, matricbox.Text, fscbox.Text, ecatbox.Text);
            std_Dl.EditUserFromList(previous,update);
            this.Close();
        }
    }
}
