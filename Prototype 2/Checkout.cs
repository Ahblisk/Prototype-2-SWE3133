using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype_2
{
    public partial class Checkout : Form
    {
        double subtotal = 0;
        double taxrate = .08;
        double taxprice = 0;
        double total = 0;
        public Checkout()
        {
            InitializeComponent();
            foreach (ListViewItem item in CheckoutListView.Items)
            {
                subtotal += Convert.ToDouble(item.SubItems[2]);
            }
            taxprice = subtotal * taxrate;
            total = subtotal + taxprice;

            SubtotalLabel.Text = subtotal.ToString();
            TaxLabel.Text = taxprice.ToString();
            TotalLabel.Text = total.ToString();
        }

        private void CheckoutListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
