using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiBoxMove
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Top = this.pictureBox1.Top -= 10;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Top = this.pictureBox1.Top += 10;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Left = this.pictureBox1.Left -= 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Left = this.pictureBox1.Left += 10;
        }
    }
}
