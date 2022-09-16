using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormSales : Form
    {
        Sale sale;
        double prevSaleAmount = 0;

        public FormSales()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            // Control for empty fields
            if (comboBoxSalesSalesPersonID.Text.Trim() == "")
            {
                MessageBox.Show("Please insert sales person");
                return;
            }
            if (AmountTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please insert sale's amount");
                return;
            }

            using (DBEntities db = new DBEntities())
            {
                // Find associated sale's person
                int salesPersonID = Convert.ToInt32(
                    comboBoxSalesSalesPersonID.Text.Trim());
                SalesPerson salesPerson = db.SalesPersons.Where(x => 
                    x.ID == salesPersonID).FirstOrDefault();
                
                double extraFees = 0;

                if (sale == null)   //Insert
                {
                    sale = new Sale
                    {
                        SalesPersonID = salesPersonID,
                        SalesPerson = textBoxSalesSalesPersonName.Text.Trim(),
                        Amount = Convert.ToDecimal(AmountTextBox.Text.Trim()),
                        Date = datePickerSales.Value
                    };

                    db.Sales.Add(sale);

                    // Calculate extra sale's person fees
                    extraFees = Convert.ToDouble(sale.Amount) * 0.1;
                }
                else    // Update
                {
                    sale.Amount = Convert.ToDecimal(AmountTextBox.Text.Trim());
                    sale.Date = datePickerSales.Value;

                    db.Entry(sale).State = EntityState.Modified;

                    // Calculate extra sale's person fees
                    extraFees = (Convert.ToDouble(sale.Amount)
                        - prevSaleAmount) * 0.1;
                }

                salesPerson.Fees = Convert.ToDecimal(
                    Convert.ToDouble(salesPerson.Fees) + extraFees);
                db.Entry(salesPerson).State = EntityState.Modified;

                // Commit changes to database. Both tables
                db.SaveChanges();
            }

            Clear();
            PopulateDataGridView();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete record?",
                "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    // Sales table
                    if (db.Entry(sale).State == EntityState.Detached)
                        db.Sales.Attach(sale);
                    db.Sales.Remove(sale);

                    // Sale's person table
                    SalesPerson salesPerson = db.SalesPersons.Where(x => 
                        x.ID == sale.SalesPersonID).FirstOrDefault();
                    salesPerson.Name = salesPerson.Name;
                    double extraFees = Convert.ToDouble(sale.Amount) * 0.1;
                    salesPerson.Fees = Convert.ToDecimal(
                        Convert.ToDouble(salesPerson.Fees) - extraFees);

                    db.SaveChanges();

                    PopulateDataGridView();
                    Clear();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSalesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainWindow formMainWindow = new FormMainWindow();
            formMainWindow.ShowDialog();
        }

        private void SalesDgv_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (SalesDgv.CurrentRow.Index != -1)
            {
                using (DBEntities db = new DBEntities())
                {
                    int saleID = Convert.ToInt32(SalesDgv.CurrentRow
                        .Cells["SalesID"].Value);

                    sale = new Sale();
                    sale = db.Sales.Where(x => x.ID ==
                        saleID).FirstOrDefault();

                    comboBoxSalesSalesPersonID.Text = Convert.ToString(sale.SalesPersonID);
                    textBoxSalesSalesPersonName.Text = sale.SalesPerson;
                    AmountTextBox.Text = Convert.ToString(sale.Amount);
                    datePickerSales.Value = sale.Date;

                    // Save sale amount in case it is altered
                    prevSaleAmount = Convert.ToDouble(sale.Amount);
                }
                InsertButton.Text = "Update";
                DeleteButton.Enabled = true;
            }
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateSalesPersonsComboBox();
            PopulateDataGridView();
        }

        void Clear()
        {
            comboBoxSalesSalesPersonID.Text = "";
            textBoxSalesSalesPersonName.Text = "";
            AmountTextBox.Text = "";
            InsertButton.Text = "Insert";
            DeleteButton.Enabled = false;
            sale = null;
        }

        void PopulateDataGridView()
        {
            SalesDgv.AutoGenerateColumns = false;

            using (DBEntities db = new DBEntities())
            {
                SalesDgv.DataSource = db.Sales.ToList();
            }
        }

        void PopulateSalesPersonsComboBox()
        {
            using (DBEntities db = new DBEntities())
            {
                foreach (SalesPerson salesPerson in db.SalesPersons.ToArray())
                    comboBoxSalesSalesPersonID.Items.Add(salesPerson.ID);
            }
        }

        private void comboBoxSalesSalesPersonID_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int salesPersonID = Convert.ToInt32(comboBoxSalesSalesPersonID
                .Text.Trim());

            using (DBEntities db = new DBEntities())
            {
                SalesPerson salesPerson = db.SalesPersons.Where(x =>
                    x.ID == salesPersonID).FirstOrDefault();

                textBoxSalesSalesPersonName.Text = salesPerson.Name;
            }
        }
    }
}
