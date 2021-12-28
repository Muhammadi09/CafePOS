
namespace CafePOS
{
    partial class TillForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.categoryPanel = new System.Windows.Forms.TabControl();
            this.productInfoBox = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Till";
            // 
            // productsListBox
            // 
            this.productsListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 15;
            this.productsListBox.Location = new System.Drawing.Point(570, 68);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(310, 319);
            this.productsListBox.TabIndex = 1;
            this.productsListBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.productsListBox_Format);
            // 
            // categoryPanel
            // 
            this.categoryPanel.Location = new System.Drawing.Point(39, 142);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.SelectedIndex = 0;
            this.categoryPanel.Size = new System.Drawing.Size(512, 281);
            this.categoryPanel.TabIndex = 4;
            // 
            // productInfoBox
            // 
            this.productInfoBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productInfoBox.Location = new System.Drawing.Point(39, 68);
            this.productInfoBox.Name = "productInfoBox";
            this.productInfoBox.Size = new System.Drawing.Size(333, 35);
            this.productInfoBox.TabIndex = 5;
            this.productInfoBox.Text = "Next Item";
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.payBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payBtn.Location = new System.Drawing.Point(39, 439);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(110, 40);
            this.payBtn.TabIndex = 6;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Red;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.Location = new System.Drawing.Point(570, 447);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(124, 32);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete Item";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Red;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelBtn.Location = new System.Drawing.Point(770, 441);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(110, 40);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalPriceBox.Location = new System.Drawing.Point(756, 393);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.Size = new System.Drawing.Size(124, 29);
            this.totalPriceBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(646, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total to pay:";
            // 
            // TillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalPriceBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.productInfoBox);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(931, 543);
            this.MinimumSize = new System.Drawing.Size(931, 543);
            this.Name = "TillForm";
            this.Text = "TillForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox productsListBox;
        private System.Windows.Forms.TabControl categoryPanel;
        private System.Windows.Forms.TextBox productInfoBox;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox totalPriceBox;
        private System.Windows.Forms.Label label2;
    }
}