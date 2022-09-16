
namespace SalesManagement
{
    partial class FormMainWindow
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
            this.panelSalesManager = new System.Windows.Forms.Panel();
            this.labelSalesManager = new System.Windows.Forms.Label();
            this.labelMainWindowSalesPerson = new System.Windows.Forms.Label();
            this.labelMainWindowSales = new System.Windows.Forms.Label();
            this.LabelMainWindowSalesPersonsNumber = new System.Windows.Forms.Label();
            this.LabelMainWindowSalesNumber = new System.Windows.Forms.Label();
            this.btnMainWindowSalesPersons = new System.Windows.Forms.Button();
            this.btnMainWindowSales = new System.Windows.Forms.Button();
            this.btnMainWindowExit = new System.Windows.Forms.Button();
            this.panelSalesManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSalesManager
            // 
            this.panelSalesManager.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelSalesManager.Controls.Add(this.labelSalesManager);
            this.panelSalesManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalesManager.Location = new System.Drawing.Point(20, 20);
            this.panelSalesManager.Name = "panelSalesManager";
            this.panelSalesManager.Size = new System.Drawing.Size(485, 65);
            this.panelSalesManager.TabIndex = 0;
            // 
            // labelSalesManager
            // 
            this.labelSalesManager.AutoSize = true;
            this.labelSalesManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.labelSalesManager.Location = new System.Drawing.Point(139, 15);
            this.labelSalesManager.Name = "labelSalesManager";
            this.labelSalesManager.Size = new System.Drawing.Size(223, 33);
            this.labelSalesManager.TabIndex = 0;
            this.labelSalesManager.Text = "Sales Manager";
            // 
            // labelMainWindowSalesPerson
            // 
            this.labelMainWindowSalesPerson.AutoSize = true;
            this.labelMainWindowSalesPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowSalesPerson.Location = new System.Drawing.Point(59, 133);
            this.labelMainWindowSalesPerson.Name = "labelMainWindowSalesPerson";
            this.labelMainWindowSalesPerson.Size = new System.Drawing.Size(149, 24);
            this.labelMainWindowSalesPerson.TabIndex = 1;
            this.labelMainWindowSalesPerson.Text = "Sales Persons:";
            // 
            // labelMainWindowSales
            // 
            this.labelMainWindowSales.AutoSize = true;
            this.labelMainWindowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainWindowSales.Location = new System.Drawing.Point(26, 223);
            this.labelMainWindowSales.Name = "labelMainWindowSales";
            this.labelMainWindowSales.Size = new System.Drawing.Size(182, 24);
            this.labelMainWindowSales.TabIndex = 1;
            this.labelMainWindowSales.Text = "Total Sales [Euro]:";
            // 
            // LabelMainWindowSalesPersonsNumber
            // 
            this.LabelMainWindowSalesPersonsNumber.AutoSize = true;
            this.LabelMainWindowSalesPersonsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMainWindowSalesPersonsNumber.Location = new System.Drawing.Point(218, 133);
            this.LabelMainWindowSalesPersonsNumber.Name = "LabelMainWindowSalesPersonsNumber";
            this.LabelMainWindowSalesPersonsNumber.Size = new System.Drawing.Size(20, 24);
            this.LabelMainWindowSalesPersonsNumber.TabIndex = 1;
            this.LabelMainWindowSalesPersonsNumber.Text = "0";
            // 
            // LabelMainWindowSalesNumber
            // 
            this.LabelMainWindowSalesNumber.AutoSize = true;
            this.LabelMainWindowSalesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMainWindowSalesNumber.Location = new System.Drawing.Point(218, 223);
            this.LabelMainWindowSalesNumber.Name = "LabelMainWindowSalesNumber";
            this.LabelMainWindowSalesNumber.Size = new System.Drawing.Size(20, 24);
            this.LabelMainWindowSalesNumber.TabIndex = 1;
            this.LabelMainWindowSalesNumber.Text = "0";
            // 
            // btnMainWindowSalesPersons
            // 
            this.btnMainWindowSalesPersons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainWindowSalesPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainWindowSalesPersons.Location = new System.Drawing.Point(309, 126);
            this.btnMainWindowSalesPersons.Name = "btnMainWindowSalesPersons";
            this.btnMainWindowSalesPersons.Size = new System.Drawing.Size(196, 38);
            this.btnMainWindowSalesPersons.TabIndex = 2;
            this.btnMainWindowSalesPersons.Text = "View/Edit";
            this.btnMainWindowSalesPersons.UseVisualStyleBackColor = false;
            this.btnMainWindowSalesPersons.Click += new System.EventHandler(this.btnMainWindowSalesPersons_Click);
            // 
            // btnMainWindowSales
            // 
            this.btnMainWindowSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainWindowSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainWindowSales.Location = new System.Drawing.Point(309, 216);
            this.btnMainWindowSales.Name = "btnMainWindowSales";
            this.btnMainWindowSales.Size = new System.Drawing.Size(196, 38);
            this.btnMainWindowSales.TabIndex = 2;
            this.btnMainWindowSales.Text = "View/Edit";
            this.btnMainWindowSales.UseVisualStyleBackColor = false;
            this.btnMainWindowSales.Click += new System.EventHandler(this.btnMainWindowSales_Click);
            // 
            // btnMainWindowExit
            // 
            this.btnMainWindowExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMainWindowExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainWindowExit.Location = new System.Drawing.Point(377, 291);
            this.btnMainWindowExit.Name = "btnMainWindowExit";
            this.btnMainWindowExit.Size = new System.Drawing.Size(128, 38);
            this.btnMainWindowExit.TabIndex = 2;
            this.btnMainWindowExit.Text = "Exit";
            this.btnMainWindowExit.UseVisualStyleBackColor = false;
            this.btnMainWindowExit.Click += new System.EventHandler(this.btnMainWindowExit_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(525, 352);
            this.Controls.Add(this.btnMainWindowExit);
            this.Controls.Add(this.btnMainWindowSales);
            this.Controls.Add(this.btnMainWindowSalesPersons);
            this.Controls.Add(this.labelMainWindowSales);
            this.Controls.Add(this.LabelMainWindowSalesNumber);
            this.Controls.Add(this.LabelMainWindowSalesPersonsNumber);
            this.Controls.Add(this.labelMainWindowSalesPerson);
            this.Controls.Add(this.panelSalesManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMainWindow";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelSalesManager.ResumeLayout(false);
            this.panelSalesManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSalesManager;
        private System.Windows.Forms.Label labelSalesManager;
        private System.Windows.Forms.Label labelMainWindowSalesPerson;
        private System.Windows.Forms.Label labelMainWindowSales;
        private System.Windows.Forms.Label LabelMainWindowSalesPersonsNumber;
        private System.Windows.Forms.Label LabelMainWindowSalesNumber;
        private System.Windows.Forms.Button btnMainWindowSalesPersons;
        private System.Windows.Forms.Button btnMainWindowSales;
        private System.Windows.Forms.Button btnMainWindowExit;
    }
}