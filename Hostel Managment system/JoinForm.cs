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
namespace Hostel_Managment_system
{
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
        }

        public void clearDataFromPage()
        {
            gunaLineTextBox1.Text = " ";
            gunaLineTextBox2.Text = " ";
            gunaLineTextBox3.Text = " ";
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form userForm = new loginForm();
            userForm.Show();
            this.Hide();
        }

        private void JoinForm_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            string name = gunaLineTextBox1.Text;
            string password = gunaLineTextBox2.Text;
            string roll = gunaLineTextBox3.Text;
            string path = "data.txt";
            Muser user = new Muser(name, password, roll);
            MuserDL.addList(user);
            MuserDL.storeIntoFile(user, path);
            MessageBox.Show("Add Successfully...");
            clearDataFromPage();
        }
    }
}
