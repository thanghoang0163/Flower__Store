﻿
namespace Flower_Store
{
    partial class SupplierManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierManagement));
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpSupplier = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalpriceE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPhoneE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnitpriceE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantityE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProductE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddressE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.txtPhoneF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdF = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(576, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 32);
            this.label7.TabIndex = 27;
            this.label7.Text = "SUPPLIER MANAGEMENT";
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column9,
            this.Column8,
            this.Column10,
            this.Column11});
            this.dgvSupplier.Location = new System.Drawing.Point(71, 364);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowTemplate.Height = 25;
            this.dgvSupplier.Size = new System.Drawing.Size(1325, 310);
            this.dgvSupplier.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Supplier";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Phone Number";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Product";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Quantity";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Unit Price";
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Total Price";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Supply Date";
            this.Column11.Name = "Column11";
            this.Column11.Width = 200;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.btnReload);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.dtpSupplier);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtTotalpriceE);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtPhoneE);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtUnitpriceE);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtQuantityE);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtProductE);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.txtSupplier);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtAddressE);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtIdE);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(71, 724);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1325, 296);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Supplier";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Flower_Store.Properties.Resources.close__1_;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(672, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 35);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
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
            // dtpSupplier
            // 
            this.dtpSupplier.CustomFormat = "MM/dd/yyyy   hh:mm:ss tt";
            this.dtpSupplier.Location = new System.Drawing.Point(957, 146);
            this.dtpSupplier.Name = "dtpSupplier";
            this.dtpSupplier.Size = new System.Drawing.Size(319, 23);
            this.dtpSupplier.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(861, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 33;
            this.label14.Text = "Supply Date:";
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(104, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 32;
            this.label13.Text = "Supplier:";
            // 
            // txtTotalpriceE
            // 
            this.txtTotalpriceE.Location = new System.Drawing.Point(961, 92);
            this.txtTotalpriceE.Name = "txtTotalpriceE";
            this.txtTotalpriceE.ReadOnly = true;
            this.txtTotalpriceE.Size = new System.Drawing.Size(164, 23);
            this.txtTotalpriceE.TabIndex = 31;
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
            // txtPhoneE
            // 
            this.txtPhoneE.Location = new System.Drawing.Point(204, 144);
            this.txtPhoneE.Name = "txtPhoneE";
            this.txtPhoneE.Size = new System.Drawing.Size(161, 23);
            this.txtPhoneE.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(104, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Phone Number:";
            // 
            // txtUnitpriceE
            // 
            this.txtUnitpriceE.Location = new System.Drawing.Point(490, 144);
            this.txtUnitpriceE.Name = "txtUnitpriceE";
            this.txtUnitpriceE.Size = new System.Drawing.Size(259, 23);
            this.txtUnitpriceE.TabIndex = 25;
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
            // txtQuantityE
            // 
            this.txtQuantityE.Location = new System.Drawing.Point(961, 39);
            this.txtQuantityE.Name = "txtQuantityE";
            this.txtQuantityE.Size = new System.Drawing.Size(218, 23);
            this.txtQuantityE.TabIndex = 23;
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = global::Flower_Store.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(231, 231);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 38);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtProductE
            // 
            this.txtProductE.Location = new System.Drawing.Point(490, 87);
            this.txtProductE.Name = "txtProductE";
            this.txtProductE.Size = new System.Drawing.Size(305, 23);
            this.txtProductE.TabIndex = 20;
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = global::Flower_Store.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(522, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = global::Flower_Store.Properties.Resources.edit;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(374, 231);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 38);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(204, 87);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(161, 23);
            this.txtSupplier.TabIndex = 16;
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
            // txtAddressE
            // 
            this.txtAddressE.Location = new System.Drawing.Point(490, 39);
            this.txtAddressE.Name = "txtAddressE";
            this.txtAddressE.Size = new System.Drawing.Size(305, 23);
            this.txtAddressE.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Address:";
            // 
            // txtIdE
            // 
            this.txtIdE.Location = new System.Drawing.Point(204, 39);
            this.txtIdE.Name = "txtIdE";
            this.txtIdE.ReadOnly = true;
            this.txtIdE.Size = new System.Drawing.Size(161, 23);
            this.txtIdE.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSupplier);
            this.groupBox1.Controls.Add(this.txtPhoneF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdF);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(71, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1325, 222);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(644, 49);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(223, 23);
            this.cbSupplier.TabIndex = 17;
            // 
            // txtPhoneF
            // 
            this.txtPhoneF.Location = new System.Drawing.Point(403, 97);
            this.txtPhoneF.Name = "txtPhoneF";
            this.txtPhoneF.Size = new System.Drawing.Size(122, 23);
            this.txtPhoneF.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Phone Number:";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.Control;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Image = global::Flower_Store.Properties.Resources.search;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(542, 160);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(99, 38);
            this.btnFind.TabIndex = 14;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Supplier:";
            // 
            // txtIdF
            // 
            this.txtIdF.Location = new System.Drawing.Point(403, 49);
            this.txtIdF.Name = "txtIdF";
            this.txtIdF.Size = new System.Drawing.Size(122, 23);
            this.txtIdF.TabIndex = 11;
            // 
            // id
            // 
            this.id.AutoEllipsis = true;
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(303, 57);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 15);
            this.id.TabIndex = 10;
            this.id.Text = "ID:";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.Control;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(833, 233);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(96, 35);
            this.btnReload.TabIndex = 44;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // SupplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1469, 1035);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierManagement";
            this.Text = "SupplierManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtProductE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddressE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhoneF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdF;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtUnitpriceE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantityE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotalpriceE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPhoneE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpSupplier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReload;
    }
}