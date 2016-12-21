using MetroFramework.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDataSource.View
{
    public partial class TableConfig : MetroForm
    {
        public TableConfig()
        {
            InitializeComponent();
        }

        private void TableConfig_Load(object sender, EventArgs e)
        {
            loadGenMethod();
            loadDataGrid();
        }
        public void loadDataGrid()
        {
            // Define columns
            dgvSelectTable.ColumnCount = 2;
            dgvSelectTable.Columns[0].Name = "Table Name";
            dgvSelectTable.Columns[1].Name = "Edit number of record";
            dgvSelectTable.Columns[0].ReadOnly = true;
            dgvSelectTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add checkbox
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Select";
            chk.Name = "CheckBox";
            chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
            dgvSelectTable.Columns.Add(chk);

            // Dummy data
            ArrayList row= new ArrayList();
            row.Add("Table1");
            row.Add("200");
            dgvSelectTable.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Table2");
            row.Add("300");
            dgvSelectTable.Rows.Add(row.ToArray());

            row = new ArrayList();
            row.Add("Table3");
            row.Add("300");
            dgvSelectTable.Rows.Add(row.ToArray());

            
        }

        private void loadGenMethod()
        {
            cbbGenMethod.Items.Add("Automatic");
            cbbGenMethod.Items.Add("Manual");
            cbbGenMethod.SelectedIndex = 0;
        }
    }
}
