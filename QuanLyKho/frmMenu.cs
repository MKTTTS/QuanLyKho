using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using System.IO;
namespace QuanLyKho
{
    public partial class frmMenu : Form
    {
          TabPage tabPage2 = new TabPage();
          TabPage tabPage3 = new TabPage();
          TabPage tabPage4 = new TabPage();
          TabPage tabPage5 = new TabPage();

          public frmMenu()
        {
            InitializeComponent();
          
            
        }

          public void remove()
          {
               tabControl1.TabPages.Remove(tabPage2);
               tabControl1.TabPages.Remove(tabPage3);
               tabControl1.TabPages.Remove(tabPage4);
               tabControl1.TabPages.Remove(tabPage5);
          }

          private void checkmk_CheckedChanged(object sender, EventArgs e)
          {
               if (txtmatkhau.UseSystemPasswordChar == true)
               {
                    txtmatkhau.UseSystemPasswordChar = false;
               }
               else
               {
                    txtmatkhau.UseSystemPasswordChar = true;
               }
          }

          public void hien()
          {
               btnNhapKho.Enabled = true;
               btnXuatKho.Enabled = true;
               btnThongKe.Enabled = true;
               btnTaiKhoan.Enabled = true;
               
          }

          private void btndangnhap_Click(object sender, EventArgs e)
          {
               if (TaiKhoanDAO.DangNhap(txttk.Text, txtmatkhau.Text) == true)
               {
                    tabControl1.TabPages.Remove(tabPage1);
                    hien();
               }
               else
               {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttaikhoan.Focus();
               }
          }

          private void btnthoat_Click(object sender, EventArgs e)
          {
               if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
               {
                    Application.Exit();
               }
          }

          private void btnXuatKho_Click(object sender, EventArgs e)
          {
               remove();
               frmXuatKho f = new frmXuatKho();
               f.TopLevel = false;
               f.FormBorderStyle = FormBorderStyle.None;
               f.Dock = DockStyle.Fill;
               tabPage3.Controls.Add(f);
               f.Visible = true;
               tabPage3.Text = "Xuất Kho";
               tabControl1.TabPages.Add(tabPage3);
          }

          private void btnNhapKho_Click(object sender, EventArgs e)
          {
               remove();
               frmNhapKho f = new frmNhapKho();
               f.TopLevel = false;
               f.FormBorderStyle = FormBorderStyle.None;
               f.Dock = DockStyle.Fill;
               tabPage2.Controls.Add(f);
               f.Visible = true;
               tabPage2.Text = "Nhập Kho";
               tabControl1.TabPages.Add(tabPage2);
          }

          private void btnThongKe_Click(object sender, EventArgs e)
          {
               remove();
               frmThongKe f = new frmThongKe();
               f.TopLevel = false;
               f.FormBorderStyle = FormBorderStyle.None;
               f.Dock = DockStyle.Fill;
               tabPage4.Controls.Add(f);
               f.Visible = true;
               tabPage4.Text = "Thống Kê";
               tabControl1.TabPages.Add(tabPage4);
          }

          private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
          {
               frmThemTaiKhoan f = new frmThemTaiKhoan();
               f.ShowDialog();
          }

          private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
          {
               frmDoiMatKhau f = new frmDoiMatKhau();
               f.ShowDialog();
          }
     } 
}   
