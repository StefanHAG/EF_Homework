using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeContext())
            {
                var fte = new FullTimeEmployee
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Salary = 71500M
                };
                context.Employees.Add(fte);
                fte = new FullTimeEmployee
                {
                    FirstName = "John",
                    LastName = "Smith",
                    Salary =62500M
                };
                context.Employees.Add(fte);
                var hourly = new HourlyEmployee
                {
                    FirstName = "Tom",
                    LastName = "Jones",
                    Wage = 8.75M
                };
                context.Employees.Add(hourly);
                context.SaveChanges();

                MessageBox.Show("Data insert!");
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            using (var context = new EmployeeContext())
            {
                String str = "";
                //Console.WriteLine("--- All Employees ---");
                str += "--- All Employees ---\r\n";

                foreach (var emp in context.Employees)
                {
                    bool fullTime = emp is HourlyEmployee ? false : true;
                    
                    //Console.WriteLine("{0} {1} ({2})", emp.FirstName, emp.LastName,
                    //fullTime ? "Full Time" : "Hourly");
                    str += emp.FirstName + " " + emp.LastName + " (" + (fullTime ? "Full Time" : "Hourly") + ")\r\n";
                }
                //Console.WriteLine("--- Full Time ---");
                str += "--- Full Time ---\r\n";

                foreach (var fte in context.Employees.OfType<FullTimeEmployee>())
                {
                    //Console.WriteLine("{0} {1}", fte.FirstName, fte.LastName);
                    str += fte.FirstName + " " + fte.LastName + "-" + fte.Salary + "\r\n";
                }
                //Console.WriteLine("--- Hourly ---");
                str += "--- Hourly ---\r\n";

                foreach (var hourly in context.Employees.OfType<HourlyEmployee>())
                {
                    //Console.WriteLine("{0} {1}", hourly.FirstName, hourly.LastName);
                    str += hourly.FirstName + " " + hourly.LastName + "-" + hourly.Wage +"\r\n";
                }

                textBox.Text = str;
            }
        }
    }
}
