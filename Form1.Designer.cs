
namespace CafePOS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLbl = new System.Windows.Forms.Label();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.tillBtn = new System.Windows.Forms.Button();
            this.salesBtn = new System.Windows.Forms.Button();
            this.listProductsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLbl.Font = new System.Drawing.Font("Adobe Devanagari", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(0, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(827, 144);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "CafePOS";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addProductBtn
            // 
            this.addProductBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProductBtn.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductBtn.Location = new System.Drawing.Point(286, 139);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(258, 66);
            this.addProductBtn.TabIndex = 1;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // tillBtn
            // 
            this.tillBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tillBtn.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tillBtn.Location = new System.Drawing.Point(286, 302);
            this.tillBtn.Name = "tillBtn";
            this.tillBtn.Size = new System.Drawing.Size(258, 66);
            this.tillBtn.TabIndex = 2;
            this.tillBtn.Text = "Till";
            this.tillBtn.UseVisualStyleBackColor = true;
            this.tillBtn.Click += new System.EventHandler(this.tillBtn_Click);
            // 
            // salesBtn
            // 
            this.salesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salesBtn.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesBtn.Location = new System.Drawing.Point(286, 381);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(258, 68);
            this.salesBtn.TabIndex = 3;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = true;
            // 
            // listProductsBtn
            // 
            this.listProductsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listProductsBtn.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listProductsBtn.Location = new System.Drawing.Point(286, 218);
            this.listProductsBtn.Name = "listProductsBtn";
            this.listProductsBtn.Size = new System.Drawing.Size(258, 68);
            this.listProductsBtn.TabIndex = 4;
            this.listProductsBtn.Text = "List Products";
            this.listProductsBtn.UseVisualStyleBackColor = true;
            this.listProductsBtn.Click += new System.EventHandler(this.listProductsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 527);
            this.Controls.Add(this.listProductsBtn);
            this.Controls.Add(this.salesBtn);
            this.Controls.Add(this.tillBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.titleLbl);
            this.MinimumSize = new System.Drawing.Size(843, 566);
            this.Name = "Form1";
            this.Text = "CafePOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button tillBtn;
        private System.Windows.Forms.Button salesBtn;
        private System.Windows.Forms.Button listProductsBtn;
    }
}

