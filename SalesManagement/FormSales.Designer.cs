
namespace SalesManagement
{
    partial class FormSales
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
            this.pnlSalesTitle = new System.Windows.Forms.Panel();
            this.LabelSales = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.SalesDgv = new System.Windows.Forms.DataGridView();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.btnSalesBack = new System.Windows.Forms.Button();
            this.pnlSalesTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSalesTitle
            // 
            this.pnlSalesTitle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlSalesTitle.Controls.Add(this.LabelSales);
            this.pnlSalesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSalesTitle.Location = new System.Drawing.Point(20, 20);
            this.pnlSalesTitle.Name = "pnlSalesTitle";
            this.pnlSalesTitle.Size = new System.Drawing.Size(701, 65);
            this.pnlSalesTitle.TabIndex = 1;
            // 
            // LabelSales
            // 
            this.LabelSales.AutoSize = true;
            this.LabelSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSales.Location = new System.Drawing.Point(282, 16);
            this.LabelSales.Name = "LabelSales";
            this.LabelSales.Size = new System.Drawing.Size(93, 33);
            this.LabelSales.TabIndex = 0;
            this.LabelSales.Text = "Sales";
            this.LabelSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(23, 110);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(65, 20);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(23, 142);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 20);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.Location = new System.Drawing.Point(105, 107);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(154, 26);
            this.AmountTextBox.TabIndex = 3;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.Location = new System.Drawing.Point(105, 137);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(154, 26);
            this.DateTextBox.TabIndex = 3;
            // 
            // SalesDgv
            // 
            this.SalesDgv.BackgroundColor = System.Drawing.Color.White;
            this.SalesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.SalesPersonID,
            this.SalesPersonName,
            this.Amount,
            this.Date});
            this.SalesDgv.Location = new System.Drawing.Point(282, 107);
            this.SalesDgv.Name = "SalesDgv";
            this.SalesDgv.Size = new System.Drawing.Size(436, 320);
            this.SalesDgv.TabIndex = 4;
            // 
            // SalesID
            // 
            this.SalesID.HeaderText = "Sales ID";
            this.SalesID.Name = "SalesID";
            this.SalesID.Visible = false;
            // 
            // SalesPersonID
            // 
            this.SalesPersonID.HeaderText = "Sales Person ID";
            this.SalesPersonID.Name = "SalesPersonID";
            this.SalesPersonID.Visible = false;
            // 
            // SalesPersonName
            // 
            this.SalesPersonName.DataPropertyName = "SalesPersonName";
            this.SalesPersonName.HeaderText = "Sales Person Name";
            this.SalesPersonName.Name = "SalesPersonName";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(27, 319);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 48);
            this.InsertButton.TabIndex = 5;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(108, 319);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 48);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(187, 319);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 48);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // btnSalesBack
            // 
            this.btnSalesBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalesBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesBack.Location = new System.Drawing.Point(27, 379);
            this.btnSalesBack.Name = "btnSalesBack";
            this.btnSalesBack.Size = new System.Drawing.Size(75, 48);
            this.btnSalesBack.TabIndex = 5;
            this.btnSalesBack.Text = "Back";
            this.btnSalesBack.UseVisualStyleBackColor = false;
            this.btnSalesBack.Click += new System.EventHandler(this.btnSalesBack_Click);
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.btnSalesBack);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.SalesDgv);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.pnlSalesTitle);
            this.Name = "FormSales";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.pnlSalesTitle.ResumeLayout(false);
            this.pnlSalesTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalesTitle;
        private System.Windows.Forms.Label LabelSales;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.DataGridView SalesDgv;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnSalesBack;
    }
}