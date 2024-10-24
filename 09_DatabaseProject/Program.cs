using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ado.net

            Console.WriteLine("************* c# ürün-kategory Bilgi Sistemi *********");
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. Kategoriler");
            Console.WriteLine("2. Ürünler");
            Console.WriteLine("3. Siparişler");
            Console.WriteLine("4. Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediginiz tablo numarasını giriniz.");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QDMVQIE\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select * from TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable=new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            connection.Close();
            Console.Read();
        }
    }
}
