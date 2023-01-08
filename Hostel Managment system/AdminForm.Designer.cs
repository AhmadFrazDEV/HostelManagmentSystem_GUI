namespace Hostel_Managment_system
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GVpanel = new System.Windows.Forms.Panel();
            this.meritlist = new System.Windows.Forms.Panel();
            this.usersGV = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.userGV2 = new Guna.UI.WinForms.GunaDataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.Inbox = new System.Windows.Forms.Panel();
            this.merit = new System.Windows.Forms.Panel();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.GVpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).BeginInit();
            this.updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.Animated = true;
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(18, 223);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 20;
            this.gunaGradientButton1.Size = new System.Drawing.Size(204, 75);
            this.gunaGradientButton1.TabIndex = 5;
            this.gunaGradientButton1.Text = "View Applicants";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 286);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 65);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to Admin site";
            // 
            // GVpanel
            // 
            this.GVpanel.Controls.Add(this.meritlist);
            this.GVpanel.Controls.Add(this.usersGV);
            this.GVpanel.Location = new System.Drawing.Point(231, 2);
            this.GVpanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GVpanel.Name = "GVpanel";
            this.GVpanel.Size = new System.Drawing.Size(1233, 800);
            this.GVpanel.TabIndex = 7;
            // 
            // meritlist
            // 
            this.meritlist.Location = new System.Drawing.Point(0, 0);
            this.meritlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.meritlist.Name = "meritlist";
            this.meritlist.Size = new System.Drawing.Size(1233, 800);
            this.meritlist.TabIndex = 10;
            // 
            // usersGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.usersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGV.BackgroundColor = System.Drawing.Color.White;
            this.usersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersGV.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.usersGV.EnableHeadersVisualStyles = false;
            this.usersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usersGV.Location = new System.Drawing.Point(4, 0);
            this.usersGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usersGV.Name = "usersGV";
            this.usersGV.RowHeadersVisible = false;
            this.usersGV.RowHeadersWidth = 62;
            this.usersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGV.Size = new System.Drawing.Size(1234, 720);
            this.usersGV.TabIndex = 0;
            this.usersGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.usersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.usersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.usersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.usersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.usersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.usersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.usersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.usersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.usersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.usersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.usersGV.ThemeStyle.HeaderStyle.Height = 21;
            this.usersGV.ThemeStyle.ReadOnly = false;
            this.usersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.usersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.usersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.usersGV.ThemeStyle.RowsStyle.Height = 22;
            this.usersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.usersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.usersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGV_CellContentClick);
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.Animated = true;
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = null;
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(18, 308);
            this.gunaGradientButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Radius = 20;
            this.gunaGradientButton2.Size = new System.Drawing.Size(204, 75);
            this.gunaGradientButton2.TabIndex = 8;
            this.gunaGradientButton2.Text = "Update";
            this.gunaGradientButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton2.Click += new System.EventHandler(this.gunaGradientButton2_Click_1);
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.userGV2);
            this.updatePanel.Location = new System.Drawing.Point(232, 2);
            this.updatePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(1233, 800);
            this.updatePanel.TabIndex = 8;
            // 
            // userGV2
            // 
            this.userGV2.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.userGV2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.userGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGV2.BackgroundColor = System.Drawing.Color.White;
            this.userGV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGV2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userGV2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userGV2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.userGV2.ColumnHeadersHeight = 21;
            this.userGV2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userGV2.DefaultCellStyle = dataGridViewCellStyle6;
            this.userGV2.EnableHeadersVisualStyles = false;
            this.userGV2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGV2.Location = new System.Drawing.Point(0, 17);
            this.userGV2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.userGV2.Name = "userGV2";
            this.userGV2.RowHeadersVisible = false;
            this.userGV2.RowHeadersWidth = 62;
            this.userGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGV2.Size = new System.Drawing.Size(1224, 703);
            this.userGV2.TabIndex = 0;
            this.userGV2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.userGV2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.userGV2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.userGV2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.userGV2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.userGV2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.userGV2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.userGV2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGV2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.userGV2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.userGV2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userGV2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.userGV2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.userGV2.ThemeStyle.HeaderStyle.Height = 21;
            this.userGV2.ThemeStyle.ReadOnly = false;
            this.userGV2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.userGV2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.userGV2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.userGV2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGV2.ThemeStyle.RowsStyle.Height = 22;
            this.userGV2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.userGV2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.userGV2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGV2_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.Animated = true;
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = null;
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton3.Location = new System.Drawing.Point(18, 392);
            this.gunaGradientButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Radius = 20;
            this.gunaGradientButton3.Size = new System.Drawing.Size(204, 75);
            this.gunaGradientButton3.TabIndex = 9;
            this.gunaGradientButton3.Text = "View Applictaion";
            this.gunaGradientButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // Inbox
            // 
            this.Inbox.Location = new System.Drawing.Point(232, 2);
            this.Inbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inbox.Name = "Inbox";
            this.Inbox.Size = new System.Drawing.Size(1233, 800);
            this.Inbox.TabIndex = 9;
            this.Inbox.Paint += new System.Windows.Forms.PaintEventHandler(this.Inbox_Paint);
            // 
            // merit
            // 
            this.merit.Location = new System.Drawing.Point(231, 2);
            this.merit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.merit.Name = "merit";
            this.merit.Size = new System.Drawing.Size(1233, 800);
            this.merit.TabIndex = 0;
            this.merit.Paint += new System.Windows.Forms.PaintEventHandler(this.merit_Paint);
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.Animated = true;
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.Image = null;
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(22, 477);
            this.gunaGradientButton4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Radius = 20;
            this.gunaGradientButton4.Size = new System.Drawing.Size(204, 75);
            this.gunaGradientButton4.TabIndex = 10;
            this.gunaGradientButton4.Text = "Merit";
            this.gunaGradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton4.Click += new System.EventHandler(this.gunaGradientButton4_Click_1);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 803);
            this.Controls.Add(this.gunaGradientButton4);
            this.Controls.Add(this.merit);
            this.Controls.Add(this.Inbox);
            this.Controls.Add(this.gunaGradientButton3);
            this.Controls.Add(this.updatePanel);
            this.Controls.Add(this.gunaGradientButton2);
            this.Controls.Add(this.GVpanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaGradientButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.GVpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGV)).EndInit();
            this.updatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel GVpanel;
        private Guna.UI.WinForms.GunaDataGridView usersGV;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private System.Windows.Forms.Panel updatePanel;
        private Guna.UI.WinForms.GunaDataGridView userGV2;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private System.Windows.Forms.Panel meritlist;
        private System.Windows.Forms.Panel Inbox;
        private System.Windows.Forms.Panel merit;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
    }
}