using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Nhom2.Menu
{
    public partial class MenuNhanVien : Form
    {
        public MenuNhanVien()
        {
            InitializeComponent();
        }
        public void addForm(Form frm)
        {
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            if (this.pnlMenu.Controls.Count > 0)
            {
                this.pnlMenu.Controls.RemoveAt(0);
            }
            this.pnlMenu.Controls.Add(frm);
            frm.Show();
        }
        private void IMBanHang_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menuQL.Items.Count; i++)
            {
                menuQL.Items[i].BackColor = menuQL.BackColor;
            }
            IMBanHang.BackColor = Color.LavenderBlush;
            var frm = new BanHang();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

       

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new QuanLy.QLKhachHang();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }
      
     
        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormPhieuNhap();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new NhaCC();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void IMDSSanPham_Click(object sender, EventArgs e)
        {
            var frm = new San_Pham.DSSanPham();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form_HoaDon();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void báoCáoTàiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormBCTaiChinh();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();

        }

        private void báoCáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormBaoCaoTK();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void IMTrangChu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menuQL.Items.Count; i++)
            {
                menuQL.Items[i].BackColor = menuQL.BackColor;
            }
            IMTrangChu.BackColor = Color.LavenderBlush;
            if (this.pnlMenu.Controls.Count > 0)
            {
                this.pnlMenu.Controls.RemoveAt(0);
            }
            //Form frm = new MenuQuanLy();
            //frm.Show();
        }

        private void IMDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vềChúngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menuQL.Items.Count; i++)
            {
                menuQL.Items[i].BackColor = menuQL.BackColor;
            }
            vềChúngTôiToolStripMenuItem.BackColor = Color.LavenderBlush;
            var frm = new Frm_GT();
            addForm(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void MenuNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void IMSanPham_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menuQL.Items.Count; i++)
            {
                menuQL.Items[i].BackColor = menuQL.BackColor;
            }
            IMSanPham.BackColor = Color.LavenderBlush;
        }

        private void IMQuanLy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < menuQL.Items.Count; i++)
            {
                menuQL.Items[i].BackColor = menuQL.BackColor;
            }
            IMQuanLy.BackColor = Color.LavenderBlush;
        }
    }
}
