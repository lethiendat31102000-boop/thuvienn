namespace thu
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmadocgia = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.txtgioitinh = new System.Windows.Forms.TextBox();
            this.dtpngaylamthe = new System.Windows.Forms.DateTimePicker();
            this.dtgdocgia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiemma = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgdocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ ĐỘC GIẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "HỌ VÀ TÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "GIỚI TÍNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "NGÀY SINH";
            // 
            // txtmadocgia
            // 
            this.txtmadocgia.Location = new System.Drawing.Point(101, 29);
            this.txtmadocgia.Name = "txtmadocgia";
            this.txtmadocgia.Size = new System.Drawing.Size(194, 22);
            this.txtmadocgia.TabIndex = 6;
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(101, 66);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(194, 22);
            this.txthovaten.TabIndex = 7;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.Location = new System.Drawing.Point(101, 116);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(194, 22);
            this.txtgioitinh.TabIndex = 8;
            // 
            // dtpngaylamthe
            // 
            this.dtpngaylamthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaylamthe.Location = new System.Drawing.Point(450, 162);
            this.dtpngaylamthe.Name = "dtpngaylamthe";
            this.dtpngaylamthe.Size = new System.Drawing.Size(205, 22);
            this.dtpngaylamthe.TabIndex = 10;
            // 
            // dtgdocgia
            // 
            this.dtgdocgia.AllowUserToAddRows = false;
            this.dtgdocgia.AllowUserToDeleteRows = false;
            this.dtgdocgia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgdocgia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dtgdocgia.Location = new System.Drawing.Point(12, 326);
            this.dtgdocgia.MultiSelect = false;
            this.dtgdocgia.Name = "dtgdocgia";
            this.dtgdocgia.ReadOnly = true;
            this.dtgdocgia.RowHeadersVisible = false;
            this.dtgdocgia.RowHeadersWidth = 51;
            this.dtgdocgia.RowTemplate.Height = 24;
            this.dtgdocgia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgdocgia.Size = new System.Drawing.Size(1004, 199);
            this.dtgdocgia.TabIndex = 12;
            this.dtgdocgia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgdocgia_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MÃ ĐỘC GIẢ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "HỌ VÀ TÊN";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NGÀY SINH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GIỚI TÍNH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ĐỊA CHỈ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ĐIỆN THOẠI";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CMND";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "NGÀY LÀM THẺ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(101, 236);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(138, 43);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(541, 236);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(140, 43);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "SỬA";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "ĐỊA CHỈ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "ĐIỆN THOẠI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "CMND";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "NGÀY LÀM THẺ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(773, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "TÌM KIẾM MÃ ĐỘC GIẢ";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(450, 27);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(205, 22);
            this.txtdiachi.TabIndex = 20;
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(450, 69);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(205, 22);
            this.txtdienthoai.TabIndex = 21;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(450, 114);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(205, 22);
            this.txtcmnd.TabIndex = 22;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(776, 69);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(140, 22);
            this.txttimkiem.TabIndex = 24;
            // 
            // btntimkiemma
            // 
            this.btntimkiemma.Location = new System.Drawing.Point(800, 114);
            this.btntimkiemma.Name = "btntimkiemma";
            this.btntimkiemma.Size = new System.Drawing.Size(104, 38);
            this.btntimkiemma.TabIndex = 25;
            this.btntimkiemma.Text = "TÌM KIẾM";
            this.btntimkiemma.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(317, 236);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(147, 43);
            this.btnxoa.TabIndex = 26;
            this.btnxoa.Text = "XÓA";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(776, 236);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(118, 43);
            this.btnhienthi.TabIndex = 27;
            this.btnhienthi.Text = "HIỂN  THỊ";
            this.btnhienthi.UseVisualStyleBackColor = true;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(101, 168);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(194, 22);
            this.dtpngaysinh.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 644);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.btnhienthi);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btntimkiemma);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.txtcmnd);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgdocgia);
            this.Controls.Add(this.dtpngaylamthe);
            this.Controls.Add(this.txtgioitinh);
            this.Controls.Add(this.txthovaten);
            this.Controls.Add(this.txtmadocgia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgdocgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmadocgia;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.TextBox txtgioitinh;
        private System.Windows.Forms.DateTimePicker dtpngaylamthe;
        private System.Windows.Forms.DataGridView dtgdocgia;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtdienthoai;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btntimkiemma;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
    }
}

