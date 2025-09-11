using _11_SQLTriggerOrderProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SQLTriggerOrderProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLTriggerProjectEntities context = new SQLTriggerProjectEntities();
            int number;
            Console.WriteLine("### SİPARİŞ STOK SİSTEMİ ###");
            Console.WriteLine();
            Console.WriteLine("1-Ürün Listesi");
            Console.WriteLine("2-Sipariş Listesi");
            Console.WriteLine("3-Kasa Durumu");
            Console.WriteLine("4-Yeni Ürün Satışı");
            Console.WriteLine("5-İşlem Sayacı");
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.Write("Yapmak İstediğiniz İşlemi Seçin: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (number)
            {
                case 1:
                    Console.WriteLine("# ÜRÜN LİSTESİ #");
                    var products = context.Products.ToList();
                    foreach (var item in products)
                    {
                        Console.WriteLine(item.ProductId + " - " + item.ProductName + " Stok Sayısı: " + item.ProductStock + " Fiyat: " + item.ProductPrice + " TL");
                    }
                    break;

                case 2:
                    Console.WriteLine("# SİPARİŞ LİSTESİ #");
                    var orders = context.Orders.ToList();
                    foreach (var item in orders)
                    {
                        Console.WriteLine(item.OrderId + " - " + item.Products.ProductName + " Birim Fiyat: " + item.UnitPrice + " Adet: " + item.Quantity + " Toplam Fiyat: " + item.TotalPrice);

                    }
                    break;

                case 3:
                    Console.WriteLine("# KASA DURUMU #");
                    var cashRegisters = context.CashRegister.Select(x=>x.Balance).FirstOrDefault();
                    Console.Write("Kasada ki toplam tutar: " + cashRegisters + " TL");
                    break;

                case 4:
                    Console.WriteLine("# YENİ SİPARİŞ OLUŞTUR #");
                    Console.Write("Müşteri Adı: ");
                    string customer = Console.ReadLine();

                    Console.Write("Ürün ID: ");
                    int productId = int.Parse(Console.ReadLine());

                    Console.Write("ürün Adedi: ");
                    int quantity = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("# ÜRÜN BİLGİLERİ #");
                    Console.WriteLine();

                    var productname = context.Products.Where(x=>x.ProductId == productId).Select(z=>z.ProductName).FirstOrDefault();
                    Console.WriteLine("Ürün Adı: " + productname);

                    var productUnitPrice = context.Products.Where(x => x.ProductId == productId).Select(z=>z.ProductPrice).FirstOrDefault();

                    Console.WriteLine("Birim Fiyat: " + productUnitPrice);
                  
                    decimal totalPrice = quantity * decimal.Parse( productUnitPrice.ToString());
                    Console.WriteLine("Toplam Fiyat: " + totalPrice);

                    Orders tblOrders = new Orders();
                    tblOrders.UnitPrice = productUnitPrice;
                    tblOrders.Quantity = quantity;
                    tblOrders.TotalPrice = totalPrice;
                    tblOrders.Customer = customer;
                    tblOrders.ProductId = productId;

                    context.Orders.Add(tblOrders);
                    context.SaveChanges();

                    break;

                    case 5:
                    var value = context.Process.Select(x => x.ProcessId).FirstOrDefault();
                    Console.WriteLine("Toplam İşlem Sayısı: " + value);
                    break;
            }
            Console.Read();
        }
    }
}
