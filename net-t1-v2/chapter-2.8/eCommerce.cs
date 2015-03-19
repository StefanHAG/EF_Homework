using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

[Table("eCommerce", Schema = "Chapter2.8")]
public class eCommerce : Business
{
    public string URL { get; set; }
}
