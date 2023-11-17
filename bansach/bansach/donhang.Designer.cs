namespace bansach
{
    partial class donhang
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sach3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bansachDataSet11 = new bansach.bansachDataSet11();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sach3TableAdapter = new bansach.bansachDataSet11TableAdapters.sach3TableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hoadon2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bansachDataSet13 = new bansach.bansachDataSet13();
            this.bansachDataSet12 = new bansach.bansachDataSet12();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadonTableAdapter = new bansach.bansachDataSet12TableAdapters.hoadonTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.hoadon2TableAdapter = new bansach.bansachDataSet13TableAdapters.hoadon2TableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuatbanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daban2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anhbiaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sach3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(453, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 20);
            this.textBox5.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thanh toán\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chọn sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chọn số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Giá tiền";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(24, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(249, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach2,
            this.tensachDataGridViewTextBoxColumn,
            this.tacgiaDataGridViewTextBoxColumn,
            this.theloaiDataGridViewTextBoxColumn,
            this.ngayxuatbanDataGridViewTextBoxColumn,
            this.soluong2,
            this.giaDataGridViewTextBoxColumn,
            this.daban2,
            this.anhbiaDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.sach3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-41, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 110);
            this.dataGridView1.TabIndex = 18;
            // 
            // sach3BindingSource
            // 
            this.sach3BindingSource.DataMember = "sach3";
            this.sach3BindingSource.DataSource = this.bansachDataSet11;
            // 
            // bansachDataSet11
            // 
            this.bansachDataSet11.DataSetName = "bansachDataSet11";
            this.bansachDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 20);
            this.textBox1.TabIndex = 19;
            // 
            // sach3TableAdapter
            // 
            this.sach3TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tensach,
            this.soluong,
            this.thanhtien,
            this.ngaylap});
            this.dataGridView2.Location = new System.Drawing.Point(99, 278);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(590, 112);
            this.dataGridView2.TabIndex = 20;
            // 
            // hoadon2BindingSource
            // 
            this.hoadon2BindingSource.DataMember = "hoadon2";
            this.hoadon2BindingSource.DataSource = this.bansachDataSet13;
            // 
            // bansachDataSet13
            // 
            this.bansachDataSet13.DataSetName = "bansachDataSet13";
            this.bansachDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bansachDataSet12
            // 
            this.bansachDataSet12.DataSetName = "bansachDataSet12";
            this.bansachDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            this.hoadonBindingSource.DataSource = this.bansachDataSet12;
            // 
            // hoadonTableAdapter
            // 
            this.hoadonTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(610, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ngày mua";
            // 
            // hoadon2TableAdapter
            // 
            this.hoadon2TableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(339, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "Lưu hóa đơn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tensach
            // 
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            this.tensach.Width = 200;
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Tổng tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // ngaylap
            // 
            this.ngaylap.HeaderText = "Ngày mua";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Width = 150;
            // 
            // masach2
            // 
            this.masach2.DataPropertyName = "masach";
            this.masach2.HeaderText = "Mã sách";
            this.masach2.Name = "masach2";
            // 
            // tensachDataGridViewTextBoxColumn
            // 
            this.tensachDataGridViewTextBoxColumn.DataPropertyName = "tensach";
            this.tensachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tensachDataGridViewTextBoxColumn.Name = "tensachDataGridViewTextBoxColumn";
            // 
            // tacgiaDataGridViewTextBoxColumn
            // 
            this.tacgiaDataGridViewTextBoxColumn.DataPropertyName = "tacgia";
            this.tacgiaDataGridViewTextBoxColumn.HeaderText = "Tác giả";
            this.tacgiaDataGridViewTextBoxColumn.Name = "tacgiaDataGridViewTextBoxColumn";
            // 
            // theloaiDataGridViewTextBoxColumn
            // 
            this.theloaiDataGridViewTextBoxColumn.DataPropertyName = "theloai";
            this.theloaiDataGridViewTextBoxColumn.HeaderText = "Thể loại";
            this.theloaiDataGridViewTextBoxColumn.Name = "theloaiDataGridViewTextBoxColumn";
            // 
            // ngayxuatbanDataGridViewTextBoxColumn
            // 
            this.ngayxuatbanDataGridViewTextBoxColumn.DataPropertyName = "ngayxuatban";
            this.ngayxuatbanDataGridViewTextBoxColumn.HeaderText = "Ngày xuất bản";
            this.ngayxuatbanDataGridViewTextBoxColumn.Name = "ngayxuatbanDataGridViewTextBoxColumn";
            // 
            // soluong2
            // 
            this.soluong2.DataPropertyName = "soluong";
            this.soluong2.HeaderText = "Số lượng";
            this.soluong2.Name = "soluong2";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // daban2
            // 
            this.daban2.DataPropertyName = "daban";
            this.daban2.HeaderText = "Đã bán";
            this.daban2.Name = "daban2";
            // 
            // anhbiaDataGridViewImageColumn
            // 
            this.anhbiaDataGridViewImageColumn.DataPropertyName = "anhbia";
            this.anhbiaDataGridViewImageColumn.HeaderText = "Ảnh bìa";
            this.anhbiaDataGridViewImageColumn.Name = "anhbiaDataGridViewImageColumn";
            // 
            // donhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Name = "donhang";
            this.Text = "donhang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.donhang_FormClosing);
            this.Load += new System.EventHandler(this.donhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sach3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private bansachDataSet11 bansachDataSet11;
        private System.Windows.Forms.BindingSource sach3BindingSource;
        private bansachDataSet11TableAdapters.sach3TableAdapter sach3TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private bansachDataSet12 bansachDataSet12;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
        private bansachDataSet12TableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private bansachDataSet13 bansachDataSet13;
        private System.Windows.Forms.BindingSource hoadon2BindingSource;
        private bansachDataSet13TableAdapters.hoadon2TableAdapter hoadon2TableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuatbanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daban2;
        private System.Windows.Forms.DataGridViewImageColumn anhbiaDataGridViewImageColumn;
    }
}