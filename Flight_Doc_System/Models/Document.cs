using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;

namespace Flight_Doc_System.Models
{
    [Table("Documents")]
    public class Document
    {
        [Key]
        public string DocumentName { get; set; }

        public string Type { get; set; }

        public string FlightNo { get; set; }

        public DateTime DepartureDate { get; set; }

        public string Creator { get; set; }

        public DateTime UpdatedDate { get; set; }

        
    }
}