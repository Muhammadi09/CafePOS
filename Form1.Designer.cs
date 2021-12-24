
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
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Adobe Devanagari", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(302, 53);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(191, 65);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "CafePOS";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductBtn.Location = new System.Drawing.Point(286, 159);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(207, 38);
            this.addProductBtn.TabIndex = 1;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = true;
            // 
            // tillBtn
            // 
            this.tillBtn.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tillBtn.Location = new System.Drawing.Point(286, 219);
            this.tillBtn.Name = "tillBtn";
            this.tillBtn.Size = new System.Drawing.Size(207, 38);
            this.tillBtn.TabIndex = 2;
            this.tillBtn.Text = "Till";
            this.tillBtn.UseVisualStyleBackColor = true;
            // 
            // salesBtn
            // 
            this.salesBtn.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salesBtn.Location = new System.Drawing.Point(286, 282);
            this.salesBtn.Name = "salesBtn";
            this.salesBtn.Size = new System.Drawing.Size(207, 40);
            this.salesBtn.TabIndex = 3;
            this.salesBtn.Text = "Sales";
            this.salesBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salesBtn);
            this.Controls.Add(this.tillBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form1";
            this.Text = "CafePOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button tillBtn;
        private System.Windows.Forms.Button salesBtn;
    }
}

