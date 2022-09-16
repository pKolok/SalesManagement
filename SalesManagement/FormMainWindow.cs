using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
        }

        private void btnMainWindowSalesPersons_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalesPersons formSalesPersons = new FormSalesPersons();
            formSalesPersons.ShowDialog();
        }

        private void btnMainWindowSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSales formSales = new FormSales();
            formSales.ShowDialog();
        }

        private void btnMainWindowExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            using (DBEntities db = new DBEntities())
            {
                int count = db.SalesPersons.Count();
                LabelMainWindowSalesPersonsNumber.Text = Convert.ToString(
                    db.SalesPersons.Count());
                LabelMainWindowSalesNumber.Text = Convert.ToString(
                    db.Sales.Sum(i => i.Amount));
            }
        }

    }
}
