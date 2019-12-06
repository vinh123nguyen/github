namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTK));
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grb_tk = new System.Windows.Forms.GroupBox();
            this.dtgv_tk = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWORK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYLAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_THONGTINTK = new System.Windows.Forms.GroupBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_matk = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grb_tk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tk)).BeginInit();
            this.grb_THONGTINTK.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Tìm mã tài khoản";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(349, 134);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 26);
            this.textBox1.TabIndex = 57;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_xoa.Location = new System.Drawing.Point(481, 80);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(116, 45);
            this.btn_xoa.TabIndex = 63;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnHuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.BackgroundImage")));
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(924, 80);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 45);
            this.btnHuy.TabIndex = 60;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grb_tk
            // 
            this.grb_tk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_tk.Controls.Add(this.dtgv_tk);
            this.grb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_tk.Location = new System.Drawing.Point(3, 153);
            this.grb_tk.Name = "grb_tk";
            this.grb_tk.Size = new System.Drawing.Size(1312, 333);
            this.grb_tk.TabIndex = 58;
            this.grb_tk.TabStop = false;
            this.grb_tk.Text = "Danh sách tài khoản";
            // 
            // dtgv_tk
            // 
            this.dtgv_tk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_tk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_tk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgv_tk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MATK,
            this.QUYEN,
            this.PASSWORK,
            this.NGAYLAP});
            this.dtgv_tk.Location = new System.Drawing.Point(6, 21);
            this.dtgv_tk.Name = "dtgv_tk";
            this.dtgv_tk.Size = new System.Drawing.Size(1303, 306);
            this.dtgv_tk.TabIndex = 0;
            this.dtgv_tk.SelectionChanged += new System.EventHandler(this.dtgv_tk_SelectionChanged);
            // 
            // stt1
            // 
            this.stt1.FillWeight = 50F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MATK
            // 
            this.MATK.DataPropertyName = "MATK";
            this.MATK.FillWeight = 110F;
            this.MATK.HeaderText = "Mã tài khoản";
            this.MATK.Name = "MATK";
            // 
            // QUYEN
            // 
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.FillWeight = 200F;
            this.QUYEN.HeaderText = "Quyền";
            this.QUYEN.Name = "QUYEN";
            // 
            // PASSWORK
            // 
            this.PASSWORK.DataPropertyName = "PASSWORK";
            this.PASSWORK.HeaderText = "Mật khẩu";
            this.PASSWORK.Name = "PASSWORK";
            // 
            // NGAYLAP
            // 
            this.NGAYLAP.DataPropertyName = "NGAYLAP";
            this.NGAYLAP.HeaderText = "Ngày lập";
            this.NGAYLAP.Name = "NGAYLAP";
            // 
            // grb_THONGTINTK
            // 
            this.grb_THONGTINTK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_THONGTINTK.BackColor = System.Drawing.Color.Transparent;
            this.grb_THONGTINTK.Controls.Add(this.txt_q);
            this.grb_THONGTINTK.Controls.Add(this.dtp_ngaylap);
            this.grb_THONGTINTK.Controls.Add(this.label4);
            this.grb_THONGTINTK.Controls.Add(this.txt_mk);
            this.grb_THONGTINTK.Controls.Add(this.label2);
            this.grb_THONGTINTK.Controls.Add(this.label3);
            this.grb_THONGTINTK.Controls.Add(this.label1);
            this.grb_THONGTINTK.Controls.Add(this.txt_matk);
            this.grb_THONGTINTK.Enabled = false;
            this.grb_THONGTINTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_THONGTINTK.Location = new System.Drawing.Point(208, 3);
            this.grb_THONGTINTK.Name = "grb_THONGTINTK";
            this.grb_THONGTINTK.Size = new System.Drawing.Size(982, 71);
            this.grb_THONGTINTK.TabIndex = 59;
            this.grb_THONGTINTK.TabStop = false;
            this.grb_THONGTINTK.Text = "Thông tin tài khoản";
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(299, 35);
            this.txt_q.MaxLength = 10;
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(148, 26);
            this.txt_q.TabIndex = 21;
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaylap.Location = new System.Drawing.Point(829, 35);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(132, 26);
            this.dtp_ngaylap.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày lập";
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(534, 35);
            this.txt_mk.MaxLength = 10;
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(192, 26);
            this.txt_mk.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quyền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã tài khoản";
            // 
            // txt_matk
            // 
            this.txt_matk.Location = new System.Drawing.Point(112, 35);
            this.txt_matk.MaxLength = 10;
            this.txt_matk.Name = "txt_matk";
            this.txt_matk.Size = new System.Drawing.Size(120, 26);
            this.txt_matk.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(625, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 45);
            this.btnSua.TabIndex = 62;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLuu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.BackgroundImage")));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(773, 80);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(116, 45);
            this.btnLuu.TabIndex = 61;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKhoiPhuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKhoiPhuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKhoiPhuc.BackgroundImage")));
            this.btnKhoiPhuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKhoiPhuc.Location = new System.Drawing.Point(329, 80);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(116, 45);
            this.btnKhoiPhuc.TabIndex = 64;
            this.btnKhoiPhuc.Text = "Khôi Phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = false;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.BtnKhoiPhuc_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(924, 131);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 26);
            this.textBox2.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(726, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 66;
            this.label5.Text = "Xuất tài khoản có quyền";
            // 
            // UserControlTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grb_tk);
            this.Controls.Add(this.grb_THONGTINTK);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Name = "UserControlTK";
            this.Size = new System.Drawing.Size(1315, 489);
            this.Load += new System.EventHandler(this.UserControlTK_Load);
            this.grb_tk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tk)).EndInit();
            this.grb_THONGTINTK.ResumeLayout(false);
            this.grb_THONGTINTK.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grb_tk;
        private System.Windows.Forms.DataGridView dtgv_tk;
        private System.Windows.Forms.GroupBox grb_THONGTINTK;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matk;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATK;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWORK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYLAP;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}
