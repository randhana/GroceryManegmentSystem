
namespace GroceryManegmentSystem
{
    partial class Stock_Keeper
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblitemName = new System.Windows.Forms.Label();
            this.lblGrocery = new System.Windows.Forms.Label();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new GroceryManegmentSystem.DBDataSet();
            this.stockTableAdapter = new GroceryManegmentSystem.DBDataSetTableAdapters.StockTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.cmbCategories);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblCategories);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtItemName);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblitemName);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(129, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 157);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(299, 98);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(184, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Items.AddRange(new object[] {
            "Vegetable",
            "Fruits",
            "Meat",
            "Dry/Baking Goods",
            "Personal Care ",
            "Other"});
            this.cmbCategories.Location = new System.Drawing.Point(92, 6);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(121, 23);
            this.cmbCategories.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(56, 98);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(296, 43);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(124, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(14, 10);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(72, 15);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(92, 47);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(124, 22);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(296, 7);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(124, 22);
            this.txtItemName.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(26, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(60, 15);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblitemName
            // 
            this.lblitemName.AutoSize = true;
            this.lblitemName.Location = new System.Drawing.Point(216, 10);
            this.lblitemName.Name = "lblitemName";
            this.lblitemName.Size = new System.Drawing.Size(74, 15);
            this.lblitemName.TabIndex = 0;
            this.lblitemName.Text = "Item Name";
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.BackColor = System.Drawing.Color.Transparent;
            this.lblGrocery.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrocery.ForeColor = System.Drawing.Color.Black;
            this.lblGrocery.Location = new System.Drawing.Point(123, 9);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(449, 35);
            this.lblGrocery.TabIndex = 52;
            this.lblGrocery.Text = "Neel’s Grocery (Pvt) Ltd";
            this.lblGrocery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 236);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Stock_Keeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroceryManegmentSystem.Properties.Resources.cmyk_color_strips_vector_89153;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(692, 470);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGrocery);
            this.Name = "Stock_Keeper";
            this.Text = "Stock_Keeper";
            this.Load += new System.EventHandler(this.Stock_Keeper_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblitemName;
        private System.Windows.Forms.Label lblGrocery;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private DBDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}