using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmailClient
{
    public partial class frmAddAttachment : Form
    {
        public frmAddAttachment()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
            txtFile.Text = dlg.FileName;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFile.Text = "";
            this.Hide();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
