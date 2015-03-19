using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

public class PictureContext : DbContext
{
    public DbSet<PictureCategory> PictureCategories { get; set; }
    public PictureContext()
        : base("name=EF6Recipes5")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PictureCategory>().ToTable("PictureCategory", "Chapter2.5");
        modelBuilder.Entity<PictureCategory>().HasMany(cat => cat.Subcategories)
        .WithOptional(cat => cat.ParentCategory);
    }
}