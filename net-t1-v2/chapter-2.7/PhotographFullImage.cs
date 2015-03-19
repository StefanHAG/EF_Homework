using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class PhotographFullImage
{
    [Key]
    public int PhotoId { get; set; }
    public byte[] HighResolutionBits { get; set; }

    [ForeignKey("PhotoId")]
    public virtual Photograph Photograph { get; set; }

}