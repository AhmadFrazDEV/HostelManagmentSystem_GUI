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
    public partial class Form2 : Form
    {
        Button mybutton;
        public Form2(string app  , Button mybutton)
        {
            InitializeComponent();
            readapp.Text = app;
            this.mybutton = mybutton;

        }
       

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            mybutton.BackColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
