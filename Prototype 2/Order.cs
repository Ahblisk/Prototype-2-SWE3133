﻿using System;
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
    }
}
