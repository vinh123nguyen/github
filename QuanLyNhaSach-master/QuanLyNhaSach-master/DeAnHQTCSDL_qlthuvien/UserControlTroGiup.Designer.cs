namespace DeAnHQTCSDL_qlthuvien
{
    partial class UserControlTroGiup
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
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.FocusHighlightColor = System.Drawing.Color.White;
            this.textBoxX1.Font = new System.Drawing.Font("Mistral", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxX1.Location = new System.Drawing.Point(3, 3);
            this.textBoxX1.Multiline = true;
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.PreventEnterBeep = true;
            this.textBoxX1.ReadOnly = true;
            this.textBoxX1.Size = new System.Drawing.Size(1696, 162);
            this.textBoxX1.TabIndex = 1;
            this.textBoxX1.Text = "Công ty cổ phần TNHH 1 số thành viên chưa biết xin kính chào các bạn.\r\nLiên hệ 03" +
    "98704477 để bik thêm thông tin chi tiết.(chỉ làm h hành chánh)";
            this.textBoxX1.WatermarkColor = System.Drawing.Color.White;
            // 
            // UserControlTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.Controls.Add(this.textBoxX1);
            this.Name = "UserControlTroGiup";
            this.Size = new System.Drawing.Size(1315, 168);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
    }
}
