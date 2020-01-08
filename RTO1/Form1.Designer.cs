namespace RTO1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_button = new System.Windows.Forms.Button();
            this.signin_button = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblpara = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.licenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.learnersLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseRenewelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyForNewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appoinmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.lLTESTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.licenseStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(255, 92);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(157, 44);
            this.login_button.TabIndex = 10;
            this.login_button.Text = "login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // signin_button
            // 
            this.signin_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_button.Location = new System.Drawing.Point(255, 205);
            this.signin_button.Name = "signin_button";
            this.signin_button.Size = new System.Drawing.Size(157, 42);
            this.signin_button.TabIndex = 11;
            this.signin_button.Text = "sign in";
            this.signin_button.UseVisualStyleBackColor = true;
            this.signin_button.Click += new System.EventHandler(this.Signin_button_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(466, 58);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(504, 42);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "RTO MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(801, 53);
            this.label2.TabIndex = 14;
            this.label2.Text = "MINISTRY OF ROAD TRANSPORT AND HIGHWAYS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.signin_button);
            this.panel1.Location = new System.Drawing.Point(1024, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 309);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 76);
            this.label4.TabIndex = 1;
            this.label4.Text = "New user?\r\nThen , Register !\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 76);
            this.label3.TabIndex = 0;
            this.label3.Text = "Already have an\r\naccount?\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 38);
            this.label5.TabIndex = 12;
            this.label5.Text = "About RTO";
            // 
            // lblpara
            // 
            this.lblpara.AutoSize = true;
            this.lblpara.BackColor = System.Drawing.Color.Honeydew;
            this.lblpara.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpara.Location = new System.Drawing.Point(86, 412);
            this.lblpara.Name = "lblpara";
            this.lblpara.Size = new System.Drawing.Size(884, 168);
            this.lblpara.TabIndex = 16;
            this.lblpara.Text = resources.GetString("lblpara.Text");
            this.lblpara.Click += new System.EventHandler(this.Lblpara_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 739);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1556, 76);
            this.panel2.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseServicesToolStripMenuItem,
            this.appoinmentsToolStripMenuItem,
            this.licenseStatusToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(339, 174);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(818, 40);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // licenseServicesToolStripMenuItem
            // 
            this.licenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.learnersLicenseToolStripMenuItem,
            this.driversLicenseToolStripMenuItem});
            this.licenseServicesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseServicesToolStripMenuItem.Name = "licenseServicesToolStripMenuItem";
            this.licenseServicesToolStripMenuItem.Size = new System.Drawing.Size(192, 36);
            this.licenseServicesToolStripMenuItem.Text = "license services";
            // 
            // learnersLicenseToolStripMenuItem
            // 
            this.learnersLicenseToolStripMenuItem.Name = "learnersLicenseToolStripMenuItem";
            this.learnersLicenseToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.learnersLicenseToolStripMenuItem.Text = "learner\'s license";
            this.learnersLicenseToolStripMenuItem.Click += new System.EventHandler(this.LearnersLicenseToolStripMenuItem_Click);
            // 
            // driversLicenseToolStripMenuItem
            // 
            this.driversLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseRenewelToolStripMenuItem,
            this.duplicateLicenseToolStripMenuItem,
            this.applyForNewLicenseToolStripMenuItem});
            this.driversLicenseToolStripMenuItem.Name = "driversLicenseToolStripMenuItem";
            this.driversLicenseToolStripMenuItem.Size = new System.Drawing.Size(274, 36);
            this.driversLicenseToolStripMenuItem.Text = "driver\'s license";
            // 
            // licenseRenewelToolStripMenuItem
            // 
            this.licenseRenewelToolStripMenuItem.Name = "licenseRenewelToolStripMenuItem";
            this.licenseRenewelToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.licenseRenewelToolStripMenuItem.Text = "license renewel";
            // 
            // duplicateLicenseToolStripMenuItem
            // 
            this.duplicateLicenseToolStripMenuItem.Name = "duplicateLicenseToolStripMenuItem";
            this.duplicateLicenseToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.duplicateLicenseToolStripMenuItem.Text = "duplicate license";
            // 
            // applyForNewLicenseToolStripMenuItem
            // 
            this.applyForNewLicenseToolStripMenuItem.Name = "applyForNewLicenseToolStripMenuItem";
            this.applyForNewLicenseToolStripMenuItem.Size = new System.Drawing.Size(333, 36);
            this.applyForNewLicenseToolStripMenuItem.Text = "Apply for new license";
            // 
            // appoinmentsToolStripMenuItem
            // 
            this.appoinmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingTestToolStripMenuItem,
            this.lLTESTToolStripMenuItem});
            this.appoinmentsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appoinmentsToolStripMenuItem.Name = "appoinmentsToolStripMenuItem";
            this.appoinmentsToolStripMenuItem.Size = new System.Drawing.Size(169, 36);
            this.appoinmentsToolStripMenuItem.Text = "appoinments";
            // 
            // drivingTestToolStripMenuItem
            // 
            this.drivingTestToolStripMenuItem.Name = "drivingTestToolStripMenuItem";
            this.drivingTestToolStripMenuItem.Size = new System.Drawing.Size(227, 36);
            this.drivingTestToolStripMenuItem.Text = "Driving test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(156, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 54);
            this.label6.TabIndex = 20;
            this.label6.Text = "VAGANAM\r\nSEWAI\r\n";
            // 
            // lLTESTToolStripMenuItem
            // 
            this.lLTESTToolStripMenuItem.Name = "lLTESTToolStripMenuItem";
            this.lLTESTToolStripMenuItem.Size = new System.Drawing.Size(227, 36);
            this.lLTESTToolStripMenuItem.Text = "LL TEST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1512, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // licenseStatusToolStripMenuItem
            // 
            this.licenseStatusToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseStatusToolStripMenuItem.Name = "licenseStatusToolStripMenuItem";
            this.licenseStatusToolStripMenuItem.Size = new System.Drawing.Size(176, 36);
            this.licenseStatusToolStripMenuItem.Text = "License status";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.contactUsToolStripMenuItem.Text = "Contact us";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 815);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblpara);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button signin_button;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblpara;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem licenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem learnersLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseRenewelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicateLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appoinmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingTestToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem applyForNewLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lLTESTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
    }
}

