using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GenericBillInfo
{
    public partial class BillingData : Form
    {
        public BillingData()
        {
            InitializeComponent();
        }
        public static string cons = SystemSetting.ConnectionString;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        DataTable dt = new DataTable();
        private void BillingData_Load(object sender, EventArgs e)
        {
            string sql = "Select * from Tbl_BillingInformation";
            SqlConnection cons1 = new SqlConnection(cons);
            SqlDataAdapter da = new SqlDataAdapter(sql,cons1);
          
            da.Fill(dt);
            
            dataGridView1.DataSource=dt;
            dataGridView1.Columns["Id"].Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("ShopNameCity like '%{0}%'", txtSearch.Text);
            dataGridView1.DataSource = dv.ToTable();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            BillingInfo g = new BillingInfo();
            g.ShowDialog();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BillingInfo n = new BillingInfo();
            
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            foreach(Control c in n.Controls)
            {
                if (c.Name == "txtShopAndCity")
                {
                    c.Text = row.Cells["ShopNameCity"].Value.ToString();
                }
            }
            txtSearch.Text = row.Cells["ShopNameCity"].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
