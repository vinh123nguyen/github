namespace DeAnHQTCSDL_qlthuvien
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.btnTroGiup = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQuanLyNghiepVu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQuanTriHeThong = new System.Windows.Forms.Button();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.MouseDetect = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelExMid = new DevComponents.DotNetBar.PanelEx();
            this.panelExMain = new DevComponents.DotNetBar.PanelEx();
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMainMenu.BackColor = System.Drawing.Color.DarkViolet;
            this.panelMainMenu.Controls.Add(this.btnTroGiup);
            this.panelMainMenu.Controls.Add(this.btnDangXuat);
            this.panelMainMenu.Controls.Add(this.btnQuanLyNghiepVu);
            this.panelMainMenu.Controls.Add(this.pictureBox1);
            this.panelMainMenu.Controls.Add(this.btnQuanTriHeThong);
            this.panelMainMenu.Location = new System.Drawing.Point(1, 1);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(41, 459);
            this.panelMainMenu.TabIndex = 0;
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.BackColor = System.Drawing.Color.White;
            this.btnTroGiup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTroGiup.BackgroundImage")));
            this.btnTroGiup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroGiup.ForeColor = System.Drawing.Color.Black;
            this.btnTroGiup.Location = new System.Drawing.Point(0, 305);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(267, 36);
            this.btnTroGiup.TabIndex = 5;
            this.btnTroGiup.Text = " $  Trợ giúp";
            this.btnTroGiup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroGiup.UseVisualStyleBackColor = false;
            this.btnTroGiup.Click += new System.EventHandler(this.BtnTroGiup_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.White;
            this.btnDangXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.BackgroundImage")));
            this.btnDangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 238);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(267, 36);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = " $  Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);
            // 
            // btnQuanLyNghiepVu
            // 
            this.btnQuanLyNghiepVu.BackColor = System.Drawing.Color.White;
            this.btnQuanLyNghiepVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanLyNghiepVu.BackgroundImage")));
            this.btnQuanLyNghiepVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyNghiepVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNghiepVu.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyNghiepVu.Location = new System.Drawing.Point(0, 170);
            this.btnQuanLyNghiepVu.Name = "btnQuanLyNghiepVu";
            this.btnQuanLyNghiepVu.Size = new System.Drawing.Size(267, 36);
            this.btnQuanLyNghiepVu.TabIndex = 4;
            this.btnQuanLyNghiepVu.Text = " $  Quản lý nghiệp vụ";
            this.btnQuanLyNghiepVu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLyNghiepVu.UseVisualStyleBackColor = false;
            this.btnQuanLyNghiepVu.Click += new System.EventHandler(this.BtnQuanLyNghiepVu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnQuanTriHeThong
            // 
            this.btnQuanTriHeThong.BackColor = System.Drawing.Color.White;
            this.btnQuanTriHeThong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanTriHeThong.BackgroundImage")));
            this.btnQuanTriHeThong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanTriHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanTriHeThong.ForeColor = System.Drawing.Color.Black;
            this.btnQuanTriHeThong.Location = new System.Drawing.Point(0, 105);
            this.btnQuanTriHeThong.Name = "btnQuanTriHeThong";
            this.btnQuanTriHeThong.Size = new System.Drawing.Size(267, 36);
            this.btnQuanTriHeThong.TabIndex = 0;
            this.btnQuanTriHeThong.Text = " $  Quản trị hệ thống";
            this.btnQuanTriHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanTriHeThong.UseVisualStyleBackColor = false;
            this.btnQuanTriHeThong.Click += new System.EventHandler(this.BtnQuanTriHeThong_Click);
            // 
            // panelbottom
            // 
            this.panelbottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbottom.BackColor = System.Drawing.Color.DarkViolet;
            this.panelbottom.Controls.Add(this.labelX3);
            this.panelbottom.Controls.Add(this.labelX2);
            this.panelbottom.Controls.Add(this.labelX1);
            this.panelbottom.Location = new System.Drawing.Point(1, 423);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(1284, 37);
            this.panelbottom.TabIndex = 6;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.White;
            this.labelX3.Location = new System.Drawing.Point(545, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(218, 33);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Lê Trọng Hiếu 0358166699";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(278, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(241, 33);
            this.labelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "Nguyễn Quang Vinh 0869871185";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(47, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(218, 33);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 8;
            this.labelX1.Text = "Phùng Thế Hoan 0398704477";
            // 
            // MouseDetect
            // 
            this.MouseDetect.Enabled = true;
            this.MouseDetect.Tick += new System.EventHandler(this.MouseDetect_Tick);
            // 
            // panelExMid
            // 
            this.panelExMid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExMid.AutoSize = true;
            this.panelExMid.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExMid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelExMid.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelExMid.Location = new System.Drawing.Point(48, 178);
            this.panelExMid.Name = "panelExMid";
            this.panelExMid.Size = new System.Drawing.Size(1237, 241);
            this.panelExMid.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMid.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMid.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelExMid.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMid.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMid.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMid.Style.GradientAngle = 90;
            this.panelExMid.TabIndex = 15;
            // 
            // panelExMain
            // 
            this.panelExMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExMain.AutoSize = true;
            this.panelExMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelExMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelExMain.Location = new System.Drawing.Point(48, 1);
            this.panelExMain.Name = "panelExMain";
            this.panelExMain.Size = new System.Drawing.Size(1237, 171);
            this.panelExMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelExMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMain.Style.GradientAngle = 90;
            this.panelExMain.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 460);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelExMain);
            this.Controls.Add(this.panelbottom);
            this.Controls.Add(this.panelExMid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Phần Mền Quản Lý Nhà Sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelbottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Button btnQuanTriHeThong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer MouseDetect;
        private System.Windows.Forms.Button btnTroGiup;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnQuanLyNghiepVu;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panelbottom;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelExMid;
        private DevComponents.DotNetBar.PanelEx panelExMain;
    }
}

