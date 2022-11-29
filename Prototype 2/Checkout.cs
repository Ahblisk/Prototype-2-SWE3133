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
        
        
        public Checkout()
        {
            InitializeComponent();
            
        }

        private void CheckoutListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackToOrderBttn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order has been sent!",
               "Mom & Pop's Pizza Shop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            System.Xml.XmlTextWriter writer = new System.Xml.XmlTextWriter(Application.StartupPath + "\\Receipt.xml", null);

            writer.WriteStartElement("Receipt");
            
            foreach (ListViewItem item in this.CheckoutListView.Items)
            {
                writer.WriteStartElement("Order");
                writer.WriteAttributeString("Item", item.SubItems[0].Text);
                writer.WriteAttributeString("Description", item.SubItems[1].Text);
                writer.WriteAttributeString("Price", item.SubItems[2].Text);
                writer.WriteEndElement();
            }   

            writer.WriteEndElement();
            writer.Close();

            Application.Exit();
        }
    }
}
