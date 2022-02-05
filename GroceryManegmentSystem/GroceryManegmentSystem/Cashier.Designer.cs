
namespace GroceryManegmentSystem
{
    partial class Cashier
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBilingCas = new System.Windows.Forms.TextBox();
            this.txtClientCas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPriceCas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantityCas = new System.Windows.Forms.TextBox();
            this.txtItemNameCas = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblitemName = new System.Windows.Forms.Label();
            this.lblGrocery = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvCashierbill = new System.Windows.Forms.DataGridView();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblamount = new System.Windows.Forms.Label();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.dbDataSet1 = new GroceryManegmentSystem.DBDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashierbill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBilingCas);
            this.groupBox1.Controls.Add(this.txtClientCas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtPriceCas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantityCas);
            this.groupBox1.Controls.Add(this.txtItemNameCas);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblitemName);
            this.groupBox1.Location = new System.Drawing.Point(210, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 173);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // txtBilingCas
            // 
            this.txtBilingCas.Location = new System.Drawing.Point(71, 13);
            this.txtBilingCas.Name = "txtBilingCas";
            this.txtBilingCas.Size = new System.Drawing.Size(124, 20);
            this.txtBilingCas.TabIndex = 12;
            // 
            // txtClientCas
            // 
            this.txtClientCas.Location = new System.Drawing.Point(71, 46);
            this.txtClientCas.Name = "txtClientCas";
            this.txtClientCas.Size = new System.Drawing.Size(124, 20);
            this.txtClientCas.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Billing Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add To Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPriceCas
            // 
            this.txtPriceCas.Location = new System.Drawing.Point(71, 122);
            this.txtPriceCas.Name = "txtPriceCas";
            this.txtPriceCas.Size = new System.Drawing.Size(124, 20);
            this.txtPriceCas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Client Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // txtQuantityCas
            // 
            this.txtQuantityCas.Location = new System.Drawing.Point(71, 96);
            this.txtQuantityCas.Name = "txtQuantityCas";
            this.txtQuantityCas.Size = new System.Drawing.Size(124, 20);
            this.txtQuantityCas.TabIndex = 3;
            // 
            // txtItemNameCas
            // 
            this.txtItemNameCas.Location = new System.Drawing.Point(71, 72);
            this.txtItemNameCas.Name = "txtItemNameCas";
            this.txtItemNameCas.Size = new System.Drawing.Size(124, 20);
            this.txtItemNameCas.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 99);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblitemName
            // 
            this.lblitemName.AutoSize = true;
            this.lblitemName.Location = new System.Drawing.Point(6, 72);
            this.lblitemName.Name = "lblitemName";
            this.lblitemName.Size = new System.Drawing.Size(58, 13);
            this.lblitemName.TabIndex = 0;
            this.lblitemName.Text = "Item Name";
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.BackColor = System.Drawing.Color.Transparent;
            this.lblGrocery.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrocery.ForeColor = System.Drawing.Color.Black;
            this.lblGrocery.Location = new System.Drawing.Point(70, 9);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(449, 35);
            this.lblGrocery.TabIndex = 51;
            this.lblGrocery.Text = "Neel’s Grocery (Pvt) Ltd";
            this.lblGrocery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(112, 274);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(649, 257);
            this.dataGridView2.TabIndex = 53;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvCashierbill
            // 
            this.dgvCashierbill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashierbill.Location = new System.Drawing.Point(446, 53);
            this.dgvCashierbill.Name = "dgvCashierbill";
            this.dgvCashierbill.Size = new System.Drawing.Size(330, 173);
            this.dgvCashierbill.TabIndex = 54;
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(60, 92);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(124, 23);
            this.btnNewCustomer.TabIndex = 55;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Total Amount";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Fax", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(753, 558);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 58;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblamount
            // 
            this.lblamount.AutoSize = true;
            this.lblamount.BackColor = System.Drawing.Color.Transparent;
            this.lblamount.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblamount.Location = new System.Drawing.Point(660, 235);
            this.lblamount.Name = "lblamount";
            this.lblamount.Size = new System.Drawing.Size(116, 18);
            this.lblamount.TabIndex = 59;
            this.lblamount.Text = "------------------";
            // 
            // BtnFinish
            // 
            this.BtnFinish.Location = new System.Drawing.Point(446, 236);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(75, 23);
            this.BtnFinish.TabIndex = 60;
            this.BtnFinish.Text = "Finish Bill";
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // dbDataSet1
            // 
            this.dbDataSet1.DataSetName = "DBDataSet";
            this.dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroceryManegmentSystem.Properties.Resources.pngtree_shopping_mall_supermarket_selection_merchandise_poster_background_material_image_133225;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 593);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.lblamount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.dgvCashierbill);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGrocery);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashierbill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPriceCas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantityCas;
        private System.Windows.Forms.TextBox txtItemNameCas;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblitemName;
        private System.Windows.Forms.Label lblGrocery;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtBilingCas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCashierbill;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblamount;
        private System.Windows.Forms.Button BtnFinish;
        private DBDataSet dbDataSet1;
        public System.Windows.Forms.TextBox txtClientCas;
    }
}