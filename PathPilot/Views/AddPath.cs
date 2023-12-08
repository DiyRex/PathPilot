using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PathPilot.Controllers;

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
                WritePath.AddPath(PathManager.allpath + ";" + txtAddPath.Text);
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

        private void AddPath_Load(object sender, EventArgs e)
        {
        }
    }
}
