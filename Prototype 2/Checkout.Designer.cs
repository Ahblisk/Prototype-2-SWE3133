namespace Prototype_2
{
    partial class Checkout
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
            this.CheckoutListView = new System.Windows.Forms.ListView();
            this.Item = new System.Windows.Forms.ColumnHeader();
            this.Description = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.BackToOrderBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckoutListView
            // 
            this.CheckoutListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Description,
            this.Price});
            this.CheckoutListView.FullRowSelect = true;
            this.CheckoutListView.GridLines = true;
            this.CheckoutListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CheckoutListView.Location = new System.Drawing.Point(14, 16);
            this.CheckoutListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckoutListView.Name = "CheckoutListView";
            this.CheckoutListView.Size = new System.Drawing.Size(522, 567);
            this.CheckoutListView.TabIndex = 0;
            this.CheckoutListView.UseCompatibleStateImageBehavior = false;
            this.CheckoutListView.View = System.Windows.Forms.View.Details;
            this.CheckoutListView.SelectedIndexChanged += new System.EventHandler(this.CheckoutListView_SelectedIndexChanged);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 150;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Description.Width = 200;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subtotal: ";
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(683, 231);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(18, 20);
            this.SubtotalLabel.TabIndex = 2;
            this.SubtotalLabel.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tax: ";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(683, 251);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(18, 20);
            this.TaxLabel.TabIndex = 4;
            this.TaxLabel.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total: ";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(683, 271);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(18, 20);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "...";
            // 
            // BackToOrderBttn
            // 
            this.BackToOrderBttn.Location = new System.Drawing.Point(585, 314);
            this.BackToOrderBttn.Name = "BackToOrderBttn";
            this.BackToOrderBttn.Size = new System.Drawing.Size(94, 29);
            this.BackToOrderBttn.TabIndex = 7;
            this.BackToOrderBttn.Text = "Order More";
            this.BackToOrderBttn.UseVisualStyleBackColor = true;
            this.BackToOrderBttn.Click += new System.EventHandler(this.BackToOrderBttn_Click);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.BackToOrderBttn);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckoutListView);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListView CheckoutListView;
        private ColumnHeader Item;
        private ColumnHeader Description;
        private ColumnHeader Price;
        private Label label1;
        internal Label SubtotalLabel;
        private Label label3;
        internal Label TaxLabel;
        private Label label5;
        internal Label TotalLabel;
        private Button BackToOrderBttn;
    }
}