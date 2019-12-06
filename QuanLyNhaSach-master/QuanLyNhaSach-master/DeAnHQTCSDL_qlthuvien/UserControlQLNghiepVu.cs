using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeAnHQTCSDL_qlthuvien
{
    public partial class UserControlQLNghiepVu : UserControl
    {
        public UserControlQLNghiepVu()
        {
            InitializeComponent();
        }

        private void MetroTileItemLHD_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 21;
        }

        private void MetroTileItemKhachHang_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 22;
        }

        private void MetroTileItem1_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 23;
        }
    }
}
