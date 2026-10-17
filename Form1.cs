using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVienn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            mainform frmMain = new mainform();
            frmMain.Show();
            this.Hide();
            frmMain.DangXuat += FrmMain_DangXuat;
        }

        private void FrmMain_DangXuat(object sender, EventArgs e)
        {
            (sender as mainform).is_logout = true;
            (sender as mainform).Close();
            this.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
               
            }
            else
            {
                e.Cancel = true;

            }
        }
    }
}
