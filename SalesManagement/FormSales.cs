using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormSales : Form
    {
        Sale sale = new Sale();
        SalesPerson salesPerson = new SalesPerson();

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

            sale.SalesPersonID = Convert.ToInt32(
                comboBoxSalesSalesPersonID.Text.Trim());
            sale.SalesPerson = textBoxSalesSalesPersonName.Text;
            sale.Amount = Convert.ToDecimal(AmountTextBox.Text.Trim());
            sale.Date = datePickerSales.Value;

            using (DBEntities db = new DBEntities())
            {
                if (sale.ID == 0)   //Insert
                {
                    db.Sales.Add(sale);
                }
                else    // Update
                {
                    db.Entry(sale).State = EntityState.Modified;
                }

                salesPerson = db.SalesPersons.Find(
                    sale.SalesPersonID);
                salesPerson.Name = salesPerson.Name;
                double extraFees = Convert.ToDouble(sale.Amount) * 0.1;
                salesPerson.Fees = Convert.ToDecimal(
                    Convert.ToDouble(salesPerson.Fees) + extraFees);

                db.Entry(salesPerson).State = EntityState.Modified;

                db.SaveChanges();
            }

            Clear();
            PopulateDataGridView();
            MessageBox.Show("Submitted Successfully");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete record?",
                "Delete Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(sale);
                    if (entry.State == EntityState.Detached)
                        db.Sales.Attach(sale);

                    db.Sales.Remove(sale);
                    db.SaveChanges();

                    PopulateDataGridView();
                    Clear();

                    MessageBox.Show("Deleted Successfully");
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
                sale.ID = Convert.ToInt32(SalesDgv.CurrentRow
                    .Cells["SalesID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    sale = db.Sales.Where(x => x.ID ==
                    sale.ID).FirstOrDefault();

                    comboBoxSalesSalesPersonID.Text = Convert.ToString(sale.SalesPersonID);
                    textBoxSalesSalesPersonName.Text = sale.SalesPerson;
                    AmountTextBox.Text = Convert.ToString(sale.Amount);
                    datePickerSales.Value = sale.Date;
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
            sale.ID = 0;
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
            int salesPersonID = Convert.ToInt32(comboBoxSalesSalesPersonID.Text);

            using (DBEntities db = new DBEntities())
            {
                SalesPerson salesPerson = db.SalesPersons.Find(salesPersonID);

                textBoxSalesSalesPersonName.Text = salesPerson.Name;
            }
        }
    }
}
