using HostalManagmentSystem.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = "data.txt";


            if (MuserDL.readDataFromFile(path))
            {
                //Form2 startingForm = new Form2();
                //startingForm.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Fail:(");
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Form userForm = new JoinForm();
            userForm.Show();
            this.Hide();
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            Form userForm = new loginForm();
            userForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
