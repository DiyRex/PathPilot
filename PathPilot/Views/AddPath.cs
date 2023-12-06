using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathPilot
{
    public partial class AddPath : Form
    {
        public AddPath()
        {
            InitializeComponent();
        }

        private void btnUpdateA_Click(object sender, EventArgs e)
        {
            if (txtAddPath.Text != null)
            {
                PathManager.newcellValue = txtAddPath.Text;
                this.Close();
            }
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtAddPath.Text = dialog.SelectedPath;
            }
        }
    }
}
