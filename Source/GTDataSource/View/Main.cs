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

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Hide();
            TableConfig tConfig = new TableConfig();
            tConfig.Show();
        }

        private void loadDBType()
        {
            cbbDBType1.Items.Add("PostgreSQL");
            cbbDBType1.Items.Add("MySQL");
            cbbDBType1.Items.Add("SQL Server");
            cbbDBType1.SelectedIndex = 0;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
