using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Business", Schema = "Chapter2.8")]
public class Business
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BusinessId { get; protected set; }
    public string Name { get; set; }
    public string LicenceNumber { get; set; }
}