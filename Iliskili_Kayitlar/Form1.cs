using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iliskili_Kayitlar
{
    public partial class Form1 : Form
    {
        static string constr2 = @"server=(localdb)\mssqllocaldb;database=northwind;trusted_connection=true;";
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView2.CurrentRow.Cells[0].Value;
            string sql = "select od.OrderID,p.ProductName,od.UnitPrice,(od.UnitPrice*od.Quantity)as ToplamTutar" +
                " from [Order Details] od\r\ninner join Products p on p.ProductID=od.ProductID where OrderId=" + id.ToString() ;


            GridDoldur(sql, dataGridView3);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[0].Value;
            string sql = "select * from Orders where customerId='" + id.ToString() + "'";

            GridDoldur(sql,dataGridView2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur("select * from customers",dataGridView1);
        }

        private void GridDoldur(string sql,DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(constr2))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];
            }
        }
    }
}
