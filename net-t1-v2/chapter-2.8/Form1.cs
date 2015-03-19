using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new BusinessContext())
            {
                var business = new Business
                {
                    Name = "Corner Dry Cleaning",
                    LicenceNumber = "100x1"
                };
                context.Businesses.Add(business);
                var retail = new Retail
                {
                    Name = "Shop and Save",
                    LicenceNumber = "200C",
                    Address = "101 Main",
                    City = "Anytown",
                    State = "TX",
                    ZIPCode = "76106"
                };
                context.Businesses.Add(retail);
                var web = new eCommerce
                {
                    Name = "BuyNow.com",
                    LicenceNumber = "300AB",
                    URL = "www.buynow.com"
                };
                context.Businesses.Add(web);
                context.SaveChanges();
            }

            MessageBox.Show("Data inserted!");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (var context = new BusinessContext())
            {
                String str = "";

                Console.WriteLine("\n--- All Businesses ---");
                str += "\n--- All Businesses ---\r\n";
                foreach (var b in context.Businesses)
                {
                    Console.WriteLine("{0} (#{1})", b.Name, b.LicenceNumber);
                    str += b.Name + " (#" + b.LicenceNumber + ")\r\n"; 
                }

                Console.WriteLine("\n--- Retail Businesses ---");
                str += "\r\n--- Retail Businesses ---\r\n";
                foreach (var r in context.Businesses.OfType<Retail>())
                {
                    Console.WriteLine("{0} (#{1})", r.Name, r.LicenceNumber);
                    Console.WriteLine("{0}", r.Address);
                    Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);

                    str += r.Name + " (#" + r.LicenceNumber + ")\r\n"; 
                    str += r.Address + "\r\n";
                    str += r.City + ", " + r.State + ", " + r.ZIPCode + "\r\n";
                }

                Console.WriteLine("\n--- eCommerce Businesses ---");
                str += "\r\n--- eCommerce Businesses ---\r\n";
                foreach (var ee in context.Businesses.OfType<eCommerce>())
                {
                    Console.WriteLine("{0} (#{1})", ee.Name, ee.LicenceNumber);
                    Console.WriteLine("Online address is: {0}", ee.URL);

                    str += ee.Name + " (#" + ee.LicenceNumber + ")\r\n";
                    str += ee.URL + "\r\n";
                }

                textBox.Text = str;
            }
        }
    }
}
