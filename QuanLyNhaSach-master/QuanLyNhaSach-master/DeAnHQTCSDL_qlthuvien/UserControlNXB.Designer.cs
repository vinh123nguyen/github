namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNXB));
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grb_nxb = new System.Windows.Forms.GroupBox();
            this.dtgv_nxb = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grb_thongnxb = new System.Windows.Forms.GroupBox();
            this.txt_dtnxb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_dcnxb = new System.Windows.Forms.TextBox();
            this.txt_tennxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_manxb = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grb_nxb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nxb)).BeginInit();
            this.grb_thongnxb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tìm kiếm tên nhà xuất bản";
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(523, 137);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(321, 26);
            this.txt_tk.TabIndex = 26;
            this.txt_tk.TextChanged += new System.EventHandler(this.Txt_tk_TextChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(832, 80);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(128, 44);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.BtnHuy_Click);
            // 
            // grb_nxb
            // 
            this.grb_nxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_nxb.Controls.Add(this.dtgv_nxb);
            this.grb_nxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_nxb.Location = new System.Drawing.Point(3, 160);
            this.grb_nxb.Name = "grb_nxb";
            this.grb_nxb.Size = new System.Drawing.Size(1309, 326);
            this.grb_nxb.TabIndex = 23;
            this.grb_nxb.TabStop = false;
            this.grb_nxb.Text = "Danh sách nhà xuất bản";
            // 
            // dtgv_nxb
            // 
            this.dtgv_nxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_nxb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_nxb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgv_nxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nxb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MANXB,
            this.TENNXB,
            this.DCNXB,
            this.DTNXB});
            this.dtgv_nxb.Location = new System.Drawing.Point(3, 19);
            this.dtgv_nxb.Name = "dtgv_nxb";
            this.dtgv_nxb.Size = new System.Drawing.Size(1300, 304);
            this.dtgv_nxb.TabIndex = 0;
            this.dtgv_nxb.SelectionChanged += new System.EventHandler(this.Dtgv_nxb_SelectionChanged);
            // 
            // stt1
            // 
            this.stt1.FillWeight = 20F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MANXB
            // 
            this.MANXB.DataPropertyName = "MANXB";
            this.MANXB.FillWeight = 110F;
            this.MANXB.HeaderText = "Mã nhà xuất bản";
            this.MANXB.Name = "MANXB";
            // 
            // TENNXB
            // 
            this.TENNXB.DataPropertyName = "TENNXB";
            this.TENNXB.FillWeight = 200F;
            this.TENNXB.HeaderText = "Nhà xuất bản";
            this.TENNXB.Name = "TENNXB";
            // 
            // DCNXB
            // 
            this.DCNXB.DataPropertyName = "DCNXB";
            this.DCNXB.FillWeight = 120F;
            this.DCNXB.HeaderText = "Địa chỉ nhà xuất bản";
            this.DCNXB.Name = "DCNXB";
            // 
            // DTNXB
            // 
            this.DTNXB.DataPropertyName = "DTNXB";
            this.DTNXB.HeaderText = "Điện thoại nhà xuất bản";
            this.DTNXB.Name = "DTNXB";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(678, 80);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 44);
            this.btnLuu.TabIndex = 28;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // grb_thongnxb
            // 
            this.grb_thongnxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_thongnxb.BackColor = System.Drawing.Color.Transparent;
            this.grb_thongnxb.Controls.Add(this.txt_dtnxb);
            this.grb_thongnxb.Controls.Add(this.label2);
            this.grb_thongnxb.Controls.Add(this.txt_dcnxb);
            this.grb_thongnxb.Controls.Add(this.txt_tennxb);
            this.grb_thongnxb.Controls.Add(this.label5);
            this.grb_thongnxb.Controls.Add(this.label3);
            this.grb_thongnxb.Controls.Add(this.label1);
            this.grb_thongnxb.Controls.Add(this.txt_manxb);
            this.grb_thongnxb.Enabled = false;
            this.grb_thongnxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_thongnxb.Location = new System.Drawing.Point(0, 3);
            this.grb_thongnxb.Name = "grb_thongnxb";
            this.grb_thongnxb.Size = new System.Drawing.Size(1312, 71);
            this.grb_thongnxb.TabIndex = 24;
            this.grb_thongnxb.TabStop = false;
            this.grb_thongnxb.Text = "Thông tin nhà xuất bản";
            // 
            // txt_dtnxb
            // 
            this.txt_dtnxb.Location = new System.Drawing.Point(1134, 36);
            this.txt_dtnxb.Name = "txt_dtnxb";
            this.txt_dtnxb.Size = new System.Drawing.Size(172, 26);
            this.txt_dtnxb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(951, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Điện thoại nhà xuất bản";
            // 
            // txt_dcnxb
            // 
            this.txt_dcnxb.Location = new System.Drawing.Point(763, 33);
            this.txt_dcnxb.Name = "txt_dcnxb";
            this.txt_dcnxb.Size = new System.Drawing.Size(172, 26);
            this.txt_dcnxb.TabIndex = 2;
            // 
            // txt_tennxb
            // 
            this.txt_tennxb.Location = new System.Drawing.Point(387, 32);
            this.txt_tennxb.Name = "txt_tennxb";
            this.txt_tennxb.Size = new System.Drawing.Size(182, 26);
            this.txt_tennxb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Địa chỉ nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhà xuất bản";
            // 
            // txt_manxb
            // 
            this.txt_manxb.Location = new System.Drawing.Point(139, 33);
            this.txt_manxb.Name = "txt_manxb";
            this.txt_manxb.Size = new System.Drawing.Size(95, 26);
            this.txt_manxb.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(520, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 44);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(208, 80);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 44);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(365, 80);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 44);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UserControlNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_nxb);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grb_thongnxb);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "UserControlNXB";
            this.Size = new System.Drawing.Size(1315, 489);
            this.Load += new System.EventHandler(this.UserControlNXB_Load);
            this.grb_nxb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nxb)).EndInit();
            this.grb_thongnxb.ResumeLayout(false);
            this.grb_thongnxb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grb_nxb;
        private System.Windows.Forms.DataGridView dtgv_nxb;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox grb_thongnxb;
        private System.Windows.Forms.TextBox txt_dtnxb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dcnxb;
        private System.Windows.Forms.TextBox txt_tennxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_manxb;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTNXB;
        private System.Windows.Forms.Timer timer1;
    }
}
