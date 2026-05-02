namespace PharmaHealix
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportsbtn = new System.Windows.Forms.Button();
            this.medbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrescription = new System.Windows.Forms.TabPage();
            this.tabRecords = new System.Windows.Forms.TabPage();
            this.tabAvailability = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPrescription.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportsbtn);
            this.panel1.Controls.Add(this.medbtn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 447);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doctor Menu";
            // 
            // reportsbtn
            // 
            this.reportsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.reportsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.reportsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsbtn.Image = ((System.Drawing.Image)(resources.GetObject("reportsbtn.Image")));
            this.reportsbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsbtn.Location = new System.Drawing.Point(12, 335);
            this.reportsbtn.Name = "reportsbtn";
            this.reportsbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.reportsbtn.Size = new System.Drawing.Size(212, 43);
            this.reportsbtn.TabIndex = 4;
            this.reportsbtn.Text = "       Reports";
            this.reportsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsbtn.UseVisualStyleBackColor = true;
            this.reportsbtn.Click += new System.EventHandler(this.reportsbtn_Click);
            // 
            // medbtn
            // 
            this.medbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.medbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.medbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medbtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medbtn.Image = global::PharmaHealix.Properties.Resources.rsz_medicine_11109007;
            this.medbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medbtn.Location = new System.Drawing.Point(12, 276);
            this.medbtn.Name = "medbtn";
            this.medbtn.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.medbtn.Size = new System.Drawing.Size(212, 43);
            this.medbtn.TabIndex = 3;
            this.medbtn.Text = "       Medicine Availability";
            this.medbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.medbtn.UseVisualStyleBackColor = true;
            this.medbtn.Click += new System.EventHandler(this.medbtn_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::PharmaHealix.Properties.Resources.rsz_follower_6234792;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 216);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(212, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "       Patient Records";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PharmaHealix.Properties.Resources.rsz_prescription_3000124;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(212, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "        Create Prescription";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPrescription);
            this.tabControl1.Controls.Add(this.tabRecords);
            this.tabControl1.Controls.Add(this.tabAvailability);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(242, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 424);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPrescription
            // 
            this.tabPrescription.BackColor = System.Drawing.Color.Transparent;
            this.tabPrescription.Controls.Add(this.tabControl2);
            this.tabPrescription.Location = new System.Drawing.Point(4, 5);
            this.tabPrescription.Name = "tabPrescription";
            this.tabPrescription.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrescription.Size = new System.Drawing.Size(522, 415);
            this.tabPrescription.TabIndex = 0;
            this.tabPrescription.Text = "Prescription";
            // 
            // tabRecords
            // 
            this.tabRecords.BackColor = System.Drawing.Color.Transparent;
            this.tabRecords.Location = new System.Drawing.Point(4, 5);
            this.tabRecords.Name = "tabRecords";
            this.tabRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecords.Size = new System.Drawing.Size(522, 415);
            this.tabRecords.TabIndex = 1;
            this.tabRecords.Text = "Records";
            // 
            // tabAvailability
            // 
            this.tabAvailability.BackColor = System.Drawing.Color.Transparent;
            this.tabAvailability.Location = new System.Drawing.Point(4, 5);
            this.tabAvailability.Name = "tabAvailability";
            this.tabAvailability.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailability.Size = new System.Drawing.Size(522, 415);
            this.tabAvailability.TabIndex = 2;
            this.tabAvailability.Text = "Availability";
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.Transparent;
            this.tabReports.Location = new System.Drawing.Point(4, 5);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(522, 415);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(489, 93);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(0, 0);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Doctor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PharmaHealix.Properties.Resources.BackgroundImage1;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 72);
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPrescription.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button reportsbtn;
        private System.Windows.Forms.Button medbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrescription;
        private System.Windows.Forms.TabPage tabRecords;
        private System.Windows.Forms.TabPage tabAvailability;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}