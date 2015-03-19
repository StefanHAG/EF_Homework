using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

public class AccountContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }

    public AccountContext()
        : base("name=EF6Recipes9")
    {
    }
}

