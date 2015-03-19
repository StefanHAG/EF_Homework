using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes2Entities())
            {
                var poet = new Poet { FirstName = "John", LastName = "Milton" };
                var poem = new Poem { Title = "Paradise Lost" };
                var meter = new Meter { MeterName = "Iambic Pentameter" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.AddObject(poem);
                poem = new Poem { Title = "Paradise Regained" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.AddObject(poem);
                poet = new Poet { FirstName = "Lewis", LastName = "Carroll" };
                poem = new Poem { Title = "The Hunting of the Shark" };
                meter = new Meter { MeterName = "Anapestic Tetrameter" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.AddObject(poem);
                poet = new Poet { FirstName = "Lord", LastName = "Byron" };
                poem = new Poem { Title = "Don Juan" };
                poem.Meter = meter;
                poem.Poet = poet;
                context.Poems.AddObject(poem);
                context.SaveChanges();
                
                textBox.Text = "Data inserted!";
            }
        }

        private void showData_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes2Entities())
            {
                var poets = context.Poets;
                String str = "";
                foreach (var poet in poets)
                {
                    Console.WriteLine("{0} {1}", poet.FirstName, poet.LastName);
                    str += poet.FirstName + " " + poet.LastName + "\r\n";
                    foreach (var poem in poet.Poems)
                    {
                        str += "\t" + poem.Title + " " + poem.Meter.MeterName + "\r\n";
                        Console.WriteLine("\t{0} ({1})", poem.Title, poem.Meter.MeterName);
                    }
                }
                textBox.Text = str;
            }
        }

        private void showView_Click(object sender, EventArgs e)
        {
            // using our vwLibrary view
            using (var context = new EF6Recipes2Entities())
            {
                var items = context.vwLibraries;

                String str = "";
                foreach (var item in items)
                {
                    str += item.FirstName + " " + item.LastName + "\r\n";
                    str += "\t" + item.Title + " " + item.MeterName + "\r\n";
                    Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
                    Console.WriteLine("\t{0} ({1})", item.Title, item.MeterName);
                }

                textBox.Text = str;
            }
        }

        
    }
}
