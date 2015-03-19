using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

public class BusinessContext : DbContext
{
    public DbSet<Business> Businesses { get; set; }

    public BusinessContext()
        : base("name=EF6Recipes8")
    {
    }
}
