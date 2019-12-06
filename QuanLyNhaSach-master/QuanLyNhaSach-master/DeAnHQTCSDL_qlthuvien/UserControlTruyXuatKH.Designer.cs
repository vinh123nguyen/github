namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlTruyXuatKH
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv_KH = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soDT = new System.Windows.Forms.TextBox();
            this.txt_DCKH = new System.Windows.Forms.TextBox();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.cb_GT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KH)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(488, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tên khách hàng";
            this.label6.UseWaitCursor = true;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Location = new System.Drawing.Point(617, 3);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(272, 26);
            this.txt_TenKH.TabIndex = 62;
            this.txt_TenKH.TextChanged += new System.EventHandler(this.Txt_TenKH_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dtgv_KH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1315, 416);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // dtgv_KH
            // 
            this.dtgv_KH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_KH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_KH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_KH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgv_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_KH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.NGAYSINH,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgv_KH.Location = new System.Drawing.Point(13, 25);
            this.dtgv_KH.Name = "dtgv_KH";
            this.dtgv_KH.ReadOnly = true;
            this.dtgv_KH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_KH.Size = new System.Drawing.Size(1296, 385);
            this.dtgv_KH.TabIndex = 45;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 20F;
            this.Column2.HeaderText = "STT";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HOTEN";
            this.Column3.HeaderText = "Họ tên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GIOITINH";
            this.Column5.HeaderText = "Giới tính";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DIACHI";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DTKH";
            this.Column7.HeaderText = "Số điện thoại";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(928, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Số điện thoại";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Địa chỉ";
            this.label3.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Mã khách hàng";
            this.label1.UseWaitCursor = true;
            // 
            // txt_soDT
            // 
            this.txt_soDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soDT.Location = new System.Drawing.Point(1036, 3);
            this.txt_soDT.Name = "txt_soDT";
            this.txt_soDT.Size = new System.Drawing.Size(226, 26);
            this.txt_soDT.TabIndex = 65;
            this.txt_soDT.UseWaitCursor = true;
            this.txt_soDT.TextChanged += new System.EventHandler(this.Txt_soDT_TextChanged);
            // 
            // txt_DCKH
            // 
            this.txt_DCKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DCKH.Location = new System.Drawing.Point(383, 38);
            this.txt_DCKH.Name = "txt_DCKH";
            this.txt_DCKH.Size = new System.Drawing.Size(350, 26);
            this.txt_DCKH.TabIndex = 64;
            this.txt_DCKH.UseWaitCursor = true;
            this.txt_DCKH.TextChanged += new System.EventHandler(this.Txt_DCKH_TextChanged);
            // 
            // txt_maKH
            // 
            this.txt_maKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maKH.Location = new System.Drawing.Point(172, 0);
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.Size = new System.Drawing.Size(301, 26);
            this.txt_maKH.TabIndex = 63;
            this.txt_maKH.UseWaitCursor = true;
            this.txt_maKH.TextChanged += new System.EventHandler(this.Txt_maKH_TextChanged);
            // 
            // cb_GT
            // 
            this.cb_GT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GT.FormattingEnabled = true;
            this.cb_GT.Location = new System.Drawing.Point(823, 37);
            this.cb_GT.Name = "cb_GT";
            this.cb_GT.Size = new System.Drawing.Size(121, 28);
            this.cb_GT.TabIndex = 71;
            this.cb_GT.UseWaitCursor = true;
            this.cb_GT.TextChanged += new System.EventHandler(this.Cb_GT_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(750, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 72;
            this.label7.Text = "Giới tính";
            this.label7.UseWaitCursor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // UserControlTruyXuatKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cb_GT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soDT);
            this.Controls.Add(this.txt_DCKH);
            this.Controls.Add(this.txt_maKH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.groupBox2);
            this.Name = "UserControlTruyXuatKH";
            this.Size = new System.Drawing.Size(1315, 489);
            this.Load += new System.EventHandler(this.UserControlTruyXuatKH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_KH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TenKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soDT;
        private System.Windows.Forms.TextBox txt_DCKH;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dtgv_KH;
        private System.Windows.Forms.ComboBox cb_GT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}
