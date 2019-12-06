namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlQLNhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlQLNhanVien));
            this.grb_tk = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grb_dsnv = new System.Windows.Forms.GroupBox();
            this.dtgvDS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHINV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUCVU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_thongtinnhanvien = new System.Windows.Forms.GroupBox();
            this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
            this.dt_nvl = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMNQL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msk_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.grb_tk.SuspendLayout();
            this.grb_dsnv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).BeginInit();
            this.grb_thongtinnhanvien.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_tk
            // 
            this.grb_tk.Controls.Add(this.label6);
            this.grb_tk.Controls.Add(this.label11);
            this.grb_tk.Controls.Add(this.textBox1);
            this.grb_tk.Controls.Add(this.textBox2);
            this.grb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_tk.Location = new System.Drawing.Point(946, 67);
            this.grb_tk.Name = "grb_tk";
            this.grb_tk.Size = new System.Drawing.Size(315, 98);
            this.grb_tk.TabIndex = 23;
            this.grb_tk.TabStop = false;
            this.grb_tk.Text = "Tra cứu thông tin nhân vên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Mã nhân viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(826, 117);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(114, 48);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(826, 62);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 48);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1070, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(114, 48);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(946, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 48);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(826, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 48);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grb_dsnv
            // 
            this.grb_dsnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_dsnv.BackColor = System.Drawing.Color.Transparent;
            this.grb_dsnv.Controls.Add(this.dtgvDS);
            this.grb_dsnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_dsnv.Location = new System.Drawing.Point(3, 156);
            this.grb_dsnv.Name = "grb_dsnv";
            this.grb_dsnv.Size = new System.Drawing.Size(1307, 332);
            this.grb_dsnv.TabIndex = 17;
            this.grb_dsnv.TabStop = false;
            this.grb_dsnv.Text = "Danh sách nhân viên";
            // 
            // dtgvDS
            // 
            this.dtgvDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MANV,
            this.HOTENNV,
            this.NGAYSINH,
            this.NGAYVL,
            this.GIOITINH,
            this.DIACHINV,
            this.LUONG,
            this.CHUCVU,
            this.MANQL,
            this.TINHTRANG});
            this.dtgvDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDS.Location = new System.Drawing.Point(3, 22);
            this.dtgvDS.Name = "dtgvDS";
            this.dtgvDS.Size = new System.Drawing.Size(1301, 307);
            this.dtgvDS.TabIndex = 0;
            this.dtgvDS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDS_CellContentClick);
            this.dtgvDS.SelectionChanged += new System.EventHandler(this.dtgvDS_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã nhân viên";
            this.MANV.Name = "MANV";
            // 
            // HOTENNV
            // 
            this.HOTENNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTENNV.DataPropertyName = "HOTENNV";
            this.HOTENNV.HeaderText = "Họ tên NV";
            this.HOTENNV.Name = "HOTENNV";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // NGAYVL
            // 
            this.NGAYVL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYVL.DataPropertyName = "NGAYVL";
            this.NGAYVL.HeaderText = "Ngày vào làm";
            this.NGAYVL.Name = "NGAYVL";
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITINH.DataPropertyName = "PHAI";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // DIACHINV
            // 
            this.DIACHINV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIACHINV.DataPropertyName = "DIACHINV";
            this.DIACHINV.HeaderText = "Địa chỉ";
            this.DIACHINV.Name = "DIACHINV";
            // 
            // LUONG
            // 
            this.LUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LUONG.DataPropertyName = "LUONG";
            this.LUONG.HeaderText = "Lương";
            this.LUONG.Name = "LUONG";
            // 
            // CHUCVU
            // 
            this.CHUCVU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CHUCVU.DataPropertyName = "CHUCVU";
            this.CHUCVU.HeaderText = "Chức vụ";
            this.CHUCVU.Name = "CHUCVU";
            // 
            // MANQL
            // 
            this.MANQL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MANQL.DataPropertyName = "MANQL";
            this.MANQL.HeaderText = "Mã người QL";
            this.MANQL.Name = "MANQL";
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.Name = "TINHTRANG";
            // 
            // grb_thongtinnhanvien
            // 
            this.grb_thongtinnhanvien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_thongtinnhanvien.BackColor = System.Drawing.Color.Transparent;
            this.grb_thongtinnhanvien.Controls.Add(this.msk_ngaysinh);
            this.grb_thongtinnhanvien.Controls.Add(this.cmbGioiTinh);
            this.grb_thongtinnhanvien.Controls.Add(this.dt_nvl);
            this.grb_thongtinnhanvien.Controls.Add(this.label4);
            this.grb_thongtinnhanvien.Controls.Add(this.label2);
            this.grb_thongtinnhanvien.Controls.Add(this.txtMNQL);
            this.grb_thongtinnhanvien.Controls.Add(this.label3);
            this.grb_thongtinnhanvien.Controls.Add(this.label1);
            this.grb_thongtinnhanvien.Controls.Add(this.label10);
            this.grb_thongtinnhanvien.Controls.Add(this.txtDiaChi);
            this.grb_thongtinnhanvien.Controls.Add(this.txtTen);
            this.grb_thongtinnhanvien.Controls.Add(this.txtluong);
            this.grb_thongtinnhanvien.Controls.Add(this.txtMa);
            this.grb_thongtinnhanvien.Controls.Add(this.label5);
            this.grb_thongtinnhanvien.Controls.Add(this.txtcv);
            this.grb_thongtinnhanvien.Controls.Add(this.label7);
            this.grb_thongtinnhanvien.Controls.Add(this.label8);
            this.grb_thongtinnhanvien.Controls.Add(this.label9);
            this.grb_thongtinnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongtinnhanvien.Location = new System.Drawing.Point(0, 0);
            this.grb_thongtinnhanvien.Name = "grb_thongtinnhanvien";
            this.grb_thongtinnhanvien.Size = new System.Drawing.Size(775, 150);
            this.grb_thongtinnhanvien.TabIndex = 16;
            this.grb_thongtinnhanvien.TabStop = false;
            this.grb_thongtinnhanvien.Text = "Thông tin nhân viên";
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.FormattingEnabled = true;
            this.cmbGioiTinh.Location = new System.Drawing.Point(120, 49);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Size = new System.Drawing.Size(130, 28);
            this.cmbGioiTinh.TabIndex = 2;
            // 
            // dt_nvl
            // 
            this.dt_nvl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_nvl.Location = new System.Drawing.Point(393, 85);
            this.dt_nvl.Name = "dt_nvl";
            this.dt_nvl.Size = new System.Drawing.Size(221, 26);
            this.dt_nvl.TabIndex = 5;
            this.dt_nvl.Value = new System.DateTime(2018, 10, 26, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính";
            // 
            // txtMNQL
            // 
            this.txtMNQL.Location = new System.Drawing.Point(624, 91);
            this.txtMNQL.Name = "txtMNQL";
            this.txtMNQL.Size = new System.Drawing.Size(143, 26);
            this.txtMNQL.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(647, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã người quản lý";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(368, 49);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(246, 26);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(368, 16);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(246, 26);
            this.txtTen.TabIndex = 1;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(393, 124);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(221, 26);
            this.txtluong.TabIndex = 7;
            this.txtluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtluong_KeyPress);
            // 
            // txtMa
            // 
            this.txtMa.Enabled = false;
            this.txtMa.Location = new System.Drawing.Point(120, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(130, 26);
            this.txtMa.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngày sinh";
            // 
            // txtcv
            // 
            this.txtcv.Location = new System.Drawing.Point(120, 124);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(130, 26);
            this.txtcv.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lương";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ngày vào làm";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msk_ngaysinh
            // 
            this.msk_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.msk_ngaysinh.Location = new System.Drawing.Point(120, 90);
            this.msk_ngaysinh.Name = "msk_ngaysinh";
            this.msk_ngaysinh.Size = new System.Drawing.Size(130, 26);
            this.msk_ngaysinh.TabIndex = 4;
            this.msk_ngaysinh.Value = new System.DateTime(2018, 10, 26, 0, 0, 0, 0);
            // 
            // UserControlQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grb_tk);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grb_dsnv);
            this.Controls.Add(this.grb_thongtinnhanvien);
            this.Name = "UserControlQLNhanVien";
            this.Size = new System.Drawing.Size(1315, 489);
            this.Load += new System.EventHandler(this.UserControlQLNhanVien_Load);
            this.grb_tk.ResumeLayout(false);
            this.grb_tk.PerformLayout();
            this.grb_dsnv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDS)).EndInit();
            this.grb_thongtinnhanvien.ResumeLayout(false);
            this.grb_thongtinnhanvien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_tk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grb_dsnv;
        private System.Windows.Forms.DataGridView dtgvDS;
        private System.Windows.Forms.GroupBox grb_thongtinnhanvien;
        private System.Windows.Forms.ComboBox cmbGioiTinh;
        private System.Windows.Forms.DateTimePicker dt_nvl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMNQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHINV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUCVU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.DateTimePicker msk_ngaysinh;
    }
}
