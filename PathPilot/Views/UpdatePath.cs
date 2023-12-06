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
    public partial class UpdatePath : Form
    {
        public UpdatePath(String path)
        {
            InitializeComponent();
            this.txtAddPathU.Text = path;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAddPathU.Text != null)
            {
                PathManager.cellValue = txtAddPathU.Text;
                this.Close();
            }
        }
    }
}
