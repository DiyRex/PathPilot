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
    
    public partial class PathManager : Form
    {
        public static string cellValue;
        public static string newcellValue;
        private Size previousSize;
        public PathManager()
        {
            InitializeComponent();
        }


        private void PathManager_Load(object sender, EventArgs e)
        {
            // Get the current value of the PATH variable
            string currentPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            string[] path = currentPath.Split(';');
            pathGrid.Rows.Clear();
            foreach (string pathItem in path)
            {
                pathGrid.Rows.Add(pathItem);
            }
        }

        private void btnAddPathx_Click(object sender, EventArgs e)
        {
            AddPath ap = new AddPath();
            ap.ShowDialog();
            pathGrid.Rows.Add(newcellValue);

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
                pathGrid.Rows[selectedRowIndex].Cells[0].Value = cellValue;



            }
            else
            {
                MessageBox.Show("No row selected", "Information");
            }
        }

        private void btnDeletePathx_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (pathGrid.SelectedRows.Count > 0)
            {
                // Get the index of the selected row
                int selectedIndex = pathGrid.SelectedRows[0].Index;

                // Remove the selected row from the DataGridView
                pathGrid.Rows.RemoveAt(selectedIndex);
                pathGrid.Refresh();
            }
            else
            {
                MessageBox.Show("No row selected", "Information");
            }
        }
    }
}
