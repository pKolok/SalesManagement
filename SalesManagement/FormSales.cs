using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormSales : Form
    {
        Sale model = new Sale();

        public FormSales()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            model.Amount = Convert.ToDecimal(AmountTextBox.Text.Trim());
            model.Date = DateTextBox.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)   //Insert
                {
                    db.Sales.Add(model);
                }
                else    // Update
                {
                    db.Entry(model).State = EntityState.Modified;
                }

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
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Sales.Attach(model);

                    db.Sales.Remove(model);
                    db.SaveChanges();

                    PopulateDataGridView();
                    Clear();

                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void btnSalesBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainWindow formMainWindow = new FormMainWindow();
            formMainWindow.ShowDialog();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            AmountTextBox.Text = DateTextBox.Text = "";
            InsertButton.Text = "Insert";
            DeleteButton.Enabled = false;
            model.ID = 0;
        }

        void PopulateDataGridView()
        {
            SalesDgv.AutoGenerateColumns = false;

            using (DBEntities db = new DBEntities())
            {
                SalesDgv.DataSource = db.Sales.ToList();
            }
        }
    }
}
