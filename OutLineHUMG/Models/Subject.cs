using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OutLineHUMG.Models
{
    [Table("subject")]
    public class Subject
    {
        [Key]
        public int Idsubject { get; set; }
        public string TitleSubject { get; set; }
        public string CodeSubject { get; set; }
        public string ContentSubject { get; set; }
        public string FileSubject { get; set; }
        public byte StatusSubject { get; set; }
        public int Idspecialized { get; set; }
        [ForeignKey("Idspecialized")]
        public Specialized Specialized { get; set;  }
    }
}
