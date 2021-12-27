
namespace CafePOS
{
    partial class ListProductForm
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
            this.productListDataView = new System.Windows.Forms.DataGridView();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.categoryFilterBox = new System.Windows.Forms.ComboBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // productListDataView
            // 
            this.productListDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListDataView.Location = new System.Drawing.Point(41, 42);
            this.productListDataView.Name = "productListDataView";
            this.productListDataView.RowTemplate.Height = 25;
            this.productListDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productListDataView.Size = new System.Drawing.Size(703, 253);
            this.productListDataView.TabIndex = 0;
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.BackColor = System.Drawing.Color.LightCoral;
            this.deleteProductBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteProductBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteProductBtn.Location = new System.Drawing.Point(397, 346);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(141, 44);
            this.deleteProductBtn.TabIndex = 1;
            this.deleteProductBtn.Text = "Delete Product";
            this.deleteProductBtn.UseVisualStyleBackColor = false;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addProductBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addProductBtn.Location = new System.Drawing.Point(256, 346);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(124, 44);
            this.addProductBtn.TabIndex = 2;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // categoryFilterBox
            // 
            this.categoryFilterBox.FormattingEnabled = true;
            this.categoryFilterBox.Items.AddRange(new object[] {
            "Coffee",
            "Tea",
            "Sandwich",
            "Bakery",
            "Drink"});
            this.categoryFilterBox.Location = new System.Drawing.Point(41, 324);
            this.categoryFilterBox.Name = "categoryFilterBox";
            this.categoryFilterBox.Size = new System.Drawing.Size(165, 23);
            this.categoryFilterBox.TabIndex = 3;
            this.categoryFilterBox.SelectedIndexChanged += new System.EventHandler(this.categoryFilterBox_SelectedIndexChanged);
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CategoryLbl.Location = new System.Drawing.Point(41, 302);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(57, 15);
            this.CategoryLbl.TabIndex = 4;
            this.CategoryLbl.Text = "Category";
            // 
            // ListProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.categoryFilterBox);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.productListDataView);
            this.Name = "ListProductForm";
            this.Text = "ListProductForm";
            this.Load += new System.EventHandler(this.ListProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productListDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productListDataView;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.ComboBox categoryFilterBox;
        private System.Windows.Forms.Label CategoryLbl;
    }
}