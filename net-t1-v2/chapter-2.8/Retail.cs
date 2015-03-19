using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Retail", Schema = "Chapter2.8")]
public class Retail : Business
{
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZIPCode { get; set; }
}
