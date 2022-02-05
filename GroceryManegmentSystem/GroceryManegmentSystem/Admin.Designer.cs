
namespace GroceryManegmentSystem
{
    partial class Admin
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
            this.lblGrocery = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.staffRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockHadalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnFillter = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGrocery
            // 
            this.lblGrocery.AutoSize = true;
            this.lblGrocery.BackColor = System.Drawing.Color.Transparent;
            this.lblGrocery.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrocery.ForeColor = System.Drawing.Color.Black;
            this.lblGrocery.Location = new System.Drawing.Point(113, 40);
            this.lblGrocery.Name = "lblGrocery";
            this.lblGrocery.Size = new System.Drawing.Size(449, 35);
            this.lblGrocery.TabIndex = 52;
            this.lblGrocery.Text = "Neel’s Grocery (Pvt) Ltd";
            this.lblGrocery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGrocery.Click += new System.EventHandler(this.lblGrocery_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 26);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffRegistrationToolStripMenuItem,
            this.stockHadalingToolStripMenuItem,
            this.billingToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(670, 26);
            this.menuStrip2.TabIndex = 54;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // staffRegistrationToolStripMenuItem
            // 
            this.staffRegistrationToolStripMenuItem.Name = "staffRegistrationToolStripMenuItem";
            this.staffRegistrationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.staffRegistrationToolStripMenuItem.Text = "Staff Registration";
            this.staffRegistrationToolStripMenuItem.Click += new System.EventHandler(this.staffRegistrationToolStripMenuItem_Click);
            // 
            // stockHadalingToolStripMenuItem
            // 
            this.stockHadalingToolStripMenuItem.Name = "stockHadalingToolStripMenuItem";
            this.stockHadalingToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.stockHadalingToolStripMenuItem.Text = "Stock Manege";
            this.stockHadalingToolStripMenuItem.Click += new System.EventHandler(this.stockHadalingToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(71, 22);
            this.billingToolStripMenuItem.Text = "Billing";
            this.billingToolStripMenuItem.Click += new System.EventHandler(this.billingToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnFillter);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Location = new System.Drawing.Point(38, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 192);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // btnFillter
            // 
            this.btnFillter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFillter.Location = new System.Drawing.Point(62, 110);
            this.btnFillter.Name = "btnFillter";
            this.btnFillter.Size = new System.Drawing.Size(75, 23);
            this.btnFillter.TabIndex = 58;
            this.btnFillter.Text = "Fillter";
            this.btnFillter.UseVisualStyleBackColor = false;
            this.btnFillter.Click += new System.EventHandler(this.btnFillter_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(62, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker2.TabIndex = 57;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(364, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 164);
            this.label1.TabIndex = 58;
            this.label1.Text = "label1";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GroceryManegmentSystem.Properties.Resources.modern_gold_background_free_vector;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGrocery);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrocery;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem staffRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockHadalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnFillter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}