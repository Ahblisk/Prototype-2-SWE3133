namespace Prototype_2
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuTabCtrl = new System.Windows.Forms.TabControl();
            this.Pizza_Tab = new System.Windows.Forms.TabPage();
            this.PizzaToppingsListBox = new System.Windows.Forms.CheckedListBox();
            this.PizzaCrustListBox = new System.Windows.Forms.ListBox();
            this.PizzaSizeListBox = new System.Windows.Forms.ListBox();
            this.Drinks_Tab = new System.Windows.Forms.TabPage();
            this.DrinkChoiceListBox = new System.Windows.Forms.ListBox();
            this.DrinkSizeListBox = new System.Windows.Forms.ListBox();
            this.Sides_Tab = new System.Windows.Forms.TabPage();
            this.ReceiptListView = new System.Windows.Forms.ListView();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.AddToOrder = new System.Windows.Forms.Button();
            this.ToCheckout = new System.Windows.Forms.Button();
            this.MenuTabCtrl.SuspendLayout();
            this.Pizza_Tab.SuspendLayout();
            this.Drinks_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTabCtrl
            // 
            this.MenuTabCtrl.Controls.Add(this.Pizza_Tab);
            this.MenuTabCtrl.Controls.Add(this.Drinks_Tab);
            this.MenuTabCtrl.Controls.Add(this.Sides_Tab);
            this.MenuTabCtrl.Location = new System.Drawing.Point(11, 12);
            this.MenuTabCtrl.Name = "MenuTabCtrl";
            this.MenuTabCtrl.Padding = new System.Drawing.Point(50, 25);
            this.MenuTabCtrl.SelectedIndex = 0;
            this.MenuTabCtrl.Size = new System.Drawing.Size(581, 333);
            this.MenuTabCtrl.TabIndex = 0;
            // 
            // Pizza_Tab
            // 
            this.Pizza_Tab.Controls.Add(this.PizzaToppingsListBox);
            this.Pizza_Tab.Controls.Add(this.PizzaCrustListBox);
            this.Pizza_Tab.Controls.Add(this.PizzaSizeListBox);
            this.Pizza_Tab.Location = new System.Drawing.Point(4, 73);
            this.Pizza_Tab.Name = "Pizza_Tab";
            this.Pizza_Tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Pizza_Tab.Size = new System.Drawing.Size(573, 256);
            this.Pizza_Tab.TabIndex = 0;
            this.Pizza_Tab.Text = "Pizza";
            this.Pizza_Tab.UseVisualStyleBackColor = true;
            // 
            // PizzaToppingsListBox
            // 
            this.PizzaToppingsListBox.CheckOnClick = true;
            this.PizzaToppingsListBox.FormattingEnabled = true;
            this.PizzaToppingsListBox.Items.AddRange(new object[] {
            "Cheese",
            "Pepperoni",
            "Sausage",
            "Ham",
            "Green Pepper",
            "Onion",
            "Tomato",
            "Mushroom",
            "Pineapple"});
            this.PizzaToppingsListBox.Location = new System.Drawing.Point(248, 24);
            this.PizzaToppingsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PizzaToppingsListBox.MultiColumn = true;
            this.PizzaToppingsListBox.Name = "PizzaToppingsListBox";
            this.PizzaToppingsListBox.Size = new System.Drawing.Size(302, 114);
            this.PizzaToppingsListBox.TabIndex = 5;
            // 
            // PizzaCrustListBox
            // 
            this.PizzaCrustListBox.FormattingEnabled = true;
            this.PizzaCrustListBox.ItemHeight = 20;
            this.PizzaCrustListBox.Items.AddRange(new object[] {
            "Thin",
            "Regular",
            "Pan"});
            this.PizzaCrustListBox.Location = new System.Drawing.Point(134, 24);
            this.PizzaCrustListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PizzaCrustListBox.Name = "PizzaCrustListBox";
            this.PizzaCrustListBox.Size = new System.Drawing.Size(107, 84);
            this.PizzaCrustListBox.TabIndex = 4;
            // 
            // PizzaSizeListBox
            // 
            this.PizzaSizeListBox.FormattingEnabled = true;
            this.PizzaSizeListBox.ItemHeight = 20;
            this.PizzaSizeListBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "Extra Large"});
            this.PizzaSizeListBox.Location = new System.Drawing.Point(7, 24);
            this.PizzaSizeListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PizzaSizeListBox.Name = "PizzaSizeListBox";
            this.PizzaSizeListBox.Size = new System.Drawing.Size(119, 84);
            this.PizzaSizeListBox.TabIndex = 3;
            // 
            // Drinks_Tab
            // 
            this.Drinks_Tab.Controls.Add(this.DrinkChoiceListBox);
            this.Drinks_Tab.Controls.Add(this.DrinkSizeListBox);
            this.Drinks_Tab.Location = new System.Drawing.Point(4, 73);
            this.Drinks_Tab.Name = "Drinks_Tab";
            this.Drinks_Tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Drinks_Tab.Size = new System.Drawing.Size(573, 256);
            this.Drinks_Tab.TabIndex = 1;
            this.Drinks_Tab.Text = "Drinks";
            this.Drinks_Tab.UseVisualStyleBackColor = true;
            // 
            // DrinkChoiceListBox
            // 
            this.DrinkChoiceListBox.FormattingEnabled = true;
            this.DrinkChoiceListBox.ItemHeight = 20;
            this.DrinkChoiceListBox.Items.AddRange(new object[] {
            "Diet Orange",
            "Diet Pepsi",
            "Diet Root Beer",
            "Lemonade",
            "Orange",
            "Pepsi",
            "Root Beer",
            "Sierra Mist"});
            this.DrinkChoiceListBox.Location = new System.Drawing.Point(295, 7);
            this.DrinkChoiceListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrinkChoiceListBox.MultiColumn = true;
            this.DrinkChoiceListBox.Name = "DrinkChoiceListBox";
            this.DrinkChoiceListBox.Size = new System.Drawing.Size(237, 124);
            this.DrinkChoiceListBox.TabIndex = 3;
            this.DrinkChoiceListBox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // DrinkSizeListBox
            // 
            this.DrinkSizeListBox.FormattingEnabled = true;
            this.DrinkSizeListBox.ItemHeight = 20;
            this.DrinkSizeListBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.DrinkSizeListBox.Location = new System.Drawing.Point(18, 35);
            this.DrinkSizeListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrinkSizeListBox.Name = "DrinkSizeListBox";
            this.DrinkSizeListBox.Size = new System.Drawing.Size(231, 64);
            this.DrinkSizeListBox.TabIndex = 2;
            this.DrinkSizeListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Sides_Tab
            // 
            this.Sides_Tab.Location = new System.Drawing.Point(4, 73);
            this.Sides_Tab.Name = "Sides_Tab";
            this.Sides_Tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Sides_Tab.Size = new System.Drawing.Size(573, 256);
            this.Sides_Tab.TabIndex = 2;
            this.Sides_Tab.Text = "Sides";
            this.Sides_Tab.UseVisualStyleBackColor = true;
            // 
            // ReceiptListView
            // 
            this.ReceiptListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.ReceiptListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Description,
            this.Price});
            this.ReceiptListView.FullRowSelect = true;
            this.ReceiptListView.GridLines = true;
            this.ReceiptListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReceiptListView.Location = new System.Drawing.Point(597, 101);
            this.ReceiptListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReceiptListView.Name = "ReceiptListView";
            this.ReceiptListView.ShowGroups = false;
            this.ReceiptListView.Size = new System.Drawing.Size(226, 313);
            this.ReceiptListView.TabIndex = 1;
            this.ReceiptListView.UseCompatibleStateImageBehavior = false;
            this.ReceiptListView.View = System.Windows.Forms.View.Details;
            this.ReceiptListView.SelectedIndexChanged += new System.EventHandler(this.ReceiptListView_SelectedIndexChanged);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 145;
            // 
            // Description
            // 
            this.Description.DisplayIndex = 2;
            this.Description.Text = "Description";
            this.Description.Width = 0;
            // 
            // Price
            // 
            this.Price.DisplayIndex = 1;
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.Width = 50;
            // 
            // AddToOrder
            // 
            this.AddToOrder.Location = new System.Drawing.Point(11, 352);
            this.AddToOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddToOrder.Name = "AddToOrder";
            this.AddToOrder.Size = new System.Drawing.Size(169, 64);
            this.AddToOrder.TabIndex = 2;
            this.AddToOrder.Text = "Add";
            this.AddToOrder.UseVisualStyleBackColor = true;
            this.AddToOrder.Click += new System.EventHandler(this.AddToOrder_Click);
            // 
            // ToCheckout
            // 
            this.ToCheckout.Location = new System.Drawing.Point(418, 352);
            this.ToCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToCheckout.Name = "ToCheckout";
            this.ToCheckout.Size = new System.Drawing.Size(169, 64);
            this.ToCheckout.TabIndex = 3;
            this.ToCheckout.Text = "Checkout";
            this.ToCheckout.UseVisualStyleBackColor = true;
            this.ToCheckout.Click += new System.EventHandler(this.ToCheckout_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(837, 433);
            this.Controls.Add(this.ToCheckout);
            this.Controls.Add(this.AddToOrder);
            this.Controls.Add(this.ReceiptListView);
            this.Controls.Add(this.MenuTabCtrl);
            this.MaximizeBox = false;
            this.Name = "Order";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Order_Load);
            this.MenuTabCtrl.ResumeLayout(false);
            this.Pizza_Tab.ResumeLayout(false);
            this.Drinks_Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MenuTabCtrl;
        private TabPage Pizza_Tab;
        private TabPage Drinks_Tab;
        private TabPage Sides_Tab;
        private ListBox DrinkSizeListBox;
        private ListBox DrinkChoiceListBox;
        private ListView ReceiptListView;
        private Button AddToOrder;
        private ColumnHeader Price;
        private ColumnHeader Item;
        private ListBox PizzaCrustListBox;
        private ListBox PizzaSizeListBox;
        private CheckedListBox PizzaToppingsListBox;
        private ColumnHeader Description;
        private Button ToCheckout;
    }
}