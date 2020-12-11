using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Standard")]
    public class Standard
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
