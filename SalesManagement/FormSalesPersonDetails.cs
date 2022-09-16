using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormSalesPersonDetails : Form
    {
        SalesPerson salesPerson = new SalesPerson();

        public FormSalesPersonDetails(int id)
        {
            InitializeComponent();

            using (DBEntities db = new DBEntities())
            {
                salesPerson = db.SalesPersons.Find(id);

                labelSalesPersonDetails.Text = salesPerson.Name;
            }
        }

        private void btnSalesPersonDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesPersons formSalesPersons = new FormSalesPersons();
            formSalesPersons.ShowDialog();
        }

        private void FormSalesPersonDetails_Load(object sender, EventArgs e)
        {
            PopulateTable();
        }

        void PopulateTable()
        {
            using (DBEntities db = new DBEntities())
            {
                DateTime now = DateTime.Today;

                var query = from s in db.Sales.AsEnumerable()
                            where s.SalesPersonID == salesPerson.ID & s.Date.Year == now.Year
                            orderby s.Date.Month
                            group s by new
                            {
                                Month = s.Date.Month
                            } into g
                            select new
                            {
                                Month = getFullName(g.Key.Month),
                                TotalSales = g.Sum(x => x.Amount),
                                TotalFees = g.Sum(x => Convert.ToDouble(x.Amount) * 0.1)
                            };

                dataGridViewSalesPersonDetails.DataSource = query.ToList();

            }
        }

        string getFullName(int month)
        {
            DateTime date = new DateTime(2020, month, 1);
            return date.ToString("MMMM");
        }

    }

}
