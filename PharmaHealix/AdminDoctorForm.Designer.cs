namespace PharmaHealix
{
    partial class AdminDoctorForm
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
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDoctorID = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDgree = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.chkMBBS = new System.Windows.Forms.CheckBox();
            this.chkFCPS = new System.Windows.Forms.CheckBox();
            this.chkMD = new System.Windows.Forms.CheckBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPharmacist = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblFavoriteColor = new System.Windows.Forms.Label();
            this.lblPetName = new System.Windows.Forms.Label();
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.txtFavoriteColor = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(134, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(700, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "ADMIN DOCTOR MANAGEMENT";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDoctorID
            // 
            this.lblDoctorID.AutoSize = true;
            this.lblDoctorID.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorID.Location = new System.Drawing.Point(300, 130);
            this.lblDoctorID.Name = "lblDoctorID";
            this.lblDoctorID.Size = new System.Drawing.Size(33, 28);
            this.lblDoctorID.TabIndex = 6;
            this.lblDoctorID.Text = "ID";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(300, 180);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(68, 28);
            this.lblDoctorName.TabIndex = 7;
            this.lblDoctorName.Text = "Name";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(300, 276);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(127, 28);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblDgree
            // 
            this.lblDgree.AutoSize = true;
            this.lblDgree.BackColor = System.Drawing.Color.Transparent;
            this.lblDgree.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDgree.Location = new System.Drawing.Point(300, 321);
            this.lblDgree.Name = "lblDgree";
            this.lblDgree.Size = new System.Drawing.Size(80, 28);
            this.lblDgree.TabIndex = 10;
            this.lblDgree.Text = "Degree";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(300, 375);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(80, 28);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.BackColor = System.Drawing.Color.White;
            this.txtDoctorID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorID.Location = new System.Drawing.Point(430, 126);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(250, 37);
            this.txtDoctorID.TabIndex = 12;
            this.txtDoctorID.TextChanged += new System.EventHandler(this.txtDoctorID_TextChanged);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.BackColor = System.Drawing.Color.White;
            this.txtDoctorName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorName.Location = new System.Drawing.Point(430, 176);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(250, 37);
            this.txtDoctorName.TabIndex = 13;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Cardiology",
            "",
            "Neurology",
            "",
            "Orthopedic",
            "",
            "Medicine",
            "",
            "Dermatology",
            "",
            "ENT",
            "",
            "Pediatrics"});
            this.cmbDepartment.Location = new System.Drawing.Point(430, 276);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(250, 28);
            this.cmbDepartment.TabIndex = 15;
            // 
            // chkMBBS
            // 
            this.chkMBBS.AutoSize = true;
            this.chkMBBS.BackColor = System.Drawing.Color.Transparent;
            this.chkMBBS.Location = new System.Drawing.Point(430, 327);
            this.chkMBBS.Name = "chkMBBS";
            this.chkMBBS.Size = new System.Drawing.Size(81, 24);
            this.chkMBBS.TabIndex = 16;
            this.chkMBBS.Text = "MBBS";
            this.chkMBBS.UseVisualStyleBackColor = false;
            // 
            // chkFCPS
            // 
            this.chkFCPS.AutoSize = true;
            this.chkFCPS.BackColor = System.Drawing.Color.Transparent;
            this.chkFCPS.Location = new System.Drawing.Point(510, 327);
            this.chkFCPS.Name = "chkFCPS";
            this.chkFCPS.Size = new System.Drawing.Size(77, 24);
            this.chkFCPS.TabIndex = 17;
            this.chkFCPS.Text = "FCPS";
            this.chkFCPS.UseVisualStyleBackColor = false;
            // 
            // chkMD
            // 
            this.chkMD.AutoSize = true;
            this.chkMD.BackColor = System.Drawing.Color.Transparent;
            this.chkMD.Location = new System.Drawing.Point(593, 327);
            this.chkMD.Name = "chkMD";
            this.chkMD.Size = new System.Drawing.Size(60, 24);
            this.chkMD.TabIndex = 18;
            this.chkMD.Text = "MD";
            this.chkMD.UseVisualStyleBackColor = false;
            this.chkMD.CheckedChanged += new System.EventHandler(this.chkMD_CheckedChanged);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.Location = new System.Drawing.Point(504, 379);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(87, 24);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.Location = new System.Drawing.Point(430, 379);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(68, 24);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(952, 149);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 40);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(952, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(952, 266);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(952, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(952, 375);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.AllowUserToAddRows = false;
            this.dgvDoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctor.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.GridColor = System.Drawing.Color.LightGray;
            this.dgvDoctor.Location = new System.Drawing.Point(612, 442);
            this.dgvDoctor.MultiSelect = false;
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.ReadOnly = true;
            this.dgvDoctor.RowHeadersWidth = 62;
            this.dgvDoctor.RowTemplate.Height = 28;
            this.dgvDoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctor.Size = new System.Drawing.Size(507, 228);
            this.dgvDoctor.TabIndex = 27;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnPharmacist);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Controls.Add(this.btnPatient);
            this.panelMenu.Controls.Add(this.btnInventory);
            this.panelMenu.Controls.Add(this.btnAppointment);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 700);
            this.panelMenu.TabIndex = 28;
            // 
            // btnPharmacist
            // 
            this.btnPharmacist.BackColor = System.Drawing.Color.White;
            this.btnPharmacist.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPharmacist.FlatAppearance.BorderSize = 2;
            this.btnPharmacist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPharmacist.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPharmacist.Location = new System.Drawing.Point(40, 180);
            this.btnPharmacist.Name = "btnPharmacist";
            this.btnPharmacist.Size = new System.Drawing.Size(170, 50);
            this.btnPharmacist.TabIndex = 38;
            this.btnPharmacist.Text = "Pharmacist";
            this.btnPharmacist.UseVisualStyleBackColor = false;
            this.btnPharmacist.Click += new System.EventHandler(this.btnPharmacist_Click);
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
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(35)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(250, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(950, 110);
            this.pnlHeader.TabIndex = 29;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(880, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.BackColor = System.Drawing.Color.Transparent;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(300, 230);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(53, 28);
            this.lblFees.TabIndex = 30;
            this.lblFees.Text = "Fees";
            // 
            // lblFavoriteColor
            // 
            this.lblFavoriteColor.AutoSize = true;
            this.lblFavoriteColor.BackColor = System.Drawing.Color.Transparent;
            this.lblFavoriteColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavoriteColor.Location = new System.Drawing.Point(300, 426);
            this.lblFavoriteColor.Name = "lblFavoriteColor";
            this.lblFavoriteColor.Size = new System.Drawing.Size(136, 28);
            this.lblFavoriteColor.TabIndex = 31;
            this.lblFavoriteColor.Text = "Favoite Color";
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.BackColor = System.Drawing.Color.Transparent;
            this.lblPetName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(300, 482);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(104, 28);
            this.lblPetName.TabIndex = 32;
            this.lblPetName.Text = "Pet Name";
            // 
            // lblBirthPlace
            // 
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthPlace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthPlace.Location = new System.Drawing.Point(300, 532);
            this.lblBirthPlace.Name = "lblBirthPlace";
            this.lblBirthPlace.Size = new System.Drawing.Size(116, 28);
            this.lblBirthPlace.TabIndex = 33;
            this.lblBirthPlace.Text = "Birth Place";
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.White;
            this.txtFees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFees.Location = new System.Drawing.Point(430, 226);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(250, 37);
            this.txtFees.TabIndex = 34;
            // 
            // txtFavoriteColor
            // 
            this.txtFavoriteColor.BackColor = System.Drawing.Color.White;
            this.txtFavoriteColor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFavoriteColor.Location = new System.Drawing.Point(430, 422);
            this.txtFavoriteColor.Name = "txtFavoriteColor";
            this.txtFavoriteColor.Size = new System.Drawing.Size(140, 37);
            this.txtFavoriteColor.TabIndex = 35;
            // 
            // txtPetName
            // 
            this.txtPetName.BackColor = System.Drawing.Color.White;
            this.txtPetName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.Location = new System.Drawing.Point(430, 478);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(140, 37);
            this.txtPetName.TabIndex = 36;
            // 
            // txtBirthPlace
            // 
            this.txtBirthPlace.BackColor = System.Drawing.Color.White;
            this.txtBirthPlace.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthPlace.Location = new System.Drawing.Point(433, 528);
            this.txtBirthPlace.Name = "txtBirthPlace";
            this.txtBirthPlace.Size = new System.Drawing.Size(140, 37);
            this.txtBirthPlace.TabIndex = 37;
            // 
            // AdminDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(238)))), ((int)(((byte)(210)))));
            this.BackgroundImage = global::PharmaHealix.Properties.Resources.BackgroundImage2;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.txtBirthPlace);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.txtFavoriteColor);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.lblBirthPlace);
            this.Controls.Add(this.lblPetName);
            this.Controls.Add(this.lblFavoriteColor);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.dgvDoctor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.chkMD);
            this.Controls.Add(this.chkFCPS);
            this.Controls.Add(this.chkMBBS);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.txtDoctorID);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDgree);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblDoctorID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 72);
            this.MaximizeBox = false;
            this.Name = "AdminDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Doctor";
            this.Load += new System.EventHandler(this.AdminUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDoctorID;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblDgree;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.CheckBox chkMBBS;
        private System.Windows.Forms.CheckBox chkFCPS;
        private System.Windows.Forms.CheckBox chkMD;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label lblFavoriteColor;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.TextBox txtFavoriteColor;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Button btnPharmacist;
        private System.Windows.Forms.Button btnExit;
    }
}