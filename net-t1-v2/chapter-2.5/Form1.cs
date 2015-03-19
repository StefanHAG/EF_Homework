using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static String sb = "";

        private void runExample_Click(object sender, EventArgs e)
        {
            RunExample();

            textBox.Text += sb;
        }

        void RunExample()
        {
            using (var context = new PictureContext())
            {
                var louvre = new PictureCategory { Name = "Louvre" };
                var child = new PictureCategory { Name = "Egyptian Antiquites" };
                louvre.Subcategories.Add(child);
                child = new PictureCategory { Name = "Sculptures" };
                louvre.Subcategories.Add(child);
                child = new PictureCategory { Name = "Paintings" };
                louvre.Subcategories.Add(child);
                var paris = new PictureCategory { Name = "Paris" };
                paris.Subcategories.Add(louvre);
                var vacation = new PictureCategory { Name = "Summer Vacation" };
                vacation.Subcategories.Add(paris);
                context.PictureCategories.Add(vacation);
                context.SaveChanges();
            }
            using (var context = new PictureContext())
            {
                var roots = context.PictureCategories.Where(c => c.ParentCategory == null);
                // roots.ForEach(root => Print(root, 0));
                foreach (PictureCategory root in roots)
                {
                    Print(root, 0);
                }
            }
        }
        void Print(PictureCategory cat, int level)
        {
            // Console.WriteLine("{0}{1}", sb.Append(' ', level).ToString(), cat.Name);
            // sb.Append(' ', level).ToString();
            for (int i = 0; i < level; i++)
            {
                sb += "\t";
            }
            sb += cat.Name + "\r\n";

            cat.Subcategories.ForEach(child => Print(child, level + 1));
        }
    }
}
