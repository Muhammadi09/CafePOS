
namespace CafePOS
{
    partial class AddProductsForm
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
            this.addProductLbl = new System.Windows.Forms.Label();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.addBtnAddProduct = new System.Windows.Forms.Button();
            this.cancelBtnAddproduct = new System.Windows.Forms.Button();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addProductLbl
            // 
            this.addProductLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductLbl.Font = new System.Drawing.Font("Adobe Devanagari", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductLbl.Location = new System.Drawing.Point(0, 0);
            this.addProductLbl.Name = "addProductLbl";
            this.addProductLbl.Size = new System.Drawing.Size(827, 144);
            this.addProductLbl.TabIndex = 1;
            this.addProductLbl.Text = "Add Product";
            this.addProductLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productNameLbl
            // 
            this.productNameLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLbl.Location = new System.Drawing.Point(231, 161);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(107, 20);
            this.productNameLbl.TabIndex = 2;
            this.productNameLbl.Text = "Product Name";
            // 
            // categoryLbl
            // 
            this.categoryLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoryLbl.Location = new System.Drawing.Point(259, 218);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(64, 17);
            this.categoryLbl.TabIndex = 3;
            this.categoryLbl.Text = "Category";
            // 
            // priceLbl
            // 
            this.priceLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.priceLbl.Location = new System.Drawing.Point(285, 277);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(38, 17);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "Price";
            // 
            // productNameBox
            // 
            this.productNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameBox.Location = new System.Drawing.Point(329, 158);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(234, 23);
            this.productNameBox.TabIndex = 5;
            // 
            // categoryBox
            // 
            this.categoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Coffee",
            "Tea",
            "Sandwich",
            "Bakery",
            "Drink"});
            this.categoryBox.Location = new System.Drawing.Point(329, 212);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(234, 23);
            this.categoryBox.TabIndex = 6;
            // 
            // addBtnAddProduct
            // 
            this.addBtnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtnAddProduct.BackColor = System.Drawing.Color.Teal;
            this.addBtnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addBtnAddProduct.Location = new System.Drawing.Point(319, 343);
            this.addBtnAddProduct.Name = "addBtnAddProduct";
            this.addBtnAddProduct.Size = new System.Drawing.Size(110, 34);
            this.addBtnAddProduct.TabIndex = 8;
            this.addBtnAddProduct.Text = "Add";
            this.addBtnAddProduct.UseVisualStyleBackColor = false;
            this.addBtnAddProduct.Click += new System.EventHandler(this.addBtnAddProduct_Click);
            // 
            // cancelBtnAddproduct
            // 
            this.cancelBtnAddproduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtnAddproduct.BackColor = System.Drawing.Color.Brown;
            this.cancelBtnAddproduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtnAddproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBtnAddproduct.Location = new System.Drawing.Point(447, 343);
            this.cancelBtnAddproduct.Name = "cancelBtnAddproduct";
            this.cancelBtnAddproduct.Size = new System.Drawing.Size(116, 34);
            this.cancelBtnAddproduct.TabIndex = 9;
            this.cancelBtnAddproduct.Text = "Cancel";
            this.cancelBtnAddproduct.UseVisualStyleBackColor = false;
            this.cancelBtnAddproduct.Click += new System.EventHandler(this.cancelBtnAddproduct_Click);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(330, 277);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 23);
            this.priceBox.TabIndex = 10;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(827, 527);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.cancelBtnAddproduct);
            this.Controls.Add(this.addBtnAddProduct);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.productNameLbl);
            this.Controls.Add(this.addProductLbl);
            this.MaximumSize = new System.Drawing.Size(843, 566);
            this.MinimumSize = new System.Drawing.Size(843, 566);
            this.Name = "AddProductsForm";
            this.Text = "AddProductsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductLbl;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button addBtnAddProduct;
        private System.Windows.Forms.Button cancelBtnAddproduct;
        private System.Windows.Forms.TextBox priceBox;
    }
}