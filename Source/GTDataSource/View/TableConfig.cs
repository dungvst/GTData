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
            init();
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

            //////////////

            // Define columns
            dgvManual.ColumnCount = 6;
            dgvManual.Columns[0].Name = "Table 1";
            dgvManual.Columns[1].Name = "Table 2";
            dgvManual.Columns[2].Name = "Relation";
            dgvManual.Columns[3].Name = "Record";
            dgvManual.Columns[4].Name = "Gid";
            dgvManual.Columns[5].Name = "Overwrite";
            dgvManual.Columns[0].ReadOnly = true;
            dgvManual.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Add checkbox
            chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Select";
            chk.Name = "CheckBox";
            chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgvManual.Columns.Add(chk);

            // Dummy data
            row = new ArrayList();
            row.Add("Table1");
            row.Add("Table2");
            row.Add("1:n");
            row.Add("300");
            row.Add("1234");
            row.Add("Yes");
            dgvManual.Rows.Add(row.ToArray());

            //row = new ArrayList();
            //row.Add("Table2");
            //row.Add("300");
            //dgvManual.Rows.Add(row.ToArray());

            //row = new ArrayList();
            //row.Add("Table3");
            //row.Add("300");
            //dgvManual.Rows.Add(row.ToArray());
        }

        private void init()
        {
            cbbGenMethod.Items.Add("Automatic");
            cbbGenMethod.Items.Add("Manual");
            cbbGenMethod.SelectedIndex = 0;

            cbbOutputType.Items.Add("Insert into DB");
            cbbOutputType.Items.Add("Excel file");
            cbbOutputType.Items.Add("SQL file");
            cbbOutputType.SelectedIndex = 0;

            cbbReset.Items.Add("Default");
            cbbReset.Items.Add("Clear all");
            cbbReset.SelectedIndex = 0;
        }

        private void TableConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void cbbGenMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbbGenMethod.Text == "Manual")
            {
                dgvSelectTable.Hide();
                dgvManual.Show();
            }
            else
            {
                dgvSelectTable.Show();
                dgvManual.Hide();
            }
        } 
    }
}
