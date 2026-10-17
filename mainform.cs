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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        public bool is_logout=false;
        private void quanlydocgiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public event EventHandler DangXuat;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangXuat(this,new EventArgs());
            //this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_logout)
            {
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
