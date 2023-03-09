using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QL_KTX
{
    public partial class frmDangNhap : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Instance.ListTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckLogIn(txtUserName.Text, txtPassword.Text))
            {
                frmTrangChu f = new frmTrangChu();
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Bạn nhập sai tên tài khoản hoặc mật khẩu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        bool CheckLogIn(string Username, string Password)
        {
              for(int i=0; i<listTaiKhoan.Count; i++)
            {
                if(Username == listTaiKhoan[i].UserName && Password == listTaiKhoan[i].PassWord)
                {
                    return true;
                }
            }
              return false;
        }

    }
}
