using HostalManagmentSystem.stdudentInfoBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostalManagmentSystem.stdudentInfoBL;
using HostalManagmentSystem.studentInfoDL;

namespace Hostel_Managment_system
{
    public partial class stdForm : Form
    {
        public stdForm()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
         
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
           
            
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //panel3.Visible = false;
            //panel1.Visible = false;
            //appPanel.Visible = true;

        }
        public  void clearData()
        {
            fname.Text = " ";
            fthnme.Text = " ";
            dobbox.Text = " ";
            phonbox.Text = " ";
            addressbox.Text = " ";
            matricbox.Text = " ";
            fscbox.Text = " ";
            ecatbox.Text = " ";
            int count = 1;
            if(count == 1)
            {
                    Label lable = new Label();
                    lable.Text = "Your Application has Been Submittd";
                    lable.AutoSize = true;
                    lable.Font = new Font("Javanese Text", 25);
                    lable.ForeColor = Color.Red;
                    lable.Location = new Point(349, 194);
                    this.Controls.Add(lable);
                count++;
            }
           

        }
        

        private void gunaGradientButton6_Click(object sender, EventArgs e)
        {
            
            string Fname = fname.Text;
            string fathname = fthnme.Text;
            string dob = dobbox.Text;
            string phoneNo = phonbox.Text;
            string address = addressbox.Text;
            string matricMarks = matricbox.Text;
            string FscMarks = fscbox.Text;
            string ecatMarks = ecatbox.Text;
            string aggregate = std_Dl.calculate_Aggregate(FscMarks, ecatMarks);
            std_BL user = new std_BL(Fname, fathname, dob, phoneNo, address, matricMarks, FscMarks, ecatMarks  , aggregate);
            std_Dl.addInformation(user);
            string path = "Info.txt";
            std_Dl.storeIntoFile(user, path);
            MessageBox.Show("your Application is submitted Successfully :)");
            clearData();
            
        }

        private void warning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaGradientButton7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are You Sure You Want To Logout...?");
            Form1 user = new Form1();
            user.Show();
            this.Hide();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dobbox_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void phonbox_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void applicationForm_TextChanged(object sender, EventArgs e)
        {
            
         }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void appPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton8_Click(object sender, EventArgs e)
        {
            string application = applicationForm.Text;
            string pass = applicationTextbox.Text;
            std_Dl.storeApplicationinfile(application, pass);
            MessageBox.Show("Your Application Has Been Sent....WAIT FOR RESPONSE");
            applicationForm.Text = " ";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void stdForm_Load(object sender, EventArgs e)
        {

        }
    }
}
