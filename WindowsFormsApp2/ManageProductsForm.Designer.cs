
namespace WindowsFormsApp2
{
    partial class ManageProductsForm
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPurchaseprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalesprice = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoUnavailable = new System.Windows.Forms.RadioButton();
            this.rdoAvailable = new System.Windows.Forms.RadioButton();
            this.btnAddproduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblpid = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(99, 46);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(130, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtPurchaseprice
            // 
            this.txtPurchaseprice.Location = new System.Drawing.Point(99, 115);
            this.txtPurchaseprice.Name = "txtPurchaseprice";
            this.txtPurchaseprice.Size = new System.Drawing.Size(130, 20);
            this.txtPurchaseprice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Purchase price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sales price:";
            // 
            // txtSalesprice
            // 
            this.txtSalesprice.Location = new System.Drawing.Point(99, 150);
            this.txtSalesprice.Name = "txtSalesprice";
            this.txtSalesprice.Size = new System.Drawing.Size(130, 20);
            this.txtSalesprice.TabIndex = 7;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(99, 211);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(130, 21);
            this.cbxCategory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoUnavailable);
            this.groupBox1.Controls.Add(this.rdoAvailable);
            this.groupBox1.Location = new System.Drawing.Point(15, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rdoUnavailable
            // 
            this.rdoUnavailable.AutoSize = true;
            this.rdoUnavailable.Location = new System.Drawing.Point(6, 65);
            this.rdoUnavailable.Name = "rdoUnavailable";
            this.rdoUnavailable.Size = new System.Drawing.Size(88, 17);
            this.rdoUnavailable.TabIndex = 1;
            this.rdoUnavailable.Text = "Not Available";
            this.rdoUnavailable.UseVisualStyleBackColor = true;
            // 
            // rdoAvailable
            // 
            this.rdoAvailable.AutoSize = true;
            this.rdoAvailable.Checked = true;
            this.rdoAvailable.Location = new System.Drawing.Point(6, 28);
            this.rdoAvailable.Name = "rdoAvailable";
            this.rdoAvailable.Size = new System.Drawing.Size(71, 17);
            this.rdoAvailable.TabIndex = 0;
            this.rdoAvailable.TabStop = true;
            this.rdoAvailable.Text = "Available:";
            this.rdoAvailable.UseVisualStyleBackColor = true;
            // 
            // btnAddproduct
            // 
            this.btnAddproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddproduct.Location = new System.Drawing.Point(12, 366);
            this.btnAddproduct.Name = "btnAddproduct";
            this.btnAddproduct.Size = new System.Drawing.Size(91, 49);
            this.btnAddproduct.TabIndex = 11;
            this.btnAddproduct.Text = "Add Product";
            this.btnAddproduct.UseVisualStyleBackColor = true;
            this.btnAddproduct.Click += new System.EventHandler(this.btnAddproduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(269, 136);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(283, 213);
            this.dgvProducts.TabIndex = 12;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Location = new System.Drawing.Point(325, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 84);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(6, 34);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(188, 20);
            this.txtSearchName.TabIndex = 14;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(18, 30);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(35, 13);
            this.lblpid.TabIndex = 14;
            this.lblpid.Text = "label7";
            this.lblpid.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(122, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 49);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(237, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 49);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(99, 182);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(130, 20);
            this.txtStock.TabIndex = 18;
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 433);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblpid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnAddproduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.txtSalesprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPurchaseprice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Name = "ManageProductsForm";
            this.Text = "ManageProductsForm";
            this.Load += new System.EventHandler(this.ManageProductsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPurchaseprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalesprice;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoUnavailable;
        private System.Windows.Forms.RadioButton rdoAvailable;
        private System.Windows.Forms.Button btnAddproduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStock;
    }
}