using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_EntityFrameworkStatisticsProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        DbStatisticsEntities db = new DbStatisticsEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            // Toplam Veri Sayıları
            lblStats1Value.Text = db.Category.Count().ToString();
            lblStats2Value.Text = db.Product.Count().ToString();
            lblStats3Value.Text = db.Customer.Count().ToString();
            lblStats4Value.Text = db.Order.Count().ToString();

            // Toplam Stok Sayısı
            lblStats5Value.Text = "₺" + db.Product.Sum(x => x.ProductStock).ToString();

            //Ortalama Ürün Fiyatı
            var avgPrice = db.Product.Average(x => (decimal?)x.ProductPrice) ?? 0;
            lblStats6Value.Text = "₺" + avgPrice.ToString("0.00");

            // En Pahalı Ürün Fiyatı
            lblStats7Value.Text = "₺" + db.Product.Max(x => x.ProductPrice).ToString();

            // En Ucuz Ürün Fiyatı
            lblStats8Value.Text = "₺" + db.Product.Min(x => x.ProductPrice).ToString();

            // En Fazla Stoklu Ürün Adı
            lblStats9Value.Text = db.Product
                .OrderByDescending(x => x.ProductStock)
                .Select(x => x.ProductName)
                .FirstOrDefault();

            // En Az Stoklu Ürün Adı
            lblStats10Value.Text = db.Product
                .OrderBy(x => x.ProductStock)
                .Select(x => x.ProductName)
                .FirstOrDefault();

            // Farklı Ülke Sayısı
            lblStats11Value.Text = db.Customer
                .Select(x => x.CustomerCountry)
                .Distinct()
                .Count()
                .ToString();

            // Farklı Şehir Sayısı
            lblStats12Value.Text = db.Customer
                .Select(x => x.CustomerCity)
                .Distinct()
                .Count()
                .ToString();

            // Toplam Satış Tutarı
            lblStats13Value.Text = "₺" + db.Order.Sum(x => x.TotalPrice).ToString();

            // Ortalama Sipariş Tutarı
            var avgOrderPrice = db.Order.Average(x => (decimal?)x.TotalPrice) ?? 0;
            lblStats14Value.Text = "₺" + avgOrderPrice.ToString("0.00");

            // En Pahalı Sipariş Tutarı
            lblStats15Value.Text = "₺" + db.Order.Max(x => x.TotalPrice).ToString();

            // En Çok Sipariş Veren Müşteri Adı
            lblStats16Value.Text = db.Order
                .GroupBy(x => x.CustomerId)
                .OrderByDescending(g => g.Count())
                .Select(g => db.Customer
                    .Where(c => c.CustomerId == g.Key)
                    .Select(c => c.CustomerName)
                    .FirstOrDefault())
                .FirstOrDefault();

            // En Çok Ürünlü Kategori
            lblStats17Value.Text = db.Product
                .GroupBy(x => x.CategoryId)
                .OrderByDescending(g => g.Count())
                .Select(g => db.Category
                    .Where(c => c.CategoryId == g.Key)
                    .Select(c => c.CategoryName)
                    .FirstOrDefault())
                .FirstOrDefault();

            // En Çok Satış Yapılan Ürün Adı
            lblStats18Value.Text = db.Order
                .GroupBy(x => x.ProductId)
                .OrderByDescending(g => g.Sum(o => o.Count))
                .Select(g => db.Product
                    .Where(p => p.ProductId == g.Key)
                    .Select(p => p.ProductName)
                    .FirstOrDefault())
                .FirstOrDefault();

            // En Çok Kazanç Sağlayan Ürün Adı
            lblStats19Value.Text = db.Order
                .GroupBy(x => x.ProductId)
                .OrderByDescending(g => g.Sum(o => o.TotalPrice))
                .Select(g => db.Product
                    .Where(p => p.ProductId == g.Key)
                    .Select(p => p.ProductName)
                    .FirstOrDefault())
                .FirstOrDefault();

            // En Fazla Harcama Yapan Müşteri Adı
            lblStats20Value.Text = db.Order
                .GroupBy(x => x.CustomerId)
                .OrderByDescending(g => g.Sum(o => o.TotalPrice))
                .Select(g => db.Customer
                    .Where(c => c.CustomerId == g.Key)
                    .Select(c => c.CustomerName)
                    .FirstOrDefault())
                .FirstOrDefault();
        }
    }
}
