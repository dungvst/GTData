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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            loadDBType();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableConfig tConfig = new TableConfig();
            tConfig.Show();
        }

        private void loadDBType()
        {
            cbbDBType.Items.Add("PostgreSQL");
            cbbDBType.Items.Add("MySQL");
            cbbDBType.Items.Add("SQL Server");
            cbbDBType.SelectedIndex = 0;
        }
    }
}
