namespace PharmaHealix
{
    partial class AdminPharmacistForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblPharmacistID = new System.Windows.Forms.Label();
            this.lblPharmacistName = new System.Windows.Forms.Label();
            this.lblDgree = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.lblFavoriteColor = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtPharmacistID = new System.Windows.Forms.TextBox();
            this.txtPharmacistName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtFavoriteColor = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            this.chkPharmD = new System.Windows.Forms.CheckBox();
            this.chkMPharm = new System.Windows.Forms.CheckBox();
            this.chkDiploma = new System.Windows.Forms.CheckBox();
            this.chkBPharm = new System.Windows.Forms.CheckBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvPharmacist = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacist)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 110);
            this.pnlHeader.TabIndex = 30;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(886, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(57, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(807, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "ADMIN PHARMACIST MANAGEMENT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btnDoctor);
            this.panelMenu.Controls.Add(this.btnPatient);
            this.panelMenu.Controls.Add(this.btnInventory);
            this.panelMenu.Controls.Add(this.btnAppointment);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 700);
            this.panelMenu.TabIndex = 28;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = global::PharmaHealix.Properties.Resources.PharmaHealixLogo2;
            this.picLogo.Location = new System.Drawing.Point(32, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(183, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.White;
            this.btnDoctor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDoctor.FlatAppearance.BorderSize = 2;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.Black;
            this.btnDoctor.Location = new System.Drawing.Point(40, 180);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(170, 50);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.White;
            this.btnPatient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPatient.FlatAppearance.BorderSize = 2;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPatient.Location = new System.Drawing.Point(40, 250);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(170, 50);
            this.btnPatient.TabIndex = 1;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInventory.FlatAppearance.BorderSize = 2;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnInventory.Location = new System.Drawing.Point(40, 390);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(170, 50);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.BackColor = System.Drawing.Color.White;
            this.btnAppointment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAppointment.FlatAppearance.BorderSize = 2;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAppointment.Location = new System.Drawing.Point(40, 320);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(170, 50);
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.Text = "Appointment";
            this.btnAppointment.UseVisualStyleBackColor = false;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 2;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(40, 560);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblPharmacistID
            // 
            this.lblPharmacistID.AutoSize = true;
            this.lblPharmacistID.BackColor = System.Drawing.Color.Transparent;
            this.lblPharmacistID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistID.Location = new System.Drawing.Point(324, 135);
            this.lblPharmacistID.Name = "lblPharmacistID";
            this.lblPharmacistID.Size = new System.Drawing.Size(33, 28);
            this.lblPharmacistID.TabIndex = 31;
            this.lblPharmacistID.Text = "ID";
            this.lblPharmacistID.Click += new System.EventHandler(this.lblPharmacistID_Click);
            // 
            // lblPharmacistName
            // 
            this.lblPharmacistName.AutoSize = true;
            this.lblPharmacistName.BackColor = System.Drawing.Color.Transparent;
            this.lblPharmacistName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPharmacistName.Location = new System.Drawing.Point(324, 181);
            this.lblPharmacistName.Name = "lblPharmacistName";
            this.lblPharmacistName.Size = new System.Drawing.Size(68, 28);
            this.lblPharmacistName.TabIndex = 32;
            this.lblPharmacistName.Text = "Name";
            // 
            // lblDgree
            // 
            this.lblDgree.AutoSize = true;
            this.lblDgree.BackColor = System.Drawing.Color.Transparent;
            this.lblDgree.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgree.Location = new System.Drawing.Point(324, 341);
            this.lblDgree.Name = "lblDgree";
            this.lblDgree.Size = new System.Drawing.Size(80, 28);
            this.lblDgree.TabIndex = 33;
            this.lblDgree.Text = "Degree";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(324, 282);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 28);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "Gender";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.BackColor = System.Drawing.Color.Transparent;
            this.Salary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(324, 230);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(71, 28);
            this.Salary.TabIndex = 35;
            this.Salary.Text = "Salary";
            // 
            // lblFavoriteColor
            // 
            this.lblFavoriteColor.AutoSize = true;
            this.lblFavoriteColor.BackColor = System.Drawing.Color.Transparent;
            this.lblFavoriteColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteColor.Location = new System.Drawing.Point(324, 391);
            this.lblFavoriteColor.Name = "lblFavoriteColor";
            this.lblFavoriteColor.Size = new System.Drawing.Size(136, 28);
            this.lblFavoriteColor.TabIndex = 36;
            this.lblFavoriteColor.Text = "Favoite Color";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.BackColor = System.Drawing.Color.Transparent;
            this.lblPetName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(324, 444);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(104, 28);
            this.lblPetName.TabIndex = 37;
            this.lblPetName.Text = "Pet Name";
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthPlace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthPlace.Location = new System.Drawing.Point(324, 490);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(116, 28);
            this.lblBirthPlace.TabIndex = 38;
            this.lblBirthPlace.Text = "Birth Place";
            // 
            // txtPharmacistID
            // 
            this.txtPharmacistID.BackColor = System.Drawing.Color.White;
            this.txtPharmacistID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacistID.Location = new System.Drawing.Point(467, 131);
            this.txtPharmacistID.Name = "txtPharmacistID";
            this.txtPharmacistID.Size = new System.Drawing.Size(250, 37);
            this.txtPharmacistID.TabIndex = 39;
            // 
            // txtPharmacistName
            // 
            this.txtPharmacistName.BackColor = System.Drawing.Color.White;
            this.txtPharmacistName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPharmacistName.Location = new System.Drawing.Point(466, 177);
            this.txtPharmacistName.Name = "txtPharmacistName";
            this.txtPharmacistName.Size = new System.Drawing.Size(250, 37);
            this.txtPharmacistName.TabIndex = 40;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.White;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(467, 226);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(250, 37);
            this.txtSalary.TabIndex = 41;
            // 
            // txtFavoriteColor
            // 
            this.txtFavoriteColor.BackColor = System.Drawing.Color.White;
            this.txtFavoriteColor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFavoriteColor.Location = new System.Drawing.Point(467, 387);
            this.txtFavoriteColor.Name = "txtFavoriteColor";
            this.txtFavoriteColor.Size = new System.Drawing.Size(140, 37);
            this.txtFavoriteColor.TabIndex = 42;
            // 
            // txtPetName
            // 
            this.txtPetName.BackColor = System.Drawing.Color.White;
            this.txtPetName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.Location = new System.Drawing.Point(466, 440);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(140, 37);
            this.txtPetName.TabIndex = 43;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.BackColor = System.Drawing.Color.White;
            this.txtBirthPlace.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthPlace.Location = new System.Drawing.Point(466, 486);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(140, 37);
            this.txtBirthPlace.TabIndex = 44;
            // 
            // chkPharmD
            // 
            this.chkPharmD.AutoSize = true;
            this.chkPharmD.BackColor = System.Drawing.Color.Transparent;
            this.chkPharmD.Location = new System.Drawing.Point(580, 345);
            this.chkPharmD.Name = "chkPharmD";
            this.chkPharmD.Size = new System.Drawing.Size(93, 24);
            this.chkPharmD.TabIndex = 46;
            this.chkPharmD.Text = "PharmD";
            this.chkPharmD.UseVisualStyleBackColor = false;
            // 
            // chkMPharm
            // 
            this.chkMPharm.AutoSize = true;
            this.chkMPharm.BackColor = System.Drawing.Color.Transparent;
            this.chkMPharm.Location = new System.Drawing.Point(689, 345);
            this.chkMPharm.Name = "chkMPharm";
            this.chkMPharm.Size = new System.Drawing.Size(98, 24);
            this.chkMPharm.TabIndex = 47;
            this.chkMPharm.Text = "M.Pharm";
            this.chkMPharm.UseVisualStyleBackColor = false;
            // 
            // chkDiploma
            // 
            this.chkDiploma.AutoSize = true;
            this.chkDiploma.BackColor = System.Drawing.Color.Transparent;
            this.chkDiploma.Location = new System.Drawing.Point(793, 345);
            this.chkDiploma.Name = "chkDiploma";
            this.chkDiploma.Size = new System.Drawing.Size(93, 24);
            this.chkDiploma.TabIndex = 48;
            this.chkDiploma.Text = "Diploma";
            this.chkDiploma.UseVisualStyleBackColor = false;
            // 
            // chkBPharm
            // 
            this.chkBPharm.AutoSize = true;
            this.chkBPharm.BackColor = System.Drawing.Color.Transparent;
            this.chkBPharm.Location = new System.Drawing.Point(466, 345);
            this.chkBPharm.Name = "chkBPharm";
            this.chkBPharm.Size = new System.Drawing.Size(96, 24);
            this.chkBPharm.TabIndex = 49;
            this.chkBPharm.Text = "B.Pharm";
            this.chkBPharm.UseVisualStyleBackColor = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.Location = new System.Drawing.Point(467, 287);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 24);
            this.rdoMale.TabIndex = 50;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.Location = new System.Drawing.Point(556, 287);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(87, 24);
            this.rdoFemale.TabIndex = 51;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(930, 135);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 40);
            this.btnShow.TabIndex = 52;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(930, 191);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(930, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(930, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(930, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 56;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvPharmacist
            // 
            this.dgvPharmacist.AllowUserToAddRows = false;
            this.dgvPharmacist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPharmacist.BackgroundColor = System.Drawing.Color.White;
            this.dgvPharmacist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPharmacist.GridColor = System.Drawing.Color.LightGray;
            this.dgvPharmacist.Location = new System.Drawing.Point(627, 431);
            this.dgvPharmacist.MultiSelect = false;
            this.dgvPharmacist.Name = "dgvPharmacist";
            this.dgvPharmacist.ReadOnly = true;
            this.dgvPharmacist.RowHeadersWidth = 62;
            this.dgvPharmacist.RowTemplate.Height = 28;
            this.dgvPharmacist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPharmacist.Size = new System.Drawing.Size(531, 239);
            this.dgvPharmacist.TabIndex = 57;
            // 
            // AdminPharmacistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmaHealix.Properties.Resources.BackgroundImage3;
            this.ClientSize = new System.Drawing.Size(1184, 694);
            this.Controls.Add(this.dgvPharmacist);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.chkBPharm);
            this.Controls.Add(this.chkDiploma);
            this.Controls.Add(this.chkMPharm);
            this.Controls.Add(this.chkPharmD);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.txtFavoriteColor);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPharmacistName);
            this.Controls.Add(this.txtPharmacistID);
            this.Controls.Add(this.lblBirthPlace);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.lblFavoriteColor);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDgree);
            this.Controls.Add(this.lblPharmacistName);
            this.Controls.Add(this.lblPharmacistID);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 72);
            this.MinimizeBox = false;
            this.Name = "AdminPharmacistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Pharmacist";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblPharmacistID;
        private System.Windows.Forms.Label lblPharmacistName;
        private System.Windows.Forms.Label lblDgree;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label lblFavoriteColor;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox txtPharmacistID;
        private System.Windows.Forms.TextBox txtPharmacistName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtFavoriteColor;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.CheckBox chkPharmD;
        private System.Windows.Forms.CheckBox chkMPharm;
        private System.Windows.Forms.CheckBox chkDiploma;
        private System.Windows.Forms.CheckBox chkBPharm;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvPharmacist;
        private System.Windows.Forms.Button btnExit;
    }
}