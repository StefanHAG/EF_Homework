using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes4Entities())
            {
                var order = new Order
                {
                    OrderId = 1,
                    OrderDate = new DateTime(2010, 1, 18)
                };
                var item = new Item
                {
                    SKU = 1729,
                    Description = "Backpack",
                    Price = 29.97M
                };
                var oi = new OrderItem { Order = order, Item = item, Count = 1 };
                item = new Item
                {
                    SKU = 2929,
                    Description = "Water Filter",
                    Price = 13.97M
                };
                oi = new OrderItem { Order = order, Item = item, Count = 3 };
                item = new Item
                {
                    SKU = 1847,
                    Description = "Camp Stove",
                    Price = 43.99M
                };
                oi = new OrderItem { Order = order, Item = item, Count = 1 };
                context.Orders.AddObject(order);
                context.SaveChanges();
            }
        }

        private void showData_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes4Entities())
            { 
                foreach (var order in context.Orders)
                {
                    Console.WriteLine("Order # {0}, ordered on {1}",
                    order.OrderId.ToString(),
                    order.OrderDate.ToShortDateString());

                    Console.WriteLine("SKU\tDescription\tQty\tPrice");
                    Console.WriteLine("---\t-----------\t---\t-----");
                    foreach (var oi in order.OrderItems)
                    {
                        dataGridView.Rows.Add();
                        int RowIndex = dataGridView.RowCount - 1;
                        DataGridViewRow row = dataGridView.Rows[RowIndex];

                        row.Cells["OrderNo"].Value = order.OrderId.ToString();
                        row.Cells["Date"].Value = order.OrderDate.ToShortDateString();

                        row.Cells["SKU"].Value = oi.Item.SKU;
                        row.Cells["Description"].Value = oi.Item.Description;
                        row.Cells["Qty"].Value = oi.Count.ToString();
                        row.Cells["Price"].Value = oi.Item.Price.ToString("C");

                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", oi.Item.SKU,
                        oi.Item.Description, oi.Count.ToString(),
                        oi.Item.Price.ToString("C"));
                    }
                }
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
