using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace net_t1_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6RecipesContext())
            {
                var person = new Person
                {
                    FirstName = "Robert",
                    MiddleName = "Allen",
                    LastName = "Doe",
                    PhoneNumber = "867-5309"
                };
                context.People.AddObject(person);
                person = new Person
                {
                    FirstName = "John",
                    MiddleName = "K.",
                    LastName = "Smith",
                    PhoneNumber = "824-3031"
                };
                context.People.AddObject(person);
                person = new Person
                {
                    FirstName = "Billy",
                    MiddleName = "Albert",
                    LastName = "Minor",
                    PhoneNumber = "907-2212"
                };
                context.People.AddObject(person);
                person = new Person
                {
                    FirstName = "Kathy",
                    MiddleName = "Anne",
                    LastName = "Ryan",
                    PhoneNumber = "722-0038"
                };
                context.People.AddObject(person);
                context.SaveChanges();
            }

            queryResultTextBox.Text = "Data inserted";
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            using (var context = new EF6RecipesContext())
            {
                string text = "";
                foreach (var person in context.People)
                {
                    text += person.FirstName + " " + person.MiddleName + " " +
                    person.LastName + ", Phone: " + person.PhoneNumber + "\r\n";
                }
                queryResultTextBox.Text = text;
            }
        }
    }
}
