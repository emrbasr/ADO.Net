using System;
using System.Data.SqlClient;

namespace BaglantiCumlesi
{
    internal class Program
    {

       static SqlConnection connection; //data base e bağlanır, sql server ile köprü kurar.


        static string constr = @"Server=(localdb)\mssqllocaldb;Database=Northwind;User Id=emre;Password=123;";

        //Windows authentitation için aşşağıdaki yapi kullanılır.
        static string constr2 = @"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true;";

        static void Main(string[] args)
        {
            connection = new SqlConnection(constr2);

            //ağlantıyı açmak için kontrol etmek lazım 

            if (connection.State== System.Data.ConnectionState.Closed)
            {
                connection.Open();
                Console.WriteLine("bağlantı kuruldu");
            }
            else
            {
                Console.WriteLine("bağlantı zaten açık");
            }

        }
    }
}
