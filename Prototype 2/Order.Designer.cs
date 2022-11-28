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
            this.Drinks_Tab = new System.Windows.Forms.TabPage();
            this.Sides_Tab = new System.Windows.Forms.TabPage();
            this.DrinkSizeListBox = new System.Windows.Forms.CheckedListBox();
            this.MenuTabCtrl.SuspendLayout();
            this.Drinks_Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTabCtrl
            // 
            this.MenuTabCtrl.Controls.Add(this.Pizza_Tab);
            this.MenuTabCtrl.Controls.Add(this.Drinks_Tab);
            this.MenuTabCtrl.Controls.Add(this.Sides_Tab);
            this.MenuTabCtrl.Location = new System.Drawing.Point(12, 12);
            this.MenuTabCtrl.Name = "MenuTabCtrl";
            this.MenuTabCtrl.Padding = new System.Drawing.Point(50, 25);
            this.MenuTabCtrl.SelectedIndex = 0;
            this.MenuTabCtrl.Size = new System.Drawing.Size(581, 409);
            this.MenuTabCtrl.TabIndex = 0;
            // 
            // Pizza_Tab
            // 
            this.Pizza_Tab.Location = new System.Drawing.Point(4, 73);
            this.Pizza_Tab.Name = "Pizza_Tab";
            this.Pizza_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Pizza_Tab.Size = new System.Drawing.Size(573, 332);
            this.Pizza_Tab.TabIndex = 0;
            this.Pizza_Tab.Text = "Pizza";
            this.Pizza_Tab.UseVisualStyleBackColor = true;
            // 
            // Drinks_Tab
            // 
            this.Drinks_Tab.Controls.Add(this.DrinkSizeListBox);
            this.Drinks_Tab.Location = new System.Drawing.Point(4, 73);
            this.Drinks_Tab.Name = "Drinks_Tab";
            this.Drinks_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Drinks_Tab.Size = new System.Drawing.Size(573, 332);
            this.Drinks_Tab.TabIndex = 1;
            this.Drinks_Tab.Text = "Drinks";
            this.Drinks_Tab.UseVisualStyleBackColor = true;
            // 
            // Sides_Tab
            // 
            this.Sides_Tab.Location = new System.Drawing.Point(4, 73);
            this.Sides_Tab.Name = "Sides_Tab";
            this.Sides_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Sides_Tab.Size = new System.Drawing.Size(573, 332);
            this.Sides_Tab.TabIndex = 2;
            this.Sides_Tab.Text = "Sides";
            this.Sides_Tab.UseVisualStyleBackColor = true;
            // 
            // DrinkSizeListBox
            // 
            this.DrinkSizeListBox.FormattingEnabled = true;
            this.DrinkSizeListBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.DrinkSizeListBox.Location = new System.Drawing.Point(0, 0);
            this.DrinkSizeListBox.Name = "DrinkSizeListBox";
            this.DrinkSizeListBox.Size = new System.Drawing.Size(150, 70);
            this.DrinkSizeListBox.TabIndex = 0;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 433);
            this.Controls.Add(this.MenuTabCtrl);
            this.Name = "Order";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Order_Load);
            this.MenuTabCtrl.ResumeLayout(false);
            this.Drinks_Tab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MenuTabCtrl;
        private TabPage Pizza_Tab;
        private TabPage Drinks_Tab;
        private TabPage Sides_Tab;
        private CheckedListBox DrinkSizeListBox;
    }
}