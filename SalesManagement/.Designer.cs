
namespace SalesManagement
{
    partial class FormSalesPersons
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.FormLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SalesPersonsDgv = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.btnSalesPersonsBack = new System.Windows.Forms.Button();
            this.btnSalesPersonDetails = new System.Windows.Forms.Button();
            this.SalesPersonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HeaderPanel.Controls.Add(this.FormLabel);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(20, 20);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(799, 65);
            this.HeaderPanel.TabIndex = 0;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormLabel.Location = new System.Drawing.Point(252, 17);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(216, 33);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "Sales Persons";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 106);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(80, 20);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Full Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(111, 103);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 26);
            this.NameTextBox.TabIndex = 2;
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(20, 355);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 43);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SalesPersonsDgv
            // 
            this.SalesPersonsDgv.AllowUserToDeleteRows = false;
            this.SalesPersonsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesPersonsDgv.BackgroundColor = System.Drawing.Color.White;
            this.SalesPersonsDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SalesPersonsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SalesPersonsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesPersonsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesPersonID,
            this.SalesPersonName,
            this.Fees});
            this.SalesPersonsDgv.GridColor = System.Drawing.SystemColors.Control;
            this.SalesPersonsDgv.Location = new System.Drawing.Point(278, 103);
            this.SalesPersonsDgv.Name = "SalesPersonsDgv";
            this.SalesPersonsDgv.ReadOnly = true;
            this.SalesPersonsDgv.Size = new System.Drawing.Size(541, 353);
            this.SalesPersonsDgv.TabIndex = 4;
            this.SalesPersonsDgv.DoubleClick += new System.EventHandler(this.SalesPersonsDgv_DoubleClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(101, 355);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 43);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(182, 355);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 43);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // btnSalesPersonsBack
            // 
            this.btnSalesPersonsBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalesPersonsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesPersonsBack.Location = new System.Drawing.Point(20, 416);
            this.btnSalesPersonsBack.Name = "btnSalesPersonsBack";
            this.btnSalesPersonsBack.Size = new System.Drawing.Size(75, 40);
            this.btnSalesPersonsBack.TabIndex = 5;
            this.btnSalesPersonsBack.Text = "Back";
            this.btnSalesPersonsBack.UseVisualStyleBackColor = false;
            this.btnSalesPersonsBack.Click += new System.EventHandler(this.btnSalesPersonsBack_Click);
            // 
            // btnSalesPersonDetails
            // 
            this.btnSalesPersonDetails.Location = new System.Drawing.Point(23, 165);
            this.btnSalesPersonDetails.Name = "btnSalesPersonDetails";
            this.btnSalesPersonDetails.Size = new System.Drawing.Size(234, 153);
            this.btnSalesPersonDetails.TabIndex = 3;
            this.btnSalesPersonDetails.Text = "Details";
            this.btnSalesPersonDetails.UseVisualStyleBackColor = true;
            this.btnSalesPersonDetails.Click += new System.EventHandler(this.btnSalesPersonDetails_Click);
            // 
            // SalesPersonID
            // 
            this.SalesPersonID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesPersonID.DataPropertyName = "ID";
            this.SalesPersonID.HeaderText = "ID";
            this.SalesPersonID.Name = "SalesPersonID";
            this.SalesPersonID.ReadOnly = true;
            // 
            // SalesPersonName
            // 
            this.SalesPersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesPersonName.DataPropertyName = "Name";
            this.SalesPersonName.HeaderText = "Full Name";
            this.SalesPersonName.Name = "SalesPersonName";
            this.SalesPersonName.ReadOnly = true;
            // 
            // Fees
            // 
            this.Fees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fees.DataPropertyName = "Fees";
            this.Fees.HeaderText = "Fees [Euro]";
            this.Fees.Name = "Fees";
            this.Fees.ReadOnly = true;
            // 
            // FormSalesPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(839, 471);
            this.Controls.Add(this.btnSalesPersonsBack);
            this.Controls.Add(this.SalesPersonsDgv);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.btnSalesPersonDetails);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSalesPersons";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Persons";
            this.Load += new System.EventHandler(this.FormSalesPersons_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPersonsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.DataGridView SalesPersonsDgv;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button btnSalesPersonsBack;
        private System.Windows.Forms.Button btnSalesPersonDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPersonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fees;
    }
}

