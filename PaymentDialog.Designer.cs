
namespace CafePOS
{
    partial class PaymentDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.amountToPayTextBox = new System.Windows.Forms.TextBox();
            this.paymentGivenTextBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount to pay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment given";
            // 
            // amountToPayTextBox
            // 
            this.amountToPayTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountToPayTextBox.Location = new System.Drawing.Point(162, 59);
            this.amountToPayTextBox.Name = "amountToPayTextBox";
            this.amountToPayTextBox.ReadOnly = true;
            this.amountToPayTextBox.Size = new System.Drawing.Size(202, 29);
            this.amountToPayTextBox.TabIndex = 2;
            // 
            // paymentGivenTextBox
            // 
            this.paymentGivenTextBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.paymentGivenTextBox.Location = new System.Drawing.Point(162, 117);
            this.paymentGivenTextBox.Name = "paymentGivenTextBox";
            this.paymentGivenTextBox.Size = new System.Drawing.Size(202, 29);
            this.paymentGivenTextBox.TabIndex = 3;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.okBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.okBtn.Location = new System.Drawing.Point(138, 188);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(118, 33);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // PaymentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 244);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.paymentGivenTextBox);
            this.Controls.Add(this.amountToPayTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(411, 283);
            this.MinimumSize = new System.Drawing.Size(411, 283);
            this.Name = "PaymentDialog";
            this.Text = "PaymentDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountToPayTextBox;
        private System.Windows.Forms.TextBox paymentGivenTextBox;
        private System.Windows.Forms.Button okBtn;
    }
}