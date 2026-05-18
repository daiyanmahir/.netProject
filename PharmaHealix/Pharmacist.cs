using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PharmaHealix
{
    public partial class Pharmacist : Form
    {
        private string username;

       
         private string PhName
         {
             get { return pharmacistprofilenametxt.Text; }
             set { pharmacistprofilenametxt.Text = value; }
         }
         private string PhPhone
         {
             get { return pharmacistphonetxt.Text; }
             set { pharmacistphonetxt.Text = value; }
         }
         private string PhUsername
         {
             get { return pharmacistprofileusernametxt.Text; }
             set { pharmacistprofileusernametxt.Text = value; }
         }
         private string PhAddress
         {
             get { return pharmacistprofileaddtxt.Text; }
             set { pharmacistprofileaddtxt.Text = value; }
         }
         private string PhAnswer
         {
             get { return pharmacistanswertxt.Text; }
             set { pharmacistanswertxt.Text = value; }
         }
         private string PhPass
        {
            get { return pharmacistprofilepasstxt.Text; }
            set { pharmacistprofilepasstxt.Text = value; }
        }

        public Pharmacist(string n)
        {
            this.username = n;
            InitializeComponent();
          
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void patientlistbtn_Click(object sender, EventArgs e)
        {
            pharmacistprofilepan.Visible = false;
            inventorypan.Visible = false;
            orderpan.Visible = false;
            patientlistpan.Visible = true;
            RefreshPrescriptionGrid();
            phprrtb.Clear();
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
            pharmacistprofilepan.Visible = false;
            inventorypan.Visible = false;
            patientlistpan.Visible = false;
            orderpan.Visible = true;

            InitializeOrderPage();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
            pharmacistprofilepan.Visible = false;
            patientlistpan.Visible = false;
            orderpan.Visible = false;
            inventorypan.Visible = true;
            RefreshInventoryGrid();
            ClearInventoryFields();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            patientlistpan.Visible = false;
            orderpan.Visible = false;
            inventorypan.Visible = false;
            pharmacistprofilepan.Visible = true;
            editprofile();
        }

        private void Exitbtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pharmacistlogoutbtn_Click(object sender, EventArgs e)
        {
            Loginform l = new Loginform();
            this.Hide();
            l.Show();
        }

        private void pharmacistprofileupdatebtn_Click(object sender, EventArgs e)
        {

            errorphonepan.Visible = false;
            errorpharmacistnamepan.Visible = false;
            errorusernamepan.Visible = false;
            erroraddpan.Visible = false;
            erroranspan.Visible = false;
            errorpasspan.Visible = false;

            bool Error = false;
            bool Flag = false;

            if (PhPhone == "")
            {
                errorphonepan.Visible = true;
                Error = true;
            }

            bool PDigits = true;

            foreach (char c in PhPhone)
            {
                if (!char.IsDigit(c))
                {
                    PDigits = false;
                    break;
                }
            }

            if (!PDigits || PhPhone.Length != 11 || !PhPhone.StartsWith("01"))
            {
                errorphonepan.Visible = true;
                Flag = true;
            }
            if (PhName == "")
            {
                errorpharmacistnamepan.Visible = true;
                Error = true;
            }
            if (PhName != "")
            {
                foreach (char c in PhName)
                {
                    if (char.IsDigit(c))
                    {
                        errorpharmacistnamepan.Visible = true;
                        Flag = true;
                        break;
                    }
                }
            }
            if (PhUsername == "")
            {

                errorusernamepan.Visible = true;
                Error = true;
            }
            bool UDigits = true;

            foreach (char c in PhUsername)
            {
                if (!char.IsDigit(c))
                {
                    UDigits = false;
                    break;
                }
            }

            if (PhUsername.Length < 4 || UDigits)
            {
                errorusernamepan.Visible = true;
                Flag = true;
            }
            if (PhUsername != "" && PhUsername != username)
            {
                string query = "SELECT COUNT(*) FROM UserTable WHERE Username = @0";
                int count = Convert.ToInt32(new Db().Scalar(query, PhUsername));
                if (count > 0)
                {
                    errorusernamepan.Visible = true;
                    Flag = true;
                }
            }
            if (PhAddress == "")
            {
                erroraddpan.Visible = true;
                Error = true;
            }


            if (PhAnswer == "")
            {
                erroranspan.Visible = true;
                Error = true;
            }

            if (PhPass == "")
            {
                errorpasspan.Visible = true;
                Error = true;
            }
            else if (PhPass.Length < 5)
            {
                errorpasspan.Visible = true;
                Flag = true;
            }

            if (Error)
            {
                MessageBox.Show("Please fill all required fields");
                return;
            }
            else if (Flag)
            {
                MessageBox.Show(
                                "Fix the following:\n" +
                                "-> Username: 4+ chars, not only numbers, must be unique\n" +
                                "-> Password: at least 5 characters\n" +
                                "-> Name: letters only (no numbers)\n" +
                                "-> Phone (11 digits, starts with 01)"
                                );
            }
            else
            {

                string query = "UPDATE UserTable SET Name = @0, Phone = @1, Username = @2, Address = @3, Question = @4, Answer = @5, Password = @6 WHERE Username = @7";
                new Db().NonQuery(query, PhName, PhPhone, PhUsername, PhAddress, comboBox1.Text, PhAnswer, PhPass,username);
                username = PhUsername;


                MessageBox.Show("Update Successful!");
                editprofile();
            }
        }
        private void editprofile()
        {
            string q = "select * from UserTable where username=@0";
            DataTable dt = new Db().Reader(q, username);
            pharmacistprofilenametxt.Text = Convert.ToString(dt.Rows[0]["Name"]);
            pharmacistphonetxt.Text = Convert.ToString(dt.Rows[0]["Phone"]);
            pharmacistprofileusernametxt.Text = Convert.ToString(dt.Rows[0]["Username"]);
            pharmacistprofileaddtxt.Text = Convert.ToString(dt.Rows[0]["Address"]);
            comboBox1.Text = Convert.ToString(dt.Rows[0]["Question"]);
            pharmacistprofilepasstxt.Text = Convert.ToString(dt.Rows[0]["Password"]);
            pharmacistanswertxt.Text = Convert.ToString(dt.Rows[0]["Answer"]);

        }
        //INVENTORY
        private void RefreshInventoryGrid()
        {
            // Fetches all records from the MedicineTable to populate the DataGridView
            string query = "SELECT MedicineID, MedicineName, Category, Description, StripPrice, UnitPrice, Dose, SideEffect, Stock, ExpireDate, Image, Instruction FROM MedicineTable";
            DataTable dt = new Db().Reader(query);

            if (dt != null)
            {
                phinvdgv.DataSource = dt;
            }
        }

        private void ClearInventoryFields()
        {
            // Resets all text boxes to empty strings
            phinvmnametb.Clear();
            phinvcategorytb.Clear();
            phinvspricetb.Clear();
            phinvupricetb.Clear();
            phinvstocktb.Clear();
            phinvdosetb.Clear();
            phinvdescriptiontb.Clear();
            phinvsideetb.Clear();
            phimgtb.Clear();
            phinvinstructiontb.Clear();
            phinvexpirydtp.Value = DateTime.Now;
        }

        private void phinvaddbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phinvmnametb.Text) || string.IsNullOrWhiteSpace(phinvcategorytb.Text))
            {
                MessageBox.Show("Please fill out at least the Medicine Name and Category.");
                return;
            }

            Db db = new Db();

            // 2. Duplicate Check Logic
            string checkDuplicateQuery = "SELECT COUNT(*) FROM MedicineTable WHERE MedicineName = @0";
            bool medicineExists = Convert.ToInt32(db.Scalar(checkDuplicateQuery, phinvmnametb.Text)) > 0;

            if (medicineExists)
            {
                MessageBox.Show(" Medicine already present in the inventory.");
                return; // Stops execution so the duplicate record isn't added
            }

            // 3. Parse values carefully to prevent string-to-number exceptions
            decimal.TryParse(phinvspricetb.Text, out decimal stripPrice);
            decimal.TryParse(phinvupricetb.Text, out decimal unitPrice);
            int.TryParse(phinvstocktb.Text, out int stock);

            // 4. Proceed with Insert since it's a new medicine
            string query = "INSERT INTO MedicineTable (MedicineName, Category, Description, StripPrice, UnitPrice, Dose, SideEffect, Stock, ExpireDate, Image, Instruction) " +
                           "VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10)";

            db.NonQuery(query,
                phinvmnametb.Text,
                phinvcategorytb.Text,
                phinvdescriptiontb.Text,
                stripPrice,
                unitPrice,
                phinvdosetb.Text,
                phinvsideetb.Text,
                stock,
                phinvexpirydtp.Value.Date,
                phimgtb.Text,
                phinvinstructiontb.Text
            );

            MessageBox.Show("Medicine added successfully!");
            RefreshInventoryGrid();
            ClearInventoryFields();
        }

        private void phinvdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index clicked belongs to actual data rows
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = phinvdgv.Rows[e.RowIndex];

                phinvmnametb.Text = Convert.ToString(row.Cells["MedicineName"].Value);
                phinvcategorytb.Text = Convert.ToString(row.Cells["Category"].Value);
                phinvdescriptiontb.Text = Convert.ToString(row.Cells["Description"].Value);
                phinvspricetb.Text = Convert.ToString(row.Cells["StripPrice"].Value);
                phinvupricetb.Text = Convert.ToString(row.Cells["UnitPrice"].Value);
                phinvdosetb.Text = Convert.ToString(row.Cells["Dose"].Value);
                phinvsideetb.Text = Convert.ToString(row.Cells["SideEffect"].Value);
                phinvstocktb.Text = Convert.ToString(row.Cells["Stock"].Value);

                phimgtb.Text = Convert.ToString(row.Cells["Image"].Value);
                phinvinstructiontb.Text = Convert.ToString(row.Cells["Instruction"].Value);

                if (row.Cells["ExpireDate"].Value != DBNull.Value && row.Cells["ExpireDate"].Value != null)
                {
                    phinvexpirydtp.Value = Convert.ToDateTime(row.Cells["ExpireDate"].Value);
                }
                else
                {
                    phinvexpirydtp.Value = DateTime.Now;
                }
            }
        }

        private void phinvupdatebtn_Click(object sender, EventArgs e)
        {
            if (phinvdgv.CurrentRow == null)
            {
                MessageBox.Show("Please click a medicine row from the table to update first.");
                return;
            }

            var currentRow = phinvdgv.CurrentRow;
            int medicineId = Convert.ToInt32(currentRow.Cells["MedicineID"].Value);

            decimal.TryParse(phinvspricetb.Text, out decimal stripPrice);
            decimal.TryParse(phinvupricetb.Text, out decimal unitPrice);
            int.TryParse(phinvstocktb.Text, out int stock);

            string query = "UPDATE MedicineTable SET MedicineName = @0, Category = @1, Description = @2, StripPrice = @3, " +
                           "UnitPrice = @4, Dose = @5, SideEffect = @6, Stock = @7, ExpireDate = @8, Image = @9, Instruction = @10 WHERE MedicineID = @11";

            new Db().NonQuery(query,
                phinvmnametb.Text,
                phinvcategorytb.Text,
                phinvdescriptiontb.Text,
                stripPrice,
                unitPrice,
                phinvdosetb.Text,
                phinvsideetb.Text,
                stock,
                phinvexpirydtp.Value.Date,
                phimgtb.Text,
                phinvinstructiontb.Text,
                medicineId
            );

            MessageBox.Show("Medicine updated successfully!");
            RefreshInventoryGrid();
            ClearInventoryFields();
        }

        private void phinvremovebtn_Click(object sender, EventArgs e)
        {

            if (phinvdgv.CurrentRow == null)
            {
                MessageBox.Show("Please click a medicine row from the table to delete.");
                return;
            }

            var currentRow = phinvdgv.CurrentRow;
            int medicineId = Convert.ToInt32(currentRow.Cells["MedicineID"].Value);

            string query = "DELETE FROM MedicineTable WHERE MedicineID = @0";
            new Db().NonQuery(query, medicineId);

            MessageBox.Show("Medicine removed successfully!");
            RefreshInventoryGrid();
            ClearInventoryFields();
        }

        //PRESCRIPTION

        private void RefreshPrescriptionGrid()
        {
            string query = "SELECT PrescriptionID, AppointmentID, DoctorID, PatientUsername, PrescriptionText, PrescriptionDate FROM PrescriptionTable";
            DataTable dt = new Db().Reader(query);

            if (dt != null)
            {
                phprdgv.DataSource = dt;
            }
        }

        private void phprdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = phprdgv.Rows[e.RowIndex];

               
                phprrtb.Text = Convert.ToString(row.Cells["PrescriptionText"].Value);
            }
        }


        //ORDER
        private DataTable cartTable = new DataTable();

        private void InitializeOrderPage()
        {
            if (cartTable != null)
            {
                cartTable.Clear(); // Completely empties all row records from the data table memory
            }

            // Clear all the UI TextBoxes shown in your screenshot
            searchmedtb.Clear();          // Clears the "Search Medicine" field
            phordmedicinetb.Clear();      // Clears the "Medicine" label/field
            patientusernametb.Clear();    // Clears the "Patient Username" field
            numericUpDown1.Value = 0;     // Resets the "Quantity" selector back to 0
            phordtotaltb.Text = "0.00";   // Resets the "Total Amount" display field

            // 2. Load available medicines from your database into the top DataGridView
            string query = "SELECT MedicineID, MedicineName, Category, UnitPrice, Stock FROM MedicineTable";
            DataTable dt = new Db().Reader(query);
            if (dt != null)
            {
                phordmeddgv.DataSource = dt;
            }

            // 3. Rebuild the schema configuration for your Order Cart if it doesn't exist
            if (cartTable.Columns.Count == 0)
            {
                cartTable.Columns.Add("MedicineID", typeof(int));
                cartTable.Columns.Add("MedicineName", typeof(string));
                cartTable.Columns.Add("Quantity", typeof(int));
                cartTable.Columns.Add("Price", typeof(decimal)); // Calculated line total
            }

            // 4. Bind your cart structure to the bottom "Order Cart" DataGridView
            phordcartdgv.DataSource = cartTable;
        }

        private void UpdateGrandTotal()
        {
            decimal totalSum = 0;
            foreach (DataRow row in cartTable.Rows)
            {
                totalSum += Convert.ToDecimal(row["Price"]);
            }
            phordtotaltb.Text = totalSum.ToString("0.00"); 
        }

        private void phordmeddgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = phordmeddgv.Rows[e.RowIndex];
                phordmedicinetb.Text = Convert.ToString(row.Cells["MedicineName"].Value); 
                numericUpDown1.Value = 1; 
            }
        }

        private void phordaddbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phordmedicinetb.Text) || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please search/select a valid medicine and enter a quantity.");
                return;
            }

            string selectedMedName = phordmedicinetb.Text;
            int requestedQty = Convert.ToInt32(numericUpDown1.Value);

            // 2. Query the database directly using the text box value to get real-time ID, Price, and Stock
            string query = "SELECT MedicineID, UnitPrice, Stock FROM MedicineTable WHERE MedicineName = @0";
            DataTable dt = new Db().Reader(query, selectedMedName);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("The selected medicine could not be verified in the database.");
                return;
            }

            // Safely pull database values regardless of whether the item came from a grid click or a search text box
            int medId = Convert.ToInt32(dt.Rows[0]["MedicineID"]);
            decimal unitPrice = Convert.ToDecimal(dt.Rows[0]["UnitPrice"]);
            int availableStock = Convert.ToInt32(dt.Rows[0]["Stock"]);

            // 3. Inventory Stock Validation Check
            if (requestedQty > availableStock)
            {
                MessageBox.Show($"Inadequate inventory stock! Only {availableStock} items remaining.");
                return;
            }

            decimal linePrice = requestedQty * unitPrice;

            // 4. Cart Optimization: If the item already exists in the cart table, update its quantities
            foreach (DataRow row in cartTable.Rows)
            {
                if (Convert.ToInt32(row["MedicineID"]) == medId)
                {
                    int newQty = Convert.ToInt32(row["Quantity"]) + requestedQty;
                    if (newQty > availableStock)
                    {
                        MessageBox.Show("Combined cart quantity exceeds available database stock!");
                        return;
                    }
                    row["Quantity"] = newQty;
                    row["Price"] = newQty * unitPrice;
                    UpdateGrandTotal();
                    return;
                }
            }

            // 5. Add new line record row to your visual Order Cart
            cartTable.Rows.Add(medId, selectedMedName, requestedQty, linePrice);
            UpdateGrandTotal();
        }

        private void phordremovebtn_Click(object sender, EventArgs e)
        {
            if (phordcartdgv.CurrentRow == null)
            {
                MessageBox.Show("Please select an item row inside the Order Cart to remove.");
                return;
            }

            int selectedIndex = phordcartdgv.CurrentRow.Index;
            cartTable.Rows[selectedIndex].Delete();
            
            UpdateGrandTotal();
        }

        private void phordconfirmbtn_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Your shopping cart is completely empty.");
                return;
            }

            // 2. Read the dynamic text directly from your new input control
            string patientUser = patientusernametb.Text.Trim();

            // 3. Validation Check: Make sure they didn't leave the patient username field blank
            if (patientUser == "")
            {
                MessageBox.Show("Please enter a Patient Username before confirming the order.");
                return;
            }

            Db db = new Db();

            // 4. Boolean Validation: Verify this username actually exists in your UserTable
            string checkUserQuery = "SELECT COUNT(*) FROM UserTable WHERE Username = @0";
            bool userExists = Convert.ToInt32(db.Scalar(checkUserQuery, patientUser)) > 0;

            if (!userExists)
            {
                MessageBox.Show("Patient Username not available!");
                return;
            }

            decimal totalAmt = Convert.ToDecimal(phordtotaltb.Text);
            DateTime today = DateTime.Today;

            try
            {
                // 5. Create the Master Ticket in OrderTable
                string insertOrderQuery = "INSERT INTO OrderTable (PatientUsername, OrderDate, TotalAmount, Status) VALUES (@0, @1, @2, @3)";
                db.NonQuery(insertOrderQuery, patientUser, today, totalAmt, "Processed");

                // 6. Fetch the newly created auto-identity ID safely
                object identityResult = db.Scalar("SELECT TOP 1 OrderID FROM OrderTable ORDER BY OrderID DESC");
                if (identityResult == null) throw new Exception("Could not retrieve the newly generated Order ID.");
                int newOrderId = Convert.ToInt32(identityResult);

                // 7. Loop through the cart table data to insert detailed lines and deduct inventory stock
                foreach (DataRow row in cartTable.Rows)
                {
                    int medId = Convert.ToInt32(row["MedicineID"]);
                    int qty = Convert.ToInt32(row["Quantity"]);
                    decimal price = Convert.ToDecimal(row["Price"]);
                    decimal uPrice = price / qty;

                    // Save row entry data lines into OrderDetailsTable
                    string insertDetailsQuery = "INSERT INTO OrderDetailsTable (OrderID, MedicineID, Quantity, UnitPrice) VALUES (@0, @1, @2, @3)";
                    db.NonQuery(insertDetailsQuery, newOrderId, medId, qty, uPrice);

                    // Deduct purchased items directly from stock numbers
                    string updateStockQuery = "UPDATE MedicineTable SET Stock = Stock - @0 WHERE MedicineID = @1";
                    db.NonQuery(updateStockQuery, qty, medId);
                }

                MessageBox.Show("Order processed and saved successfully!");

                // 8. Clean up interface inputs back to default configuration states
                cartTable.Clear();
                phordmedicinetb.Clear();
                patientusernametb.Clear(); 
                numericUpDown1.Value = 0;
                phordtotaltb.Text = "0.00";

                InitializeOrderPage(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save transaction: " + ex.Message);
            }
        }

        private void searchmedbtn_Click(object sender, EventArgs e)
        {
            string searchName = searchmedtb.Text;

            // 1. Validation Check: Make sure they didn't leave the search bar empty
            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please type a medicine name to search.");
                phordmedicinetb.Clear();
                numericUpDown1.Value = 0;
                return;
            }

            // 2. Query the database for an exact match
            string query = "SELECT MedicineName FROM MedicineTable WHERE MedicineName = @0";
            object result = new Db().Scalar(query, searchName);

            if (result != null)
            {
                // Exact match found! Populate the read-only medicine field and set default quantity to 1
                phordmedicinetb.Text = Convert.ToString(result);
                numericUpDown1.Value = 1;
            }
            else
            {
                // No match found
                MessageBox.Show("No medicine found matching that exact name. Please check your spelling.");
                phordmedicinetb.Clear();
                numericUpDown1.Value = 0;
            }
        }
    }
}
