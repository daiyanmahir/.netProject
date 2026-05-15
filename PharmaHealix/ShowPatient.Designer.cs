namespace PharmaHealix
{
    partial class ShowPatient
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
            this.Patientlbl = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.viewbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Patientlbl
            // 
            this.Patientlbl.AutoSize = true;
            this.Patientlbl.BackColor = System.Drawing.Color.Transparent;
            this.Patientlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Patientlbl.Location = new System.Drawing.Point(416, 23);
            this.Patientlbl.Name = "Patientlbl";
            this.Patientlbl.Size = new System.Drawing.Size(354, 46);
            this.Patientlbl.TabIndex = 0;
            this.Patientlbl.Text = "Patient Information";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(135, 90);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(892, 522);
            this.dataGridView.TabIndex = 1;
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(222)))));
            this.viewbtn.FlatAppearance.BorderSize = 0;
            this.viewbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewbtn.Location = new System.Drawing.Point(519, 626);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(135, 45);
            this.viewbtn.TabIndex = 26;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.White;
            this.Exitbtn.FlatAppearance.BorderSize = 0;
            this.Exitbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Exitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Location = new System.Drawing.Point(1119, 8);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(50, 30);
            this.Exitbtn.TabIndex = 27;
            this.Exitbtn.Text = "X";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // ShowPatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::PharmaHealix.Properties.Resources.BackgroundImage;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Patientlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Patientlbl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}