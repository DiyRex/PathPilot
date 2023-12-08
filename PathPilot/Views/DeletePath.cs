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

namespace PathPilot.Views
{
    public partial class DeletePath : Form
    {
        private string onLoadValue;
        private string allPath;
        public DeletePath(string path)
        {
            InitializeComponent();
            onLoadValue = path;
        }

        private void btnDeleteY_Click(object sender, EventArgs e)
        {
            if (onLoadValue != null)
            {
                string[] path = ReadPath.ReadValue();
                foreach (string pathItem in path)
                {
                    if (pathItem.Length > 0 && pathItem == onLoadValue)
                    {
                        
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

        private void btnDeleteN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
