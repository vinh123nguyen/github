namespace DeAnHQTCSDL_qlthuvien
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Admin = new System.Windows.Forms.RadioButton();
            this.khachhang = new System.Windows.Forms.RadioButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.khachhang);
            this.panelEx1.Controls.Add(this.Admin);
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(229, 207);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(58, 149);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(108, 39);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "Kết nối";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Checked = true;
            this.Admin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(60, 60);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(78, 25);
            this.Admin.TabIndex = 1;
            this.Admin.TabStop = true;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.CheckedChanged += new System.EventHandler(this.Admin_CheckedChanged);
            // 
            // khachhang
            // 
            this.khachhang.AutoSize = true;
            this.khachhang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khachhang.Location = new System.Drawing.Point(60, 107);
            this.khachhang.Name = "khachhang";
            this.khachhang.Size = new System.Drawing.Size(120, 25);
            this.khachhang.TabIndex = 2;
            this.khachhang.Text = "Khách Hàng";
            this.khachhang.UseVisualStyleBackColor = true;
            this.khachhang.CheckedChanged += new System.EventHandler(this.khachhang_CheckedChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(12, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(222, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Truy Cập SQL bằng quyền";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 207);
            this.Controls.Add(this.panelEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.RadioButton khachhang;
        private System.Windows.Forms.RadioButton Admin;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}