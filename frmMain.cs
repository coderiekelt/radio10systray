using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio10
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Resize += frmMain_Resize;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.trayIcon.Icon = this.Icon;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                trayIcon.Visible = true;
                this.ShowInTaskbar = false;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                this.trayIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            trayIcon.Visible = false;
            this.ShowInTaskbar = true;
        }
    }
}
