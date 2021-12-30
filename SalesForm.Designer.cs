
namespace CafePOS
{
    partial class SalesForm
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
            this.transactionsTable = new System.Windows.Forms.DataGridView();
            this.csvBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionsTable
            // 
            this.transactionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsTable.Location = new System.Drawing.Point(22, 21);
            this.transactionsTable.Name = "transactionsTable";
            this.transactionsTable.RowTemplate.Height = 25;
            this.transactionsTable.Size = new System.Drawing.Size(752, 326);
            this.transactionsTable.TabIndex = 0;
            // 
            // csvBtn
            // 
            this.csvBtn.Location = new System.Drawing.Point(682, 370);
            this.csvBtn.Name = "csvBtn";
            this.csvBtn.Size = new System.Drawing.Size(92, 26);
            this.csvBtn.TabIndex = 1;
            this.csvBtn.Text = "Export CSV";
            this.csvBtn.UseVisualStyleBackColor = true;
            this.csvBtn.Click += new System.EventHandler(this.csvBtn_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.csvBtn);
            this.Controls.Add(this.transactionsTable);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView transactionsTable;
        private System.Windows.Forms.Button csvBtn;
    }
}