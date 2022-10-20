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

namespace Disconnected1
{
    public partial class Form1 : Form
    {
        static string constr2 = @"server=(localdb)\mssqllocaldb;database=northwind;trusted_connection=true;";
        SqlConnection connection = new SqlConnection(constr2);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urunleriYukle();

            
        }

        private void KodlariGetir(string sql)
        {
            using (SqlConnection conn = new SqlConnection(constr2))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void urunleriYukle()
        {
            string sql = "select * from Products p\r\ninner join Categories c on c.CategoryID=p.CategoryID\r\ninner join Suppliers s on s.SupplierID = p.SupplierID";

            using (SqlConnection conn = new SqlConnection(constr2))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView1.DataSource= ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            KodlariGetir("Select * From Customers");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KodlariGetir("Select distinct ProductName \r\nFrom Products");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KodlariGetir("select * from Products p\r\ninner join Categories c on c.CategoryID=p.CategoryID\r\ninner join Suppliers s on s.SupplierID = p.SupplierID");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
