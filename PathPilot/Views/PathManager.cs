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
            // Get the current value of the PATH variable
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
            
            foreach (DataGridViewRow row in pathGrid.Rows)
            {
                // Skip the last row if it is the new row for data entry
                if (!row.IsNewRow)
                {
                    // Assuming you have only one column, change the index accordingly
                    string line = row.Cells[0].Value.ToString();
                    //allpath += line + ";";
                }
            }
            AddPath ap = new AddPath();
            ap.ShowDialog();
            AddDataToGrid();
            //pathGrid.Rows.Add(newcellValue);
            //WritePath.AddPath(allpath);

        }

        private void btnUpdatePathx_Click(object sender, EventArgs e)
        {
            if (pathGrid.SelectedCells.Count > 0)
            {
                // Assuming the column index is 0 (Column1 in this example)
                int selectedRowIndex = pathGrid.SelectedCells[0].RowIndex;

                // Assuming the column index is 0 (Column1 in this example)
                string selectedValue = pathGrid.Rows[selectedRowIndex].Cells[0].Value.ToString();
                UpdatePath up = new UpdatePath(selectedValue);
                up.ShowDialog();
                //pathGrid.Rows[selectedRowIndex].Cells[0].Value = cellValue;
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
            // Check if any row is selected
            //if (pathGrid.SelectedRows.Count > 0)
            //{

            //     Assuming the column index is 0 (Column1 in this example)
            //    int selectedRowIndex = pathGrid.SelectedCells[0].RowIndex;

            //     Assuming the column index is 0 (Column1 in this example)
            //    string selectedValue = pathGrid.Rows[selectedRowIndex].Cells[0].Value.ToString();
            //    allpath_ad = "";
            //    string[] path = ReadPath.ReadValue();
            //    foreach (string pathItem in path)
            //    {
            //        if (pathItem.Length > 0 && pathItem == pathGrid.Rows[selectedRowIndex].Cells[0].Value.ToString())
            //        {

            //        }
            //        else
            //        {
            //            allpath_ad += pathItem + ";";
            //        }
            //    }
            //    WritePath.AddPath(allpath_ad);
            //     Remove the selected row from the DataGridView
            //    pathGrid.Rows.RemoveAt(selectedRowIndex);
                

            //    pathGrid.Refresh();
            //}
            //else
            //{
            //    MessageBox.Show("No row selected", "Information");
            //}

            // Assuming the column index is 0 (Column1 in this example)
            int selectedRowIndex = pathGrid.SelectedCells[0].RowIndex;

            // Assuming the column index is 0 (Column1 in this example)
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
