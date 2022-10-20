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

namespace Update_Delete
{
    public partial class Form1 : Form
    {
        static string constr2 = @"server=(localdb)\mssqllocaldb;database=northwind;trusted_connection=true;";
        SqlConnection connection = new SqlConnection(constr2);
        SqlCommand command = new SqlCommand();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriDoldur();
        }

        private void KategorileriDoldur()
        {
            string sql = "Select [CategoryName],[Description] from Categories";
            command.Connection= connection;
            command.CommandText= sql;
            command.CommandType=System.Data.CommandType.Text;

            try
            {
                if (connection.State==System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        cmbKategori.Items.Clear();
                        while (reader.Read())
                        {
                            cmbKategori.Items.Add(reader["CategoryName"].ToString());
                        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string updatesql = "Update Categories set CategoryName=@catname Where CategoryName=@name";
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = updatesql;
                command.Parameters.AddWithValue("@name", cmbKategori.SelectedItem.ToString());
                command.Parameters.AddWithValue("@catname", txtKategori.Text);

                connection.Open();
                int etkilenenSayisi = command.ExecuteNonQuery();


                MessageBox.Show(etkilenenSayisi > 0 ? "Guncelleme Basarilidir" : "hata olustu");

                KategorileriDoldur();
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

        private void txtKategori_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKategori.Text = cmbKategori.SelectedItem.ToString(); 
        }
    }
}
