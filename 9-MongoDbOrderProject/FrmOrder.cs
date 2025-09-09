using _9_MongoDbOrderProject.Entities;
using _9_MongoDbOrderProject.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _9_MongoDbOrderProject
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        OrderOperation _orderOperation = new OrderOperation();


        private void btnEkle_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };

            _orderOperation.AddOrder(order);
            MessageBox.Show("Ekleme İşlemi Yapıldı!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<Order> order = _orderOperation.GetAllOrders();
            dgvOrders.DataSource = order;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string orderId = txtOrderId.Text;
            _orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silme İşlemi Yapıldı!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
            var updateOrder = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                OrderId = id,
                TotalPrice = decimal.Parse(txtTotalPrice.Text)
            };
            _orderOperation.UpdateOrder(updateOrder);
            MessageBox.Show("Güncelleme İşlemi Yapıldı!");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text;
            Order order = _orderOperation.GetOrderById(id);
            dgvOrders.DataSource = new List<Order> { order};
        }
    }
}
