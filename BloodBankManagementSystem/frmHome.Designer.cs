
namespace BloodBankManagementSystem
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pannelFooter = new System.Windows.Forms.Panel();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.lblDevTitle = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panelOpossitive = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOpossitiveCount = new System.Windows.Forms.Label();
            this.lblApositive = new System.Windows.Forms.Label();
            this.panelOnegative = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnegativeCount = new System.Windows.Forms.Label();
            this.lblOnegative = new System.Windows.Forms.Label();
            this.panelAnegative = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAnegativeCount = new System.Windows.Forms.Label();
            this.lblAnegative = new System.Windows.Forms.Label();
            this.panelApossitive = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblApossitiveCount = new System.Windows.Forms.Label();
            this.lblApossitive = new System.Windows.Forms.Label();
            this.panelABnegative = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblABnegativeCount = new System.Windows.Forms.Label();
            this.lblABnegative = new System.Windows.Forms.Label();
            this.panelABpossitive = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblABpossitiveCount = new System.Windows.Forms.Label();
            this.lblABpoitive = new System.Windows.Forms.Label();
            this.panelBnegative = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBnegativeCount = new System.Windows.Forms.Label();
            this.lblBnegative = new System.Windows.Forms.Label();
            this.panelBpossitive = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lblBpossitiveCount = new System.Windows.Forms.Label();
            this.lblBpossitive = new System.Windows.Forms.Label();
            this.dgvDonors = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.lblLoggedInUs = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStripTop.SuspendLayout();
            this.pannelFooter.SuspendLayout();
            this.panelOpossitive.SuspendLayout();
            this.panelOnegative.SuspendLayout();
            this.panelAnegative.SuspendLayout();
            this.panelApossitive.SuspendLayout();
            this.panelABnegative.SuspendLayout();
            this.panelABpossitive.SuspendLayout();
            this.panelBnegative.SuspendLayout();
            this.panelBpossitive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.donorsToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStripTop.Size = new System.Drawing.Size(951, 41);
            this.menuStripTop.TabIndex = 0;
            this.menuStripTop.Text = "menuStrip1";
            this.menuStripTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripTop_ItemClicked);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // donorsToolStripMenuItem
            // 
            this.donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            this.donorsToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.donorsToolStripMenuItem.Text = "Donors";
            this.donorsToolStripMenuItem.Click += new System.EventHandler(this.donorsToolStripMenuItem_Click);
            // 
            // pannelFooter
            // 
            this.pannelFooter.BackColor = System.Drawing.SystemColors.Control;
            this.pannelFooter.Controls.Add(this.lblDeveloper);
            this.pannelFooter.Controls.Add(this.lblDevTitle);
            this.pannelFooter.Controls.Add(this.lblAppName);
            this.pannelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pannelFooter.Location = new System.Drawing.Point(0, 502);
            this.pannelFooter.Name = "pannelFooter";
            this.pannelFooter.Size = new System.Drawing.Size(951, 44);
            this.pannelFooter.TabIndex = 1;
            this.pannelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.pannelFooter_Paint);
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeveloper.ForeColor = System.Drawing.Color.Black;
            this.lblDeveloper.Location = new System.Drawing.Point(788, 5);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(57, 30);
            this.lblDeveloper.TabIndex = 2;
            this.lblDeveloper.Text = "M.V.";
            // 
            // lblDevTitle
            // 
            this.lblDevTitle.AutoSize = true;
            this.lblDevTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDevTitle.ForeColor = System.Drawing.Color.Black;
            this.lblDevTitle.Location = new System.Drawing.Point(634, 5);
            this.lblDevTitle.Name = "lblDevTitle";
            this.lblDevTitle.Size = new System.Drawing.Size(160, 30);
            this.lblDevTitle.TabIndex = 1;
            this.lblDevTitle.Text = "Developed By - ";
            this.lblDevTitle.Click += new System.EventHandler(this.lblDevTitle_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAppName.Location = new System.Drawing.Point(267, 5);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(318, 30);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Blood Bank Management System";
            this.lblAppName.Click += new System.EventHandler(this.lblAppName_Click);
            // 
            // panelOpossitive
            // 
            this.panelOpossitive.BackColor = System.Drawing.SystemColors.Control;
            this.panelOpossitive.Controls.Add(this.lblName);
            this.panelOpossitive.Controls.Add(this.lblOpossitiveCount);
            this.panelOpossitive.Controls.Add(this.lblApositive);
            this.panelOpossitive.Location = new System.Drawing.Point(21, 69);
            this.panelOpossitive.Name = "panelOpossitive";
            this.panelOpossitive.Size = new System.Drawing.Size(200, 100);
            this.panelOpossitive.TabIndex = 2;
            this.panelOpossitive.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(119, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Donors";
            this.lblName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblOpossitiveCount
            // 
            this.lblOpossitiveCount.AutoSize = true;
            this.lblOpossitiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpossitiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOpossitiveCount.Location = new System.Drawing.Point(140, 10);
            this.lblOpossitiveCount.Name = "lblOpossitiveCount";
            this.lblOpossitiveCount.Size = new System.Drawing.Size(39, 47);
            this.lblOpossitiveCount.TabIndex = 2;
            this.lblOpossitiveCount.Text = "0";
            this.lblOpossitiveCount.Click += new System.EventHandler(this.lblOpossitiveCount_Click);
            // 
            // lblApositive
            // 
            this.lblApositive.AutoSize = true;
            this.lblApositive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApositive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApositive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApositive.Location = new System.Drawing.Point(28, 19);
            this.lblApositive.Name = "lblApositive";
            this.lblApositive.Size = new System.Drawing.Size(98, 65);
            this.lblApositive.TabIndex = 1;
            this.lblApositive.Text = "O+";
            this.lblApositive.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelOnegative
            // 
            this.panelOnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelOnegative.Controls.Add(this.label1);
            this.panelOnegative.Controls.Add(this.lblOnegativeCount);
            this.panelOnegative.Controls.Add(this.lblOnegative);
            this.panelOnegative.Location = new System.Drawing.Point(258, 69);
            this.panelOnegative.Name = "panelOnegative";
            this.panelOnegative.Size = new System.Drawing.Size(200, 100);
            this.panelOnegative.TabIndex = 4;
            this.panelOnegative.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Donors";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // lblOnegativeCount
            // 
            this.lblOnegativeCount.AutoSize = true;
            this.lblOnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegativeCount.Location = new System.Drawing.Point(140, 10);
            this.lblOnegativeCount.Name = "lblOnegativeCount";
            this.lblOnegativeCount.Size = new System.Drawing.Size(39, 47);
            this.lblOnegativeCount.TabIndex = 2;
            this.lblOnegativeCount.Text = "0";
            this.lblOnegativeCount.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOnegative
            // 
            this.lblOnegative.AutoSize = true;
            this.lblOnegative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblOnegative.Location = new System.Drawing.Point(20, 11);
            this.lblOnegative.Name = "lblOnegative";
            this.lblOnegative.Size = new System.Drawing.Size(83, 65);
            this.lblOnegative.TabIndex = 1;
            this.lblOnegative.Text = "O-";
            this.lblOnegative.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelAnegative
            // 
            this.panelAnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelAnegative.Controls.Add(this.label5);
            this.panelAnegative.Controls.Add(this.lblAnegativeCount);
            this.panelAnegative.Controls.Add(this.lblAnegative);
            this.panelAnegative.Location = new System.Drawing.Point(258, 175);
            this.panelAnegative.Name = "panelAnegative";
            this.panelAnegative.Size = new System.Drawing.Size(200, 100);
            this.panelAnegative.TabIndex = 6;
            this.panelAnegative.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(119, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Donors";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblAnegativeCount
            // 
            this.lblAnegativeCount.AutoSize = true;
            this.lblAnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegativeCount.Location = new System.Drawing.Point(140, 10);
            this.lblAnegativeCount.Name = "lblAnegativeCount";
            this.lblAnegativeCount.Size = new System.Drawing.Size(39, 47);
            this.lblAnegativeCount.TabIndex = 2;
            this.lblAnegativeCount.Text = "0";
            this.lblAnegativeCount.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblAnegative
            // 
            this.lblAnegative.AutoSize = true;
            this.lblAnegative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblAnegative.Location = new System.Drawing.Point(20, 11);
            this.lblAnegative.Name = "lblAnegative";
            this.lblAnegative.Size = new System.Drawing.Size(81, 65);
            this.lblAnegative.TabIndex = 1;
            this.lblAnegative.Text = "A-";
            this.lblAnegative.Click += new System.EventHandler(this.label7_Click);
            // 
            // panelApossitive
            // 
            this.panelApossitive.BackColor = System.Drawing.SystemColors.Control;
            this.panelApossitive.Controls.Add(this.label8);
            this.panelApossitive.Controls.Add(this.lblApossitiveCount);
            this.panelApossitive.Controls.Add(this.lblApossitive);
            this.panelApossitive.Location = new System.Drawing.Point(21, 175);
            this.panelApossitive.Name = "panelApossitive";
            this.panelApossitive.Size = new System.Drawing.Size(200, 100);
            this.panelApossitive.TabIndex = 5;
            this.panelApossitive.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(103, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Donors";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblApossitiveCount
            // 
            this.lblApossitiveCount.AutoSize = true;
            this.lblApossitiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApossitiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApossitiveCount.Location = new System.Drawing.Point(124, 10);
            this.lblApossitiveCount.Name = "lblApossitiveCount";
            this.lblApossitiveCount.Size = new System.Drawing.Size(39, 47);
            this.lblApossitiveCount.TabIndex = 2;
            this.lblApossitiveCount.Text = "0";
            this.lblApossitiveCount.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblApossitive
            // 
            this.lblApossitive.AutoSize = true;
            this.lblApossitive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApossitive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApossitive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblApossitive.Location = new System.Drawing.Point(28, 19);
            this.lblApossitive.Name = "lblApossitive";
            this.lblApossitive.Size = new System.Drawing.Size(96, 65);
            this.lblApossitive.TabIndex = 1;
            this.lblApossitive.Text = "A+";
            this.lblApossitive.Click += new System.EventHandler(this.label10_Click);
            // 
            // panelABnegative
            // 
            this.panelABnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelABnegative.Controls.Add(this.label11);
            this.panelABnegative.Controls.Add(this.lblABnegativeCount);
            this.panelABnegative.Controls.Add(this.lblABnegative);
            this.panelABnegative.Location = new System.Drawing.Point(258, 387);
            this.panelABnegative.Name = "panelABnegative";
            this.panelABnegative.Size = new System.Drawing.Size(200, 100);
            this.panelABnegative.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(119, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 3;
            this.label11.Text = "Donors";
            // 
            // lblABnegativeCount
            // 
            this.lblABnegativeCount.AutoSize = true;
            this.lblABnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblABnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegativeCount.Location = new System.Drawing.Point(140, 10);
            this.lblABnegativeCount.Name = "lblABnegativeCount";
            this.lblABnegativeCount.Size = new System.Drawing.Size(39, 47);
            this.lblABnegativeCount.TabIndex = 2;
            this.lblABnegativeCount.Text = "0";
            // 
            // lblABnegative
            // 
            this.lblABnegative.AutoSize = true;
            this.lblABnegative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblABnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblABnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABnegative.Location = new System.Drawing.Point(20, 11);
            this.lblABnegative.Name = "lblABnegative";
            this.lblABnegative.Size = new System.Drawing.Size(112, 65);
            this.lblABnegative.TabIndex = 1;
            this.lblABnegative.Text = "AB-";
            // 
            // panelABpossitive
            // 
            this.panelABpossitive.BackColor = System.Drawing.SystemColors.Control;
            this.panelABpossitive.Controls.Add(this.label14);
            this.panelABpossitive.Controls.Add(this.lblABpossitiveCount);
            this.panelABpossitive.Controls.Add(this.lblABpoitive);
            this.panelABpossitive.Location = new System.Drawing.Point(21, 387);
            this.panelABpossitive.Name = "panelABpossitive";
            this.panelABpossitive.Size = new System.Drawing.Size(200, 100);
            this.panelABpossitive.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(103, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 21);
            this.label14.TabIndex = 3;
            this.label14.Text = "Donors";
            // 
            // lblABpossitiveCount
            // 
            this.lblABpossitiveCount.AutoSize = true;
            this.lblABpossitiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblABpossitiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABpossitiveCount.Location = new System.Drawing.Point(124, 10);
            this.lblABpossitiveCount.Name = "lblABpossitiveCount";
            this.lblABpossitiveCount.Size = new System.Drawing.Size(39, 47);
            this.lblABpossitiveCount.TabIndex = 2;
            this.lblABpossitiveCount.Text = "0";
            // 
            // lblABpoitive
            // 
            this.lblABpoitive.AutoSize = true;
            this.lblABpoitive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblABpoitive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblABpoitive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblABpoitive.Location = new System.Drawing.Point(12, 19);
            this.lblABpoitive.Name = "lblABpoitive";
            this.lblABpoitive.Size = new System.Drawing.Size(127, 65);
            this.lblABpoitive.TabIndex = 1;
            this.lblABpoitive.Text = "AB+";
            // 
            // panelBnegative
            // 
            this.panelBnegative.BackColor = System.Drawing.SystemColors.Control;
            this.panelBnegative.Controls.Add(this.label17);
            this.panelBnegative.Controls.Add(this.lblBnegativeCount);
            this.panelBnegative.Controls.Add(this.lblBnegative);
            this.panelBnegative.Location = new System.Drawing.Point(258, 281);
            this.panelBnegative.Name = "panelBnegative";
            this.panelBnegative.Size = new System.Drawing.Size(200, 100);
            this.panelBnegative.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(119, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 21);
            this.label17.TabIndex = 3;
            this.label17.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            this.lblBnegativeCount.AutoSize = true;
            this.lblBnegativeCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBnegativeCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegativeCount.Location = new System.Drawing.Point(140, 10);
            this.lblBnegativeCount.Name = "lblBnegativeCount";
            this.lblBnegativeCount.Size = new System.Drawing.Size(39, 47);
            this.lblBnegativeCount.TabIndex = 2;
            this.lblBnegativeCount.Text = "0";
            // 
            // lblBnegative
            // 
            this.lblBnegative.AutoSize = true;
            this.lblBnegative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBnegative.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBnegative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBnegative.Location = new System.Drawing.Point(20, 11);
            this.lblBnegative.Name = "lblBnegative";
            this.lblBnegative.Size = new System.Drawing.Size(78, 65);
            this.lblBnegative.TabIndex = 1;
            this.lblBnegative.Text = "B-";
            // 
            // panelBpossitive
            // 
            this.panelBpossitive.BackColor = System.Drawing.SystemColors.Control;
            this.panelBpossitive.Controls.Add(this.label20);
            this.panelBpossitive.Controls.Add(this.lblBpossitiveCount);
            this.panelBpossitive.Controls.Add(this.lblBpossitive);
            this.panelBpossitive.Location = new System.Drawing.Point(21, 281);
            this.panelBpossitive.Name = "panelBpossitive";
            this.panelBpossitive.Size = new System.Drawing.Size(200, 100);
            this.panelBpossitive.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(119, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 21);
            this.label20.TabIndex = 3;
            this.label20.Text = "Donors";
            // 
            // lblBpossitiveCount
            // 
            this.lblBpossitiveCount.AutoSize = true;
            this.lblBpossitiveCount.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBpossitiveCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpossitiveCount.Location = new System.Drawing.Point(140, 10);
            this.lblBpossitiveCount.Name = "lblBpossitiveCount";
            this.lblBpossitiveCount.Size = new System.Drawing.Size(39, 47);
            this.lblBpossitiveCount.TabIndex = 2;
            this.lblBpossitiveCount.Text = "0";
            // 
            // lblBpossitive
            // 
            this.lblBpossitive.AutoSize = true;
            this.lblBpossitive.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBpossitive.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBpossitive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(76)))), ((int)(((byte)(58)))));
            this.lblBpossitive.Location = new System.Drawing.Point(28, 19);
            this.lblBpossitive.Name = "lblBpossitive";
            this.lblBpossitive.Size = new System.Drawing.Size(93, 65);
            this.lblBpossitive.TabIndex = 1;
            this.lblBpossitive.Text = "B+";
            // 
            // dgvDonors
            // 
            this.dgvDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonors.Location = new System.Drawing.Point(475, 122);
            this.dgvDonors.Name = "dgvDonors";
            this.dgvDonors.RowTemplate.Height = 25;
            this.dgvDonors.Size = new System.Drawing.Size(464, 365);
            this.dgvDonors.TabIndex = 11;
            this.dgvDonors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(475, 69);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(109, 21);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search Donor";
            this.lblSearch.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(591, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(348, 29);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.White;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(904, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(47, 41);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 14;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLoggedInUs
            // 
            this.lblLoggedInUs.AutoSize = true;
            this.lblLoggedInUs.Location = new System.Drawing.Point(21, 41);
            this.lblLoggedInUs.Name = "lblLoggedInUs";
            this.lblLoggedInUs.Size = new System.Drawing.Size(79, 15);
            this.lblLoggedInUs.TabIndex = 15;
            this.lblLoggedInUs.Text = "Logged in As:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblUser.Location = new System.Drawing.Point(109, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 15);
            this.lblUser.TabIndex = 16;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(951, 546);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblLoggedInUs);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDonors);
            this.Controls.Add(this.panelABnegative);
            this.Controls.Add(this.panelABpossitive);
            this.Controls.Add(this.panelBnegative);
            this.Controls.Add(this.panelBpossitive);
            this.Controls.Add(this.panelAnegative);
            this.Controls.Add(this.panelApossitive);
            this.Controls.Add(this.panelOnegative);
            this.Controls.Add(this.panelOpossitive);
            this.Controls.Add(this.pannelFooter);
            this.Controls.Add(this.menuStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripTop;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.frmHome_Activated);
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.pannelFooter.ResumeLayout(false);
            this.pannelFooter.PerformLayout();
            this.panelOpossitive.ResumeLayout(false);
            this.panelOpossitive.PerformLayout();
            this.panelOnegative.ResumeLayout(false);
            this.panelOnegative.PerformLayout();
            this.panelAnegative.ResumeLayout(false);
            this.panelAnegative.PerformLayout();
            this.panelApossitive.ResumeLayout(false);
            this.panelApossitive.PerformLayout();
            this.panelABnegative.ResumeLayout(false);
            this.panelABnegative.PerformLayout();
            this.panelABpossitive.ResumeLayout(false);
            this.panelABpossitive.PerformLayout();
            this.panelBnegative.ResumeLayout(false);
            this.panelBnegative.PerformLayout();
            this.panelBpossitive.ResumeLayout(false);
            this.panelBpossitive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donorsToolStripMenuItem;
        private System.Windows.Forms.Panel pannelFooter;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblDevTitle;
        private System.Windows.Forms.Label lblDeveloper;
        private System.Windows.Forms.Panel panelOpossitive;
        private System.Windows.Forms.Label lblApositive;
        private System.Windows.Forms.Label lblOpossitiveCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnegativeCount;
        private System.Windows.Forms.Label lblOnegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnegativeCount;
        private System.Windows.Forms.Label lblAnegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblApossitiveCount;
        private System.Windows.Forms.Label lblApossitive;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblABnegativeCount;
        private System.Windows.Forms.Label lblABnegative;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblABpossitiveCount;
        private System.Windows.Forms.Label lblABpoitive;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBnegativeCount;
        private System.Windows.Forms.Label lblBnegative;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblBpossitiveCount;
        private System.Windows.Forms.Label lblBpossitive;
        private System.Windows.Forms.DataGridView dgvDonors;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Panel panelOnegative;
        private System.Windows.Forms.Panel panelAnegative;
        private System.Windows.Forms.Panel panelApossitive;
        private System.Windows.Forms.Panel panelABnegative;
        private System.Windows.Forms.Panel panelABpossitive;
        private System.Windows.Forms.Panel panelBnegative;
        private System.Windows.Forms.Panel panelBpossitive;
        private System.Windows.Forms.Label lblLoggedInUs;
        private System.Windows.Forms.Label lblUser;
    }
}

