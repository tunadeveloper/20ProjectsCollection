using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_KaggleDatasetProject
{
    class Program
    {
        static string connectionString = "Server=TUNA\\SQLEXPRESS;initial catalog=KaggleDatasetDB;integrated security=True;";

        static void Main()
        {
            Console.WriteLine("Hangi dataset'i görüntülemek istersiniz?");
            Console.WriteLine("1 - Netflix Shows");
            Console.WriteLine("2 - Pizza Sales");
            Console.WriteLine("3 - Global Superstore");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowNetflix();
                    break;
                case "2":
                    ShowPizza();
                    break;
                case "3":
                    ShowSuperstore();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }

            Console.WriteLine("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }

        static void ShowNetflix()
        {
            string query = "SELECT TOP 10 title, director, duration FROM netflix_titles ORDER BY release_year DESC";
            PrintData(query);
        }

        static void ShowPizza()
        {
            string query = "SELECT TOP 10 pizza_name, pizza_category, pizza_size FROM pizza_sales ORDER BY total_price DESC";
            PrintData(query);
        }

        static void ShowSuperstore()
        {
            string query = "SELECT TOP 10 Product_Name, Region, Sales FROM superstore ORDER BY Sales DESC";
            PrintData(query);
        }

        static void PrintData(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int columnCount = reader.FieldCount;
                    int[] columnWidths = new int[columnCount];

                    for (int i = 0; i < columnCount; i++)
                    {
                        columnWidths[i] = reader.GetName(i).Length + 2;
                    }

                    List<string[]> rows = new List<string[]>();
                    while (reader.Read())
                    {
                        string[] rowValues = new string[columnCount];
                        for (int i = 0; i < columnCount; i++)
                        {
                            rowValues[i] = reader[i].ToString();
                            if (rowValues[i].Length + 2 > columnWidths[i])
                                columnWidths[i] = rowValues[i].Length + 2;
                        }
                        rows.Add(rowValues);
                    }

                    for (int i = 0; i < columnCount; i++)
                    {
                        Console.Write(reader.GetName(i).PadRight(columnWidths[i]));
                        if (i < columnCount - 1) Console.Write("| ");
                    }
                    Console.WriteLine();

                    for (int i = 0; i < columnWidths.Sum() + (3 * (columnCount - 1)); i++)
                        Console.Write("-");
                    Console.WriteLine();

                    foreach (var row in rows)
                    {
                        for (int i = 0; i < columnCount; i++)
                        {
                            Console.Write(row[i].PadRight(columnWidths[i]));
                            if (i < columnCount - 1) Console.Write("| ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

    }
}
