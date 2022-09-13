using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormSalesPersons : Form
    {
        SalesPerson model = new SalesPerson();

        public FormSalesPersons()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            model.Name = NameTextBox.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                if (model.ID == 0)   //Insert
                {
                    db.SalesPersons.Add(model);
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
                        db.SalesPersons.Attach(model);
                    
                    db.SalesPersons.Remove(model);
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

        private void SalesManagement_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void SalesPersonsDgv_DoubleClick(object sender, EventArgs e)
        {
            if (SalesPersonsDgv.CurrentRow.Index != -1)
            {
                model.ID = Convert.ToInt32(SalesPersonsDgv.CurrentRow
                    .Cells["SalesPersonID"].Value);

                using (DBEntities db = new DBEntities())
                {
                    model = db.SalesPersons.Where(x => x.ID == 
                    model.ID).FirstOrDefault();

                    NameTextBox.Text = model.Name;
                }
                InsertButton.Text = "Update";
                DeleteButton.Enabled = true;
            }
        }

        private void btnSalesPersonsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainWindow formMainWindow = new FormMainWindow();
            formMainWindow.ShowDialog();
        }

        void Clear()
        {
            NameTextBox.Text = NameTextBox.Text = "";
            InsertButton.Text = "Insert";
            DeleteButton.Enabled = false;
            model.ID = 0;
        }

        void PopulateDataGridView()
        {
            SalesPersonsDgv.AutoGenerateColumns = false;

            using (DBEntities db = new DBEntities())
            {
                SalesPersonsDgv.DataSource = db.SalesPersons.ToList();
            }
        }
    }
}
