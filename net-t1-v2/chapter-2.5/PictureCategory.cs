using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class PictureCategory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CategoryId { get; private set; }
    public string Name { get; set; }
    public int? ParentCategoryId { get; private set; }
    public List<PictureCategory> Subcategories { get; set; }

    [ForeignKey("ParentCategoryId")]
    public PictureCategory ParentCategory { get; set; }


    public PictureCategory()
    {
        Subcategories = new List<PictureCategory>();
    }
}