using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostalManagmentSystem.BL;
using HostalManagmentSystem.DL;
using HostalManagmentSystem.stdudentInfoBL;
using HostalManagmentSystem.studentInfoDL;
namespace Hostel_Managment_system
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        public void clearDataFromPage()
        {
            gunaLineTextBox1.Text = " ";
            gunaLineTextBox2.Text = " ";
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            string name = gunaLineTextBox1.Text;
            string password = gunaLineTextBox2.Text;
            string roll = gunaComboBox1.Text;
            Muser user = new Muser(name, password , roll);
            bool valid = MuserDL.signIn(user);

            if (user.getRoll() == "Admin" )
            {
                if (valid)
                {
                    MessageBox.Show("User is Valid");

                    AdminForm admin = new AdminForm();
                    admin.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("invalid User");
                
            }
            if(user.getRoll() == "Student" )
            {
                if (valid)
                {
                    MessageBox.Show("User is Valid");
                    stdForm userForm = new stdForm();
                    userForm.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("invalid User");
            }
           
            clearDataFromPage();
        }
    }
}
