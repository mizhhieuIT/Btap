using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OutLineHUMG.Models
{
    [Table("specialized")]
    public class Specialized
    {
        [Key]
        public int Idspecialized { get; set; }
        public string Titlespecialized { get; set; }
        public string CodeSpecialized { get; set; }
        public string Contentspecialized { get; set; }
        public string CourseofYear { get; set; }
        public byte Statusspecialized { get; set; }
    }
}
