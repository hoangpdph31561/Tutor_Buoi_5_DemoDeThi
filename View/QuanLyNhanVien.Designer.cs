namespace TuTor_Ngay4_8_23_CS3.View
{
    partial class QuanLyNhanVien
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
            groupBox1 = new GroupBox();
            cmbChucVu = new ComboBox();
            radBtnNu = new RadioButton();
            radBtnNam = new RadioButton();
            txtSoDienThoai = new TextBox();
            txtHoTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClearForm = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            dgvNhanVien = new DataGridView();
            txtTimKiem = new TextBox();
            label = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbChucVu);
            groupBox1.Controls.Add(radBtnNu);
            groupBox1.Controls.Add(radBtnNam);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 322);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // cmbChucVu
            // 
            cmbChucVu.FormattingEnabled = true;
            cmbChucVu.Location = new Point(193, 252);
            cmbChucVu.Name = "cmbChucVu";
            cmbChucVu.Size = new Size(245, 28);
            cmbChucVu.TabIndex = 8;
            // 
            // radBtnNu
            // 
            radBtnNu.AutoSize = true;
            radBtnNu.Location = new Point(370, 183);
            radBtnNu.Name = "radBtnNu";
            radBtnNu.Size = new Size(50, 24);
            radBtnNu.TabIndex = 7;
            radBtnNu.TabStop = true;
            radBtnNu.Text = "Nữ";
            radBtnNu.UseVisualStyleBackColor = true;
            // 
            // radBtnNam
            // 
            radBtnNam.AutoSize = true;
            radBtnNam.Location = new Point(193, 183);
            radBtnNam.Name = "radBtnNam";
            radBtnNam.Size = new Size(62, 24);
            radBtnNam.TabIndex = 6;
            radBtnNam.TabStop = true;
            radBtnNam.Text = "Nam";
            radBtnNam.UseVisualStyleBackColor = true;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(193, 112);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(245, 27);
            txtSoDienThoai.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(193, 42);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(245, 27);
            txtHoTen.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 255);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 185);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Giới tính";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 115);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 45);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClearForm);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(543, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(245, 322);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnClearForm
            // 
            btnClearForm.Location = new Point(6, 231);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(233, 47);
            btnClearForm.TabIndex = 3;
            btnClearForm.Text = "Clear";
            btnClearForm.UseVisualStyleBackColor = true;
            btnClearForm.Click += btnClearForm_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(233, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(6, 107);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(233, 47);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(233, 47);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvNhanVien);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(label);
            groupBox3.Location = new Point(12, 340);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 340);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(54, 96);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(695, 220);
            dgvNhanVien.TabIndex = 2;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(304, 33);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên để loại trừ";
            txtTimKiem.Size = new Size(376, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(155, 36);
            label.Name = "label";
            label.Size = new Size(70, 20);
            label.TabIndex = 0;
            label.Text = "Tìm kiếm";
            // 
            // QuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 697);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLyNhanVien";
            Load += QuanLyNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbChucVu;
        private RadioButton radBtnNu;
        private RadioButton radBtnNam;
        private TextBox txtSoDienThoai;
        private TextBox txtHoTen;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnClearForm;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox3;
        private DataGridView dgvNhanVien;
        private TextBox txtTimKiem;
        private Label label;
    }
}