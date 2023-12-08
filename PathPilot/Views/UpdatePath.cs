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
    public partial class UpdatePath : Form
    {
        private string onLoadValue;
        private string allPath;
        public UpdatePath(String path)
        {
            InitializeComponent();
            this.txtAddPathU.Text = path;
            onLoadValue = path;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddPathU.Text != null)
            {
                string[] path = ReadPath.ReadValue();
                foreach (string pathItem in path)
                {
                    if (pathItem.Length > 0 && pathItem == onLoadValue)
                    {
                        allPath += txtAddPathU.Text + ";";
                    }
                    else
                    {
                        allPath += pathItem + ";";
                    }
                }
                WritePath.AddPath(allPath);
                this.Close();
            }
        }

        private void UpdatePath_Load(object sender, EventArgs e)
        {
            //onLoadValue = txtAddPathU.Text;
        }

        private void btnAddFolderU_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtAddPathU.Text = dialog.SelectedPath;
            }
        }
    }
}
