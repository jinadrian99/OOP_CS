﻿namespace _04_Bai4
{
    partial class FormL4B4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormL4B4));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkGT = new System.Windows.Forms.CheckBox();
            this.dtpNS = new System.Windows.Forms.DateTimePicker();
            this.txtML = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lvwDSHS = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblImg = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã Lớp";
            // 
            // chkGT
            // 
            this.chkGT.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGT.Location = new System.Drawing.Point(95, 102);
            this.chkGT.Name = "chkGT";
            this.chkGT.Size = new System.Drawing.Size(64, 31);
            this.chkGT.TabIndex = 16;
            this.chkGT.Text = "Nam/Nữ";
            this.chkGT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGT.UseVisualStyleBackColor = true;
            this.chkGT.CheckedChanged += new System.EventHandler(this.chkGT_CheckedChanged);
            // 
            // dtpNS
            // 
            this.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNS.Location = new System.Drawing.Point(95, 76);
            this.dtpNS.Name = "dtpNS";
            this.dtpNS.Size = new System.Drawing.Size(97, 20);
            this.dtpNS.TabIndex = 15;
            // 
            // txtML
            // 
            this.txtML.Location = new System.Drawing.Point(95, 139);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(254, 20);
            this.txtML.TabIndex = 14;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(95, 47);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(254, 20);
            this.txtHT.TabIndex = 13;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(95, 16);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(254, 20);
            this.txtMSV.TabIndex = 12;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(252, 76);
            this.txtT.Name = "txtT";
            this.txtT.ReadOnly = true;
            this.txtT.Size = new System.Drawing.Size(97, 20);
            this.txtT.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tuổi";
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(413, 136);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(32, 23);
            this.btnSau.TabIndex = 24;
            this.btnSau.Text = ">";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(370, 136);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(37, 23);
            this.btnTruoc.TabIndex = 23;
            this.btnTruoc.Text = "<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(370, 106);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(370, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(370, 44);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(370, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lvwDSHS
            // 
            this.lvwDSHS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvwDSHS.FullRowSelect = true;
            this.lvwDSHS.GridLines = true;
            this.lvwDSHS.HideSelection = false;
            this.lvwDSHS.Location = new System.Drawing.Point(12, 168);
            this.lvwDSHS.MultiSelect = false;
            this.lvwDSHS.Name = "lvwDSHS";
            this.lvwDSHS.Size = new System.Drawing.Size(433, 159);
            this.lvwDSHS.TabIndex = 25;
            this.lvwDSHS.UseCompatibleStateImageBehavior = false;
            this.lvwDSHS.View = System.Windows.Forms.View.Details;
            this.lvwDSHS.SelectedIndexChanged += new System.EventHandler(this.lvwDSHS_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Sinh Viên";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày sinh";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giới tính";
            this.columnHeader4.Width = 66;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã lớp";
            this.columnHeader5.Width = 81;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconwomen.png");
            this.imageList1.Images.SetKeyName(1, "iconmen.png");
            // 
            // lblImg
            // 
            this.lblImg.BackColor = System.Drawing.Color.Gainsboro;
            this.lblImg.Location = new System.Drawing.Point(101, 106);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(23, 23);
            this.lblImg.TabIndex = 26;
            this.lblImg.Text = "Img";
            this.lblImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tuổi";
            // 
            // FormL4B4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(461, 339);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.lvwDSHS);
            this.Controls.Add(this.btnSau);
            this.Controls.Add(this.btnTruoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkGT);
            this.Controls.Add(this.dtpNS);
            this.Controls.Add(this.txtML);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormL4B4";
            this.Text = "FormL4B4";
            this.Load += new System.EventHandler(this.FormL4B4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkGT;
        private System.Windows.Forms.DateTimePicker dtpNS;
        private System.Windows.Forms.TextBox txtML;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ListView lvwDSHS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}