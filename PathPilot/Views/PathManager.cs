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
using PathPilot.Views;

namespace PathPilot
{
    
    public partial class PathManager : Form
    {
        public static string cellValue;
        public static string newcellValue;
        public static string allpath;
        public static string allpath_ad;

        public PathManager()
        {
            InitializeComponent();
            this.Activated += PathManager_Activated;
        }

        private void AddDataToGrid()
        {
            string[] path = ReadPath.ReadValue();
            pathGrid.Rows.Clear();
            pathGrid.AllowUserToAddRows = false;
            allpath = "";
            foreach (string pathItem in path)
            {
                if (pathItem.Length > 0)
                {
                    allpath += pathItem + ";";
                    pathGrid.Rows.Add(pathItem);
                }
            }
        }
        private void PathManager_Load(object sender, EventArgs e)
        {
            AddDataToGrid();
        }

        private void btnAddPathx_Click(object sender, EventArgs e)
        {
            AddPath ap = new AddPath();
            ap.ShowDialog();
            AddDataToGrid();
        }

        private void btnUpdatePathx_Click(object sender, EventArgs e)
        {
            if (pathGrid.SelectedCells.Count > 0)
            {
                int selectedRowIndex = pathGrid.SelectedCells[0].RowIndex;
                string selectedValue = pathGrid.Rows[selectedRowIndex].Cells[0].Value.ToString();
                UpdatePath up = new UpdatePath(selectedValue);
                up.ShowDialog();
                AddDataToGrid();
                pathGrid.FirstDisplayedScrollingRowIndex = selectedRowIndex;
                pathGrid.Rows[selectedRowIndex].Selected = true;
            }
            else
            {
                MessageBox.Show("No row selected", "Information");
            }
        }

        private void btnDeletePathx_Click(object sender, EventArgs e)
        {

            int selectedRowIndex = pathGrid.SelectedCells[0].RowIndex;
            string selectedValue = pathGrid.Rows[selectedRowIndex].Cells[0].Value.ToString();
            DeletePath dp = new DeletePath(selectedValue);
            dp.ShowDialog();
            AddDataToGrid();
        }

        private void bunifuFormCaptionButton1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuFormCaptionButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PathManager_Activated(object sender, EventArgs e)
        {
            AddDataToGrid();
        }
    }
}
