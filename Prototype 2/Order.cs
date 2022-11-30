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
    public partial class Order : Form
    {
        Checkout chk = new Checkout();
        public enum Toppings
        {
            Cheese,
            Pepperoni,
            Sausage,
            Ham,
            GreenPepper,
            Onion,
            Tomato,
            Mushroom,
            Pineapple
        }

        Toppings[] toppings = new Toppings[9]; ///cheese and 8 other toppings options


        public Order()
        {
            InitializeComponent();

        }
        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void DrinkSizeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReceiptListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToOrder_Click(object sender, EventArgs e)
        {
            switch (this.MenuTabCtrl.SelectedIndex)
            {
                /* Pizza */
                case 0:
                    {
                        ListViewItem item = new ListViewItem(PizzaSizeListBox.Text.ToString() + " - " + PizzaCrustListBox.Text.ToString() + " Pizza");
                        ListViewItem chkitem = new ListViewItem(PizzaSizeListBox.Text.ToString() + " - " + PizzaCrustListBox.Text.ToString() + " Pizza");
                        
                        string toppingstring = "";
                        foreach (object t in PizzaToppingsListBox.CheckedItems)
                        {
                            toppingstring += t + " ";
                        }
                        item.SubItems.Add(toppingstring);
                        chkitem.SubItems.Add(toppingstring);


                        switch (PizzaSizeListBox.SelectedIndex)
                        {
                            /* small */case 0: double smallprice = (PizzaToppingsListBox.CheckedItems.Count > 2) ? 4.00 + (.50 * (PizzaToppingsListBox.CheckedItems.Count - 2)) : 4.00;  item.SubItems.Add(smallprice.ToString()); chkitem.SubItems.Add(smallprice.ToString()); break;
                            /* medium */case 1: double mediumprice = (PizzaToppingsListBox.CheckedItems.Count > 2) ? 6.00 + (.75 * (PizzaToppingsListBox.CheckedItems.Count - 2)) : 6.00;  item.SubItems.Add(mediumprice.ToString()); chkitem.SubItems.Add(mediumprice.ToString()); break;
                            /* large */case 2: double largeprice = (PizzaToppingsListBox.CheckedItems.Count > 2) ? 8.00 + (1.00 * (PizzaToppingsListBox.CheckedItems.Count - 2)) : 8.00; item.SubItems.Add(largeprice.ToString()); chkitem.SubItems.Add(largeprice.ToString()); break;
                            /* x-large */case 3: double xlprice = (PizzaToppingsListBox.CheckedItems.Count > 2) ? 10.00 + (1.25 * (PizzaToppingsListBox.CheckedItems.Count - 2)) : 10.00; item.SubItems.Add(xlprice.ToString()); chkitem.SubItems.Add(xlprice.ToString()); break;
                        }
                        chk.CheckoutListView.Items.Add(item);
                        this.ReceiptListView.Items.Add(chkitem);
                        UpdatePricing();
                        break;
                    }
                /* Drinks */
                case 1:
                    {
                        ListViewItem item = new ListViewItem(DrinkChoiceListBox.SelectedItem.ToString());
                        ListViewItem chkitem = new ListViewItem(DrinkChoiceListBox.SelectedItem.ToString());
                        item.SubItems.Add(DrinkSizeListBox.SelectedItem.ToString());
                        chkitem.SubItems.Add(DrinkSizeListBox.SelectedItem.ToString());
                        item.SubItems.Add("1.00");
                        chkitem.SubItems.Add("1.00");
                        chk.CheckoutListView.Items.Add(chkitem);
                        this.ReceiptListView.Items.Add(item);
                        UpdatePricing();
                        break;
                    }
                /* Sides */
                case 2:
                    {

                        break;
                    }
            }
            //ListViewItem item = new ListViewItem();
        }

        

        private void PizzaToppingsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && PizzaToppingsListBox.CheckedItems.Count >= 4)
                e.NewValue = CheckState.Unchecked;

            
        }

        private void UpdatePricing()
        {
            double subtotal = 0;
            double taxrate = .08;
            double taxprice = 0;
            double total = 0;

            foreach (ListViewItem item in chk.CheckoutListView.Items)
            {
                subtotal += Convert.ToDouble(item.SubItems[2].Text);
            }
            taxprice = subtotal * taxrate;
            total = subtotal + taxprice;

            chk.SubtotalLabel.Text = "$" + subtotal.ToString();
            chk.TaxLabel.Text = "$" + taxprice.ToString();
            chk.TotalLabel.Text = "$" + total.ToString();
        }

        private void ToCheckout_Click(object sender, EventArgs e)
        {
            UpdatePricing();
            chk.Show();
        }

        private void PizzaToppingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Breadsticks");
            ListViewItem chkitem = new ListViewItem("Breadsticks");
            item.SubItems.Add("N/A");
            chkitem.SubItems.Add("N/A");
            item.SubItems.Add("4.00");
            chkitem.SubItems.Add("4.00");
            chk.CheckoutListView.Items.Add(chkitem);
            this.ReceiptListView.Items.Add(item);
            UpdatePricing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Breadstick Bites");
            ListViewItem chkitem = new ListViewItem("Breadstick Bites");
            item.SubItems.Add("N/A");
            chkitem.SubItems.Add("N/A");
            item.SubItems.Add("2.00");
            chkitem.SubItems.Add("2.00");
            chk.CheckoutListView.Items.Add(chkitem);
            this.ReceiptListView.Items.Add(item);
            UpdatePricing();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Chocolate Chip Cookie");
            ListViewItem chkitem = new ListViewItem("Chocolate Chip Cookie");
            item.SubItems.Add("Big");
            chkitem.SubItems.Add("Big");
            item.SubItems.Add("4.00");
            chkitem.SubItems.Add("4.00");
            chk.CheckoutListView.Items.Add(chkitem);
            this.ReceiptListView.Items.Add(item);
            UpdatePricing();
        }
    }
}
