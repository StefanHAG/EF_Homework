using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using chapter_2._7;


public class PhotographContext : DbContext
{
    public DbSet<Photograph> Photographs { get; set; }
    public DbSet<PhotographFullImage> PhotographFullImages { get; set; }
    public PhotographContext()
        : base("name=EF6Recipes7")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Photograph>()
        .HasRequired(p => p.PhotographFullImage)
        .WithRequiredPrincipal(p => p.Photograph);

        modelBuilder.Entity<Photograph>().ToTable("Photographs", "Chapter2.7");
        modelBuilder.Entity<PhotographFullImage>().ToTable("Photographs", "Chapter2.7");
    }
}
