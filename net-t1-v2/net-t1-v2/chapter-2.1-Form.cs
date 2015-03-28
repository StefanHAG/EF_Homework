using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace net_t1_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            showData();

            base.OnLoad(e);
        }

        int selectedRowIndex;

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

            MessageBox.Show("Data inserted!");
            showData();
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
           
        }

        private void showData()
        {
            using (var context = new EF6RecipesContext())
            {
                dataGridView.Rows.Clear();

                foreach (var person in context.People)
                {
                    dataGridView.Rows.Add();
                    int RowIndex = dataGridView.RowCount - 1;
                    DataGridViewRow row = dataGridView.Rows[RowIndex];

                    row.Cells["Id"].Value = person.Id;
                    row.Cells["FirstName"].Value = person.FirstName;
                    row.Cells["LastName"].Value = person.MiddleName;
                    row.Cells["MiddleName"].Value = person.LastName;
                    row.Cells["PhoneNumber"].Value = person.PhoneNumber;
                    
                }
            }

            updateButton.Enabled = false;
            deleteButton.Enabled = false;

            textBoxFirstName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNo.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" || textBoxMiddleName.Text != "" || textBoxLastName.Text != "" || textBoxPhoneNo.Text != "") 
            {
                using (var context = new EF6RecipesContext())
                {
                    var person = new Person
                    {
                        FirstName = textBoxFirstName.Text,
                        MiddleName = textBoxMiddleName.Text,
                        LastName = textBoxLastName.Text,
                        PhoneNumber = textBoxPhoneNo.Text
                    };
                    context.People.AddObject(person);
                    context.SaveChanges();
                }
            }

            showData();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFirstName.Text = dataGridView.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            textBoxMiddleName.Text = dataGridView.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString();
            textBoxLastName.Text = dataGridView.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            textBoxPhoneNo.Text = dataGridView.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
            selectedRowIndex = e.RowIndex;

            updateButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;

            textBoxFirstName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhoneNo.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" || textBoxMiddleName.Text != "" || textBoxLastName.Text != "" || textBoxPhoneNo.Text != "")
            {
                using (var context = new EF6RecipesContext())
                {
                    var person = new Person
                    {
                        FirstName = textBoxFirstName.Text,
                        MiddleName = textBoxMiddleName.Text,
                        LastName = textBoxLastName.Text,
                        PhoneNumber = textBoxPhoneNo.Text
                    };

                    int id = Int32.Parse(dataGridView.Rows[selectedRowIndex].Cells["Id"].Value.ToString());
                    var resultPerson = context.People.SingleOrDefault(p => p.Id == id);
                    if (resultPerson != null)
                    {
                        resultPerson.FirstName = person.FirstName;
                        resultPerson.MiddleName = person.MiddleName;
                        resultPerson.LastName = person.LastName;
                        resultPerson.PhoneNumber = person.PhoneNumber;
                        context.SaveChanges();
                    }
                }
            }

            showData();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" || textBoxMiddleName.Text != "" || textBoxLastName.Text != "" || textBoxPhoneNo.Text != "")
            {
                using (var context = new EF6RecipesContext())
                {
                    var person = new Person
                    {
                        FirstName = textBoxFirstName.Text,
                        MiddleName = textBoxMiddleName.Text,
                        LastName = textBoxLastName.Text,
                        PhoneNumber = textBoxPhoneNo.Text
                    };

                    int id = Int32.Parse(dataGridView.Rows[selectedRowIndex].Cells["Id"].Value.ToString());
                    var resultPerson = context.People.SingleOrDefault(p => p.Id == id);
                    if (resultPerson != null)
                    {
                        context.People.DeleteObject(resultPerson);
                        context.SaveChanges();
                    }
                }
            }

            showData();
        }

    }
}
