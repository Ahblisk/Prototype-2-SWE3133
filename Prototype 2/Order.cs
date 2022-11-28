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
                        switch (PizzaSizeListBox.SelectedIndex)
                        {
                            case 0: item.SubItems.Add("4.00"); break;
                            case 1: item.SubItems.Add("6.00"); break;
                            case 2: item.SubItems.Add("8.00"); break;
                            case 3: item.SubItems.Add("10.00"); break;
                        }
                        string toppingstring = "";
                        foreach (object t in PizzaToppingsListBox.CheckedItems)
                        {
                            toppingstring += t + " ";
                        }
                        item.SubItems.Add(toppingstring);
                        this.ReceiptListView.Items.Add(item);
                        break;
                    }
                /* Drinks */
                case 1:
                    {
                        ListViewItem item = new ListViewItem(DrinkSizeListBox.SelectedItem.ToString() + " - " + DrinkChoiceListBox.SelectedItem.ToString());
                        item.SubItems.Add("1.00");
                        this.ReceiptListView.Items.Add(item);
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
    }
}
