using System;
using System.IO;
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
    public partial class AdminForm : Form
    {
        private string path = "Info.txt";
        List<string> application = new List<string>();
        
        int line = 0;
        public static string path_1 = "application.txt";
        public AdminForm()
        {
            InitializeComponent();
            GVpanel.Visible = false;
            updatePanel.Visible = false;
            Inbox.Visible = false;
            merit.Visible = false;
            
        }

        public void dataBind()
        {
            userGV2.DataSource = 1;
            userGV2.DataSource = std_Dl.inforMationList;
            userGV2.Refresh();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            std_Dl.readDataFromFile("Info.txt");
            usersGV.DataSource = std_Dl.inforMationList;
            userGV2.DataSource = std_Dl.inforMationList;
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            std_BL user = (std_BL)usersGV.CurrentRow.DataBoundItem;
       
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
            Inbox.Visible = false;
            merit.Visible = false;
            GVpanel.Visible = true;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            //GVpanel.Visible = false;
            //Inbox.Visible = false;
            //updatePanel.Visible = true;
        }


        private void gunaGradientButton2_Click_1(object sender, EventArgs e)
        {
            GVpanel.Visible = false;
            Inbox.Visible = false;
            merit.Visible = false;
            updatePanel.Visible = true;
        }

        private void userGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                std_BL user1 = (std_BL)userGV2.CurrentRow.DataBoundItem;
                if (userGV2.Columns["Delete"].Index == e.ColumnIndex)
                {
                    std_Dl.deleteUserFromList(user1);
                    std_Dl.storeAllDataIntoFile(path);
                    dataBind();
                }
                else if (userGV2.Columns["Edit"].Index == e.ColumnIndex)
                {
                    EditUserForm myform = new EditUserForm(user1);
                    myform.ShowDialog();
                    std_Dl.storeAllDataIntoFile(path);
                    dataBind();
                }
            
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
            GVpanel.Visible = false;
            merit.Visible = false;
            Inbox.Visible = true;

            string app = "";

            StreamReader file = new StreamReader(path_1);
            while ((app = file.ReadLine()) != null)
            {
                line++;
                application.Add(app);
                
            }

            //MessageBox.Show(line.ToString());
        }

        private void Inbox_Paint(object sender, PaintEventArgs e)
        {
            makeButtons();
        }

        public void ShowBox(string app)
        {
            
           // MessageBox.Show(app);
            
        }

        public void makeButtons()
        {
            int top = 50;
            int left = 200;

            for (int i = 0; i < line; i++)
            {
                
                Button button = new Button();
                button.Text = "Application" + i;
                button.Name = "btn" + i;
                button.Size = new Size(500, 70);
                button.BackColor = Color.Plum;
                button.ForeColor = Color.White;
                button.Font = new Font("Impact", 18);
                button.Left = left;
                button.Top = top;
                Inbox.Controls.Add(button);
                top += button.Height + 2;
                button.Click += new EventHandler(b_Click);
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            for (int i = 0; i < line; i++)
            {
                if (btn.Name == "btn"+i)
                {
                    Form2 newForm = new Form2(application[i] , btn);
                    newForm.ShowDialog();
                    
                    
                }
            }
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton4_Click_1(object sender, EventArgs e)
        {
            GVpanel.Visible = false;
            updatePanel.Visible = false;
            Inbox.Visible = false;
            merit.Visible = true;
        }

        private void merit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
