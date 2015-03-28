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

        int poemid;

        protected override void OnLoad(EventArgs e)
        {
            showPoems();

            base.OnLoad(e);
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxFirstName.Text = dataGridView.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            textBoxMiddleName.Text = (dataGridView.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString() != null) ? (dataGridView.Rows[e.RowIndex].Cells["MiddleName"].Value.ToString()) : ("");
            textBoxLastName.Text = dataGridView.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            textBoxMeter.Text = dataGridView.Rows[e.RowIndex].Cells["Meter"].Value.ToString();
            textBoxTitle.Text = dataGridView.Rows[e.RowIndex].Cells["Title"].Value.ToString();

            poemid = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            updateButton.Enabled = true;
            deleteButton.Enabled = true;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" || textBoxTitle.Text != "" || textBoxLastName.Text != "" || textBoxMeter.Text != "")
            {
                using (var context = new EF6Recipes2Entities())
                {
                    var poem = new Poem
                    {
                        Title = textBoxTitle.Text
                    };

                    //poem.Poet = searchPoet(textBoxFirstName.Text, textBoxMiddleName.Text, textBoxLastName.Text);
                    //poem.Meter = searchMeter(textBoxMeter.Text);

                    //search for poet
                    var poet = context.Poets.SingleOrDefault(b => b.FirstName == textBoxFirstName.Text
                        && b.MiddleName == textBoxMiddleName.Text && b.LastName == textBoxLastName.Text);
                    if (poet == null)
                    {
                        poet = new Poet
                        {
                            FirstName = textBoxFirstName.Text,
                            MiddleName = textBoxMiddleName.Text,
                            LastName = textBoxLastName.Text
                        };
                    }

                    //search for meter
                    var meter = context.Meters.SingleOrDefault(b => b.MeterName == textBoxMeter.Text);
                    if (meter == null)
                    {
                        meter = new Meter
                        {
                            MeterName = textBoxMeter.Text
                        };
                    }

                    poem.Poet = poet;
                    poem.Meter = meter;
                    //context.Attach(poem);
                    context.Poems.AddObject(poem);
                    context.SaveChanges();
                }
            }
            else 
            {
                MessageBox.Show("Next fileds cannot be empty: Title, Meter, First Name and Last Name!");
            }

            showPoems();
        }

        private Poet searchPoet(String firstName, String middleName, String lastName)
        {
            using (var context = new EF6Recipes2Entities())
            {
                var poet = context.Poets.SingleOrDefault(b => b.FirstName == firstName && b.MiddleName == middleName && b.LastName == lastName);
                if (poet != null)
                {
                    return poet;
                }
                else
                {
                    return new Poet
                    {
                        FirstName = textBoxFirstName.Text,
                        MiddleName = textBoxMiddleName.Text,
                        LastName = textBoxLastName.Text
                    };
                }
            }
        }

        private Meter searchMeter(String meterName)
        {
            using (var context = new EF6Recipes2Entities())
            {
                var meter = context.Meters.SingleOrDefault(b => b.MeterName == meterName);
                if (meter != null)
                {
                    return meter;
                }
                else
                {
                    return new Meter
                    {
                        MeterName = meterName
                    };
                }
            }
        }

        private void showPoems()
        {
            using (var context = new EF6Recipes2Entities())
            {
                dataGridView.Rows.Clear();

                foreach (var poem in context.Poems)
                {
                    dataGridView.Rows.Add();
                    int RowIndex = dataGridView.RowCount - 1;
                    DataGridViewRow row = dataGridView.Rows[RowIndex];

                    row.Cells["Id"].Value = poem.PoemId;
                    row.Cells["FirstName"].Value = poem.Poet.FirstName;
                    row.Cells["LastName"].Value = poem.Poet.LastName;
                    row.Cells["MiddleName"].Value = poem.Poet.MiddleName != null ? poem.Poet.MiddleName : "";
                    row.Cells["Title"].Value = poem.Title;
                    row.Cells["Meter"].Value = poem.Meter.MeterName;

                }
            }

            updateButton.Enabled = false;
            deleteButton.Enabled = false;

            textBoxFirstName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxLastName.Text = "";
            textBoxMeter.Text = "";
            textBoxTitle.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = false;
            deleteButton.Enabled = false;

            textBoxFirstName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxLastName.Text = "";
            textBoxMeter.Text = "";
            textBoxTitle.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
