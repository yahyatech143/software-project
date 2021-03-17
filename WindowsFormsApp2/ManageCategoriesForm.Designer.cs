
namespace WindowsFormsApp2
{
    partial class ManageCategoriesForm
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
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAvailable = new System.Windows.Forms.RadioButton();
            this.rdoUnavailable = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name:";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(34, 74);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(140, 20);
            this.txtCatName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoUnavailable);
            this.groupBox1.Controls.Add(this.rdoAvailable);
            this.groupBox1.Location = new System.Drawing.Point(34, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rdoAvailable
            // 
            this.rdoAvailable.AutoSize = true;
            this.rdoAvailable.Checked = true;
            this.rdoAvailable.Location = new System.Drawing.Point(6, 19);
            this.rdoAvailable.Name = "rdoAvailable";
            this.rdoAvailable.Size = new System.Drawing.Size(85, 17);
            this.rdoAvailable.TabIndex = 0;
            this.rdoAvailable.TabStop = true;
            this.rdoAvailable.Text = "radioButton1";
            this.rdoAvailable.UseVisualStyleBackColor = true;
            // 
            // rdoUnavailable
            // 
            this.rdoUnavailable.AutoSize = true;
            this.rdoUnavailable.Location = new System.Drawing.Point(6, 52);
            this.rdoUnavailable.Name = "rdoUnavailable";
            this.rdoUnavailable.Size = new System.Drawing.Size(85, 17);
            this.rdoUnavailable.TabIndex = 1;
            this.rdoUnavailable.Text = "radioButton2";
            this.rdoUnavailable.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Location = new System.Drawing.Point(219, 39);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.Size = new System.Drawing.Size(314, 237);
            this.dgvCategories.TabIndex = 4;
            // 
            // ManageCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 395);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label1);
            this.Name = "ManageCategoriesForm";
            this.Text = "ManageCategoriesForm";
            this.Load += new System.EventHandler(this.ManageCategoriesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoUnavailable;
        private System.Windows.Forms.RadioButton rdoAvailable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCategories;
    }
}