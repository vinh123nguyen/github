namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlTLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTLS));
            this.grb_tk = new System.Windows.Forms.GroupBox();
            this.textBoxTimTheLoai = new System.Windows.Forms.TextBox();
            this.textBoxTimMaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grb_ls = new System.Windows.Forms.GroupBox();
            this.dtgv_loaisach = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAISH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_loaisach = new System.Windows.Forms.GroupBox();
            this.txt_tenloaish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maloaish = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grb_tk.SuspendLayout();
            this.grb_ls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisach)).BeginInit();
            this.grb_loaisach.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_tk
            // 
            this.grb_tk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_tk.BackColor = System.Drawing.Color.Transparent;
            this.grb_tk.Controls.Add(this.textBoxTimTheLoai);
            this.grb_tk.Controls.Add(this.textBoxTimMaSach);
            this.grb_tk.Controls.Add(this.label2);
            this.grb_tk.Controls.Add(this.label4);
            this.grb_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_tk.Location = new System.Drawing.Point(229, 122);
            this.grb_tk.Name = "grb_tk";
            this.grb_tk.Size = new System.Drawing.Size(913, 49);
            this.grb_tk.TabIndex = 43;
            this.grb_tk.TabStop = false;
            this.grb_tk.Text = "Tìm kiếm thông tin";
            // 
            // textBoxTimTheLoai
            // 
            this.textBoxTimTheLoai.Location = new System.Drawing.Point(619, 18);
            this.textBoxTimTheLoai.MaxLength = 10;
            this.textBoxTimTheLoai.Name = "textBoxTimTheLoai";
            this.textBoxTimTheLoai.Size = new System.Drawing.Size(274, 26);
            this.textBoxTimTheLoai.TabIndex = 3;
            this.textBoxTimTheLoai.TextChanged += new System.EventHandler(this.textBoxTimTheLoai_TextChanged);
            // 
            // textBoxTimMaSach
            // 
            this.textBoxTimMaSach.Location = new System.Drawing.Point(203, 18);
            this.textBoxTimMaSach.MaxLength = 10;
            this.textBoxTimMaSach.Name = "textBoxTimMaSach";
            this.textBoxTimMaSach.Size = new System.Drawing.Size(237, 26);
            this.textBoxTimMaSach.TabIndex = 2;
            this.textBoxTimMaSach.TextChanged += new System.EventHandler(this.textBoxTimMaSach_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm theo thể loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm theo mã loại sách";
            // 
            // grb_ls
            // 
            this.grb_ls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_ls.Controls.Add(this.dtgv_loaisach);
            this.grb_ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_ls.Location = new System.Drawing.Point(84, 158);
            this.grb_ls.Name = "grb_ls";
            this.grb_ls.Size = new System.Drawing.Size(1167, 328);
            this.grb_ls.TabIndex = 41;
            this.grb_ls.TabStop = false;
            this.grb_ls.Text = "Chi tiết loại sách";
            // 
            // dtgv_loaisach
            // 
            this.dtgv_loaisach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_loaisach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_loaisach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgv_loaisach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_loaisach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.MALOAISH,
            this.TENLOAISH});
            this.dtgv_loaisach.Location = new System.Drawing.Point(6, 21);
            this.dtgv_loaisach.Name = "dtgv_loaisach";
            this.dtgv_loaisach.Size = new System.Drawing.Size(1155, 301);
            this.dtgv_loaisach.TabIndex = 0;
            this.dtgv_loaisach.SelectionChanged += new System.EventHandler(this.dtgv_loaisach_SelectionChanged);
            // 
            // stt1
            // 
            this.stt1.FillWeight = 50F;
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            // 
            // MALOAISH
            // 
            this.MALOAISH.DataPropertyName = "MALOAISH";
            this.MALOAISH.FillWeight = 110F;
            this.MALOAISH.HeaderText = "Mã loại sách";
            this.MALOAISH.Name = "MALOAISH";
            // 
            // TENLOAISH
            // 
            this.TENLOAISH.DataPropertyName = "TENLOAISH";
            this.TENLOAISH.FillWeight = 150F;
            this.TENLOAISH.HeaderText = "Thể loại";
            this.TENLOAISH.Name = "TENLOAISH";
            // 
            // grb_loaisach
            // 
            this.grb_loaisach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_loaisach.BackColor = System.Drawing.Color.Transparent;
            this.grb_loaisach.Controls.Add(this.txt_tenloaish);
            this.grb_loaisach.Controls.Add(this.label3);
            this.grb_loaisach.Controls.Add(this.label1);
            this.grb_loaisach.Controls.Add(this.txt_maloaish);
            this.grb_loaisach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_loaisach.Location = new System.Drawing.Point(274, 3);
            this.grb_loaisach.Name = "grb_loaisach";
            this.grb_loaisach.Size = new System.Drawing.Size(791, 60);
            this.grb_loaisach.TabIndex = 42;
            this.grb_loaisach.TabStop = false;
            this.grb_loaisach.Text = "Thông tin Loại Sách";
            // 
            // txt_tenloaish
            // 
            this.txt_tenloaish.Location = new System.Drawing.Point(548, 29);
            this.txt_tenloaish.MaxLength = 10000000;
            this.txt_tenloaish.Name = "txt_tenloaish";
            this.txt_tenloaish.Size = new System.Drawing.Size(221, 26);
            this.txt_tenloaish.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã loại sách";
            // 
            // txt_maloaish
            // 
            this.txt_maloaish.Location = new System.Drawing.Point(203, 28);
            this.txt_maloaish.MaxLength = 10;
            this.txt_maloaish.Name = "txt_maloaish";
            this.txt_maloaish.Size = new System.Drawing.Size(205, 26);
            this.txt_maloaish.TabIndex = 0;
            this.txt_maloaish.TextChanged += new System.EventHandler(this.txt_maloaish_TextChanged);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(774, 69);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(106, 47);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(510, 69);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(106, 47);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(643, 69);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 47);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UserControlTLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grb_tk);
            this.Controls.Add(this.grb_ls);
            this.Controls.Add(this.grb_loaisach);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Name = "UserControlTLS";
            this.Size = new System.Drawing.Size(1315, 489);
            this.Load += new System.EventHandler(this.UserControlTLS_Load);
            this.grb_tk.ResumeLayout(false);
            this.grb_tk.PerformLayout();
            this.grb_ls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_loaisach)).EndInit();
            this.grb_loaisach.ResumeLayout(false);
            this.grb_loaisach.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grb_ls;
        private System.Windows.Forms.DataGridView dtgv_loaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAISH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAISH;
        private System.Windows.Forms.GroupBox grb_loaisach;
        private System.Windows.Forms.TextBox txt_tenloaish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maloaish;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox textBoxTimTheLoai;
        private System.Windows.Forms.TextBox textBoxTimMaSach;
        private System.Windows.Forms.Timer timer1;
    }
}
