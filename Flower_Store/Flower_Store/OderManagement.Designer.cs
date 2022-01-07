
namespace Flower_Store
{
    partial class OderManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OderManagement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaximized = new System.Windows.Forms.Button();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetProduct = new System.Windows.Forms.Button();
            this.getCustomer = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalprice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnitprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Flower_Store.Properties.Resources.order;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(524, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 55);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1334, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 24);
            this.btnExit.TabIndex = 45;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximized.BackgroundImage = global::Flower_Store.Properties.Resources.maximize;
            this.btnMaximized.FlatAppearance.BorderSize = 0;
            this.btnMaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximized.Location = new System.Drawing.Point(1304, 3);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(24, 24);
            this.btnMaximized.TabIndex = 44;
            this.btnMaximized.UseVisualStyleBackColor = true;
            this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimized.BackgroundImage")));
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Location = new System.Drawing.Point(1274, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(24, 24);
            this.btnMinimized.TabIndex = 43;
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(721, 219);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(101, 38);
            this.btnReload.TabIndex = 51;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1146, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 36;
            this.label11.Text = "VND";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFind.Image = global::Flower_Store.Properties.Resources.search;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(569, 219);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(99, 38);
            this.btnFind.TabIndex = 46;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::Flower_Store.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(874, 219);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 38);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoEllipsis = true;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(762, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "VND";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Image = global::Flower_Store.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(422, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 38);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dtpOrder
            // 
            this.dtpOrder.CustomFormat = "";
            this.dtpOrder.Location = new System.Drawing.Point(957, 146);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(229, 23);
            this.dtpOrder.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(861, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Purchase Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(597, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 32);
            this.label7.TabIndex = 42;
            this.label7.Text = "ORDER MANAGEMENT";
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column9,
            this.Column8,
            this.Column10,
            this.Column11});
            this.dgvOrder.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvOrder.Location = new System.Drawing.Point(34, 420);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.Size = new System.Drawing.Size(1267, 310);
            this.dgvOrder.TabIndex = 40;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IDOD";
            this.Column2.HeaderText = "ID Order";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IDCUS";
            this.Column3.HeaderText = "ID Customer";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CUSTOMER";
            this.Column4.HeaderText = "Customer";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "IDPROD";
            this.Column6.HeaderText = "ID Product";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PRODUCT";
            this.Column5.HeaderText = "Product";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "QUANTITY";
            this.Column9.HeaderText = "Quantity";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "UNITPRICE";
            this.Column8.HeaderText = "Unit Price";
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TOTALPRICE";
            this.Column10.HeaderText = "Total Price";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "PURCHASEDATE";
            this.Column11.HeaderText = "Order Date";
            this.Column11.Name = "Column11";
            this.Column11.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Lavender;
            this.groupBox3.Controls.Add(this.btnGetProduct);
            this.groupBox3.Controls.Add(this.getCustomer);
            this.groupBox3.Controls.Add(this.btnReload);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnFind);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.dtpOrder);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTotalprice);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtIdProduct);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtUnitprice);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtProduct);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtIdCustomer);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtCustomer);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtIdOrder);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(34, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1267, 296);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order";
            // 
            // btnGetProduct
            // 
            this.btnGetProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGetProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetProduct.FlatAppearance.BorderSize = 0;
            this.btnGetProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetProduct.Location = new System.Drawing.Point(707, 87);
            this.btnGetProduct.Name = "btnGetProduct";
            this.btnGetProduct.Size = new System.Drawing.Size(103, 23);
            this.btnGetProduct.TabIndex = 53;
            this.btnGetProduct.Text = "Get Product";
            this.btnGetProduct.UseVisualStyleBackColor = false;
            this.btnGetProduct.Click += new System.EventHandler(this.btnGetProduct_Click);
            // 
            // getCustomer
            // 
            this.getCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.getCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getCustomer.FlatAppearance.BorderSize = 0;
            this.getCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getCustomer.Location = new System.Drawing.Point(707, 39);
            this.getCustomer.Name = "getCustomer";
            this.getCustomer.Size = new System.Drawing.Size(103, 23);
            this.getCustomer.TabIndex = 52;
            this.getCustomer.Text = "Get Customer";
            this.getCustomer.UseVisualStyleBackColor = false;
            this.getCustomer.Click += new System.EventHandler(this.getCustomer_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Image = global::Flower_Store.Properties.Resources.edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(274, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 38);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(104, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "ID Customer:";
            // 
            // txtTotalprice
            // 
            this.txtTotalprice.Enabled = false;
            this.txtTotalprice.Location = new System.Drawing.Point(961, 92);
            this.txtTotalprice.Name = "txtTotalprice";
            this.txtTotalprice.ReadOnly = true;
            this.txtTotalprice.Size = new System.Drawing.Size(164, 23);
            this.txtTotalprice.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(861, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Total Price:";
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.Enabled = false;
            this.txtIdProduct.Location = new System.Drawing.Point(204, 144);
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.ReadOnly = true;
            this.txtIdProduct.Size = new System.Drawing.Size(161, 23);
            this.txtIdProduct.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "ID Product:";
            // 
            // txtUnitprice
            // 
            this.txtUnitprice.Enabled = false;
            this.txtUnitprice.Location = new System.Drawing.Point(490, 144);
            this.txtUnitprice.Name = "txtUnitprice";
            this.txtUnitprice.ReadOnly = true;
            this.txtUnitprice.Size = new System.Drawing.Size(259, 23);
            this.txtUnitprice.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Unit Price:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(961, 39);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(218, 23);
            this.txtQuantity.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(861, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Quantity:";
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(490, 87);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.ReadOnly = true;
            this.txtProduct.Size = new System.Drawing.Size(194, 23);
            this.txtProduct.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Product:";
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Enabled = false;
            this.txtIdCustomer.Location = new System.Drawing.Point(204, 87);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.ReadOnly = true;
            this.txtIdCustomer.Size = new System.Drawing.Size(161, 23);
            this.txtIdCustomer.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 15;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Location = new System.Drawing.Point(490, 39);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(194, 23);
            this.txtCustomer.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Customer:";
            // 
            // txtIdOrder
            // 
            this.txtIdOrder.Location = new System.Drawing.Point(204, 39);
            this.txtIdOrder.Name = "txtIdOrder";
            this.txtIdOrder.ReadOnly = true;
            this.txtIdOrder.Size = new System.Drawing.Size(161, 23);
            this.txtIdOrder.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Order:";
            // 
            // OderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 726);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMaximized);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.groupBox3);
            this.Name = "OderManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OderManagement_FormClosed);
            this.Load += new System.EventHandler(this.OderManagement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OderManagement_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximized;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnitprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getCustomer;
        private System.Windows.Forms.Button btnGetProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnUpdate;
    }
}