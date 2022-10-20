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

namespace Select
{
    public partial class Form1 : Form
    {
        static string constr2 = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true;";

        SqlConnection connection=new SqlConnection(constr2);
        SqlCommand command = new SqlCommand(constr2);
        string select_employee = "Select * From Employees";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = select_employee;
            try
            {
                connection.Open();
                SqlDataReader rdr = command.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string str = rdr["EmployeeID"] + " " + rdr["FirstName"] + " " + rdr["LastName"] + " " + rdr["City"];
                        lstCalisanlar.Items.Add(str);
                    }
                }

               
            }
            
            

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
