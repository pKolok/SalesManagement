
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
            this.SalesDgv = new System.Windows.Forms.DataGridView();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.btnSalesBack = new System.Windows.Forms.Button();
            this.datePickerSales = new System.Windows.Forms.DateTimePicker();
            this.labelSalesSalesPerson = new System.Windows.Forms.Label();
            this.labelSalesSalesPersonsID = new System.Windows.Forms.Label();
            this.comboBoxSalesSalesPersonID = new System.Windows.Forms.ComboBox();
            this.textBoxSalesSalesPersonName = new System.Windows.Forms.TextBox();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlSalesTitle.Size = new System.Drawing.Size(802, 65);
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
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(17, 195);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(59, 18);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(16, 234);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(39, 18);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTextBox.Location = new System.Drawing.Point(137, 191);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(157, 26);
            this.AmountTextBox.TabIndex = 3;
            // 
            // SalesDgv
            // 
            this.SalesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesDgv.BackgroundColor = System.Drawing.Color.White;
            this.SalesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.SalesPersonID,
            this.SalesPersonName,
            this.Amount,
            this.Date});
            this.SalesDgv.Location = new System.Drawing.Point(308, 107);
            this.SalesDgv.Name = "SalesDgv";
            this.SalesDgv.Size = new System.Drawing.Size(514, 318);
            this.SalesDgv.TabIndex = 4;
            this.SalesDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesDgv_CellDoubleClick);
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
            // datePickerSales
            // 
            this.datePickerSales.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerSales.Location = new System.Drawing.Point(136, 234);
            this.datePickerSales.Name = "datePickerSales";
            this.datePickerSales.Size = new System.Drawing.Size(157, 20);
            this.datePickerSales.TabIndex = 6;
            // 
            // labelSalesSalesPerson
            // 
            this.labelSalesSalesPerson.AutoSize = true;
            this.labelSalesSalesPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesSalesPerson.Location = new System.Drawing.Point(16, 155);
            this.labelSalesSalesPerson.Name = "labelSalesSalesPerson";
            this.labelSalesSalesPerson.Size = new System.Drawing.Size(97, 18);
            this.labelSalesSalesPerson.TabIndex = 2;
            this.labelSalesSalesPerson.Text = "Sales Person";
            // 
            // labelSalesSalesPersonsID
            // 
            this.labelSalesSalesPersonsID.AutoSize = true;
            this.labelSalesSalesPersonsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesSalesPersonsID.Location = new System.Drawing.Point(16, 111);
            this.labelSalesSalesPersonsID.Name = "labelSalesSalesPersonsID";
            this.labelSalesSalesPersonsID.Size = new System.Drawing.Size(115, 18);
            this.labelSalesSalesPersonsID.TabIndex = 2;
            this.labelSalesSalesPersonsID.Text = "Sales Person ID";
            // 
            // comboBoxSalesSalesPersonID
            // 
            this.comboBoxSalesSalesPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSalesSalesPersonID.FormattingEnabled = true;
            this.comboBoxSalesSalesPersonID.Location = new System.Drawing.Point(137, 107);
            this.comboBoxSalesSalesPersonID.Name = "comboBoxSalesSalesPersonID";
            this.comboBoxSalesSalesPersonID.Size = new System.Drawing.Size(157, 28);
            this.comboBoxSalesSalesPersonID.TabIndex = 7;
            this.comboBoxSalesSalesPersonID.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalesSalesPersonID_SelectedIndexChanged);
            // 
            // textBoxSalesSalesPersonName
            // 
            this.textBoxSalesSalesPersonName.Enabled = false;
            this.textBoxSalesSalesPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalesSalesPersonName.Location = new System.Drawing.Point(137, 151);
            this.textBoxSalesSalesPersonName.Name = "textBoxSalesSalesPersonName";
            this.textBoxSalesSalesPersonName.Size = new System.Drawing.Size(157, 26);
            this.textBoxSalesSalesPersonName.TabIndex = 3;
            // 
            // SalesID
            // 
            this.SalesID.DataPropertyName = "ID";
            this.SalesID.HeaderText = "Sales ID";
            this.SalesID.Name = "SalesID";
            this.SalesID.Visible = false;
            // 
            // SalesPersonID
            // 
            this.SalesPersonID.DataPropertyName = "SalesPersonID";
            this.SalesPersonID.HeaderText = "Sales Person ID";
            this.SalesPersonID.Name = "SalesPersonID";
            this.SalesPersonID.Visible = false;
            // 
            // SalesPersonName
            // 
            this.SalesPersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesPersonName.DataPropertyName = "SalesPerson";
            this.SalesPersonName.HeaderText = "Sales Person";
            this.SalesPersonName.Name = "SalesPersonName";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount [Euros]";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(842, 446);
            this.Controls.Add(this.comboBoxSalesSalesPersonID);
            this.Controls.Add(this.datePickerSales);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.btnSalesBack);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.SalesDgv);
            this.Controls.Add(this.textBoxSalesSalesPersonName);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.labelSalesSalesPersonsID);
            this.Controls.Add(this.labelSalesSalesPerson);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.pnlSalesTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSales";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.FormSales_Load);
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
        private System.Windows.Forms.DataGridView SalesDgv;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button btnSalesBack;
        private System.Windows.Forms.DateTimePicker datePickerSales;
        private System.Windows.Forms.Label labelSalesSalesPerson;
        private System.Windows.Forms.Label labelSalesSalesPersonsID;
        private System.Windows.Forms.ComboBox comboBoxSalesSalesPersonID;
        private System.Windows.Forms.TextBox textBoxSalesSalesPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}