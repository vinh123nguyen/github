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
    public partial class UserControlQTHT : UserControl
    {
        public UserControlQTHT()
        {
            InitializeComponent();
        }
        private void MetroTileItemQLNV_Click(object sender, EventArgs e)
        {
            //là nút hiện thị bản qlnv khi bấm
            FormMain.ghichu = 11;
        }

        private void MetroTileItemQLS_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 12;
        }

        private void MetroTileItemTLS_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 13;
        }

        private void MetroTileItemNXB_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 14;
        }

        private void MetroTileItemKH_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 15;
        }

        private void MetroTileItemTK_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 16;
        }

        private void MetroTileItemBC_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 17;
        }

        private void metroTileItemSaoLuu_Click(object sender, EventArgs e)
        {
            FormMain.ghichu = 18;
        }
    }
}
