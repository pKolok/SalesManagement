
namespace SalesManagement
{
    partial class FormSalesPersonDetails
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
            this.panelSalesPersonDetailsHeader = new System.Windows.Forms.Panel();
            this.labelSalesPersonDetails = new System.Windows.Forms.Label();
            this.btnSalesPersonDetails = new System.Windows.Forms.Button();
            this.dataGridViewSalesPersonDetails = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSalesPersonDetailsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesPersonDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSalesPersonDetailsHeader
            // 
            this.panelSalesPersonDetailsHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSalesPersonDetailsHeader.Controls.Add(this.labelSalesPersonDetails);
            this.panelSalesPersonDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalesPersonDetailsHeader.Location = new System.Drawing.Point(20, 20);
            this.panelSalesPersonDetailsHeader.Name = "panelSalesPersonDetailsHeader";
            this.panelSalesPersonDetailsHeader.Size = new System.Drawing.Size(677, 65);
            this.panelSalesPersonDetailsHeader.TabIndex = 0;
            // 
            // labelSalesPersonDetails
            // 
            this.labelSalesPersonDetails.AutoSize = true;
            this.labelSalesPersonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelSalesPersonDetails.Location = new System.Drawing.Point(156, 17);
            this.labelSalesPersonDetails.Name = "labelSalesPersonDetails";
            this.labelSalesPersonDetails.Size = new System.Drawing.Size(362, 33);
            this.labelSalesPersonDetails.TabIndex = 0;
            this.labelSalesPersonDetails.Text = "<Name of Sales Person>";
            this.labelSalesPersonDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalesPersonDetails
            // 
            this.btnSalesPersonDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalesPersonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesPersonDetails.Location = new System.Drawing.Point(23, 379);
            this.btnSalesPersonDetails.Name = "btnSalesPersonDetails";
            this.btnSalesPersonDetails.Size = new System.Drawing.Size(75, 48);
            this.btnSalesPersonDetails.TabIndex = 6;
            this.btnSalesPersonDetails.Text = "Back";
            this.btnSalesPersonDetails.UseVisualStyleBackColor = false;
            this.btnSalesPersonDetails.Click += new System.EventHandler(this.btnSalesPersonDetails_Click);
            // 
            // dataGridViewSalesPersonDetails
            // 
            this.dataGridViewSalesPersonDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSalesPersonDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewSalesPersonDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesPersonDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.TotalSales,
            this.TotalFees});
            this.dataGridViewSalesPersonDetails.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSalesPersonDetails.Location = new System.Drawing.Point(124, 104);
            this.dataGridViewSalesPersonDetails.Name = "dataGridViewSalesPersonDetails";
            this.dataGridViewSalesPersonDetails.ReadOnly = true;
            this.dataGridViewSalesPersonDetails.Size = new System.Drawing.Size(573, 323);
            this.dataGridViewSalesPersonDetails.TabIndex = 7;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // TotalSales
            // 
            this.TotalSales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSales.DataPropertyName = "TotalSales";
            this.TotalSales.HeaderText = "Total Sales [Euro]";
            this.TotalSales.Name = "TotalSales";
            this.TotalSales.ReadOnly = true;
            // 
            // TotalFees
            // 
            this.TotalFees.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalFees.DataPropertyName = "TotalFees";
            this.TotalFees.HeaderText = "Total Fees [Euro]";
            this.TotalFees.Name = "TotalFees";
            this.TotalFees.ReadOnly = true;
            // 
            // FormSalesPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.dataGridViewSalesPersonDetails);
            this.Controls.Add(this.btnSalesPersonDetails);
            this.Controls.Add(this.panelSalesPersonDetailsHeader);
            this.Name = "FormSalesPersonDetails";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FormSalesPersonDetails";
            this.Load += new System.EventHandler(this.FormSalesPersonDetails_Load);
            this.panelSalesPersonDetailsHeader.ResumeLayout(false);
            this.panelSalesPersonDetailsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesPersonDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSalesPersonDetailsHeader;
        private System.Windows.Forms.Label labelSalesPersonDetails;
        private System.Windows.Forms.Button btnSalesPersonDetails;
        private System.Windows.Forms.DataGridView dataGridViewSalesPersonDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFees;
    }
}