using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes12())
            {
                var name1 = new Name { FirstName = "Robin", LastName = "Rosen" };
                var name2 = new Name { FirstName = "Alex", LastName = "St. James" };
                var address1 = new Address { AddressLine1 = "510 N. Grant",
                AddressLine2 = "Apt. 8",
                City = "Raytown", State = "MO",
                ZIPCode = "64133" };
                var address2 = new Address { AddressLine1 = "222 Baker St.",
                AddressLine2 = "Apt.22B",
                City = "Raytown", State = "MO",
                ZIPCode = "64133" };
                context.Agents.AddObject(new Agent { Name = name1, Address = address1 });
                context.Agents.AddObject(new Agent { Name = name2, Address = address2 });
                context.SaveChanges();
            }

            MessageBox.Show("Data inserted!");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes12())
            {
                Console.WriteLine("Agents");
                foreach (var agent in context.Agents)
                {
                    Console.WriteLine("{0} {1}", agent.Name.FirstName, agent.Name.LastName);
                    Console.WriteLine("{0}", agent.Address.AddressLine1);
                    Console.WriteLine("{0}", agent.Address.AddressLine2);
                    Console.WriteLine("{0}, {1} {2}", agent.Address.City,
                    agent.Address.State, agent.Address.ZIPCode);
                    Console.WriteLine();

                    dataGridView.Rows.Add();
                    int RowIndex = dataGridView.RowCount - 1;
                    DataGridViewRow row = dataGridView.Rows[RowIndex];

                    row.Cells["FirstName"].Value = agent.Name.FirstName;
                    row.Cells["LastName"].Value = agent.Name.LastName;
                    row.Cells["AddressLine1"].Value = agent.Address.AddressLine1;
                    row.Cells["AddressLine2"].Value = agent.Address.AddressLine2;
                    row.Cells["City"].Value = agent.Address.City;
                    row.Cells["State"].Value = agent.Address.State;
                    row.Cells["ZIPCode"].Value = agent.Address.ZIPCode;
                }
            }
        }
    }
}
