namespace bansach
{
    partial class FormHoadon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bansachDataSet16 = new bansach.bansachDataSet16();
            this.hoadon2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadon2TableAdapter = new bansach.bansachDataSet16TableAdapters.hoadon2TableAdapter();
            this.tensachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bansachDataSet17 = new bansach.bansachDataSet17();
            this.hoadon3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoadon3TableAdapter = new bansach.bansachDataSet17TableAdapters.hoadon3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tensachDataGridViewTextBoxColumn,
            this.soluongDataGridViewTextBoxColumn,
            this.thanhtienDataGridViewTextBoxColumn,
            this.ngaylapDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hoadon3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(109, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(591, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // bansachDataSet16
            // 
            this.bansachDataSet16.DataSetName = "bansachDataSet16";
            this.bansachDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadon2BindingSource
            // 
            this.hoadon2BindingSource.DataMember = "hoadon2";
            this.hoadon2BindingSource.DataSource = this.bansachDataSet16;
            // 
            // hoadon2TableAdapter
            // 
            this.hoadon2TableAdapter.ClearBeforeFill = true;
            // 
            // tensachDataGridViewTextBoxColumn
            // 
            this.tensachDataGridViewTextBoxColumn.DataPropertyName = "tensach";
            this.tensachDataGridViewTextBoxColumn.HeaderText = "Tên sách";
            this.tensachDataGridViewTextBoxColumn.Name = "tensachDataGridViewTextBoxColumn";
            this.tensachDataGridViewTextBoxColumn.Width = 200;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            this.soluongDataGridViewTextBoxColumn.DataPropertyName = "soluong";
            this.soluongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            // 
            // thanhtienDataGridViewTextBoxColumn
            // 
            this.thanhtienDataGridViewTextBoxColumn.DataPropertyName = "thanhtien";
            this.thanhtienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.thanhtienDataGridViewTextBoxColumn.Name = "thanhtienDataGridViewTextBoxColumn";
            // 
            // ngaylapDataGridViewTextBoxColumn
            // 
            this.ngaylapDataGridViewTextBoxColumn.DataPropertyName = "ngaylap";
            this.ngaylapDataGridViewTextBoxColumn.HeaderText = "Ngày mua";
            this.ngaylapDataGridViewTextBoxColumn.Name = "ngaylapDataGridViewTextBoxColumn";
            this.ngaylapDataGridViewTextBoxColumn.Width = 150;
            // 
            // bansachDataSet17
            // 
            this.bansachDataSet17.DataSetName = "bansachDataSet17";
            this.bansachDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadon3BindingSource
            // 
            this.hoadon3BindingSource.DataMember = "hoadon3";
            this.hoadon3BindingSource.DataSource = this.bansachDataSet17;
            // 
            // hoadon3TableAdapter
            // 
            this.hoadon3TableAdapter.ClearBeforeFill = true;
            // 
            // FormHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormHoadon";
            this.Text = "FormHoadon";
            this.Load += new System.EventHandler(this.FormHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bansachDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoadon3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bansachDataSet16 bansachDataSet16;
        private System.Windows.Forms.BindingSource hoadon2BindingSource;
        private bansachDataSet16TableAdapters.hoadon2TableAdapter hoadon2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapDataGridViewTextBoxColumn;
        private bansachDataSet17 bansachDataSet17;
        private System.Windows.Forms.BindingSource hoadon3BindingSource;
        private bansachDataSet17TableAdapters.hoadon3TableAdapter hoadon3TableAdapter;
    }
}