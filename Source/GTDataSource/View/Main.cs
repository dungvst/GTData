using MetroFramework.Forms;
using System;
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
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
            loadDBType();
        }

        private void loadDBType()
        {
            cbbDBType.Items.Add("PostgreSQL");
            cbbDBType.Items.Add("MySQL");
            cbbDBType.Items.Add("SQL Server");
            cbbDBType.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnConnect.Focus();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableConfig tConfig = new TableConfig();
            tConfig.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
