using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new ProductContext())
            {
                var product = new Product
                {
                    SKU = 147,
                    Description = "Expandable Hydration Pack",
                    Price = 19.97M,
                    ImageURL = "/pack147.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 178,
                    Description = "Rugged Ranger Duffel Bag",
                    Price = 39.97M,
                    ImageURL = "/pack178.jpg"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 186,
                    Description = "Range Field Pack",
                    Price = 98.97M,
                    ImageURL = "/noimage.jp"
                };
                context.Products.Add(product);
                product = new Product
                {
                    SKU = 202,
                    Description = "Small Deployment Back Pack",
                    Price = 29.97M,
                    ImageURL = "/pack202.jpg"
                };
                context.Products.Add(product);
                context.SaveChanges();
            }

            MessageBox.Show("Data inserted");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (var context = new ProductContext())
            {
                foreach (var p in context.Products)
                {
                    Console.WriteLine("{0} {1} {2} {3}", p.SKU, p.Description,
                    p.Price.ToString("C"), p.ImageURL);

                    dataGridView.Rows.Add();
                    int RowIndex = dataGridView.RowCount - 1;
                    DataGridViewRow row = dataGridView.Rows[RowIndex];

                    row.Cells["SKU"].Value = p.SKU;
                    row.Cells["Description"].Value = p.Description;
                    row.Cells["Price"].Value = p.Price.ToString("C");
                    row.Cells["ImageUrl"].Value = p.ImageURL;

                }
            }
        }
    }
}
