using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter2._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes11())
            {
                var park = new Park
                {
                    Name = "11th Street Park",
                    Address = "801 11th Street",
                    City = "Aledo",
                    State = "TX",
                    ZIPCode = "76106"
                };
                var loc = new Location
                {
                    Address = "501 Main",
                    City = "Weatherford",
                    State = "TX",
                    ZIPCode = "76201"
                };
                park.Office = loc;
                context.Locations.AddObject(park);
                park = new Park
                {
                    Name = "Overland Park",
                    Address = "101 High Drive",
                    City = "Springtown",
                    State = "TX",
                    ZIPCode = "76081"
                };
                loc = new Location
                {
                    Address = "8705 Range Lane",
                    City = "Springtown",
                    State = "TX",
                    ZIPCode = "76081"
                };
                park.Office = loc;
                context.Locations.AddObject(park);
                context.SaveChanges();
            }

            MessageBox.Show("Data inserted!");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes11())
            {
                String str = "";
                context.ContextOptions.LazyLoadingEnabled = true;
                Console.WriteLine("-- All Locations -- ");
                str += "-- All Locations --\r\n";
                foreach (var l in context.Locations)
                {
                    Console.WriteLine("{0}, {1}, {2} {3}", l.Address, l.City,
                    l.State, l.ZIPCode);
                    str += l.Address + ", " + l.City + ", " + l.State + " " + l.ZIPCode + "\r\n";
                }
                Console.WriteLine("--- Parks ---");
                str += "--- Parks ---\r\n";
                foreach (var p in context.Locations.OfType<Park>())
                {
                    Console.WriteLine("{0} is at {1} in {2}", p.Name, p.Address, p.City);
                    str +=  p.Name + " is at " + p.Address + " in " + p.City + "\r\n";
                    Console.WriteLine("\tOffice: {0}, {1}, {2} {3}", p.Office.Address,
                    p.Office.City, p.Office.State, p.Office.ZIPCode);
                    str += "\tOffice: " + p.Office.Address + ", " + p.Office.City + " " + p.Office.State + " " + p.Office.ZIPCode + "\r\n";
                }

                textBox.Text = str;
            }
        }
    }
}
