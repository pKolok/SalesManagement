using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
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
            if (NameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please insert sale's person name");
                return;
            }

            model.Name = NameTextBox.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                //Insert
                if (model.ID == 0)
                    db.SalesPersons.Add(model);
                // Update
                else
                    db.Entry(model).State = EntityState.Modified;

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
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.SalesPersons.Attach(model);
                    
                    db.SalesPersons.Remove(model);
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

            btnSalesPersonDetails.Show();
        }

        private void btnSalesPersonsBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMainWindow formMainWindow = new FormMainWindow();
            formMainWindow.ShowDialog();
        }

        private void btnSalesPersonDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesPersonDetails formDetails = new FormSalesPersonDetails(model.ID);
            formDetails.ShowDialog();
        }

        private void FormSalesPersons_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        void Clear()
        {
            NameTextBox.Text = "";
            InsertButton.Text = "Insert";
            DeleteButton.Enabled = false;
            model.ID = 0;
            btnSalesPersonDetails.Hide();
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
