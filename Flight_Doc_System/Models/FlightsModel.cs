using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Flight_Doc_System.Models
{
    public class FlightsModel
    {
        [Table("Flights")]
        public class Flight
        {
            [Key]
            public string FlightNo { get; set; }

            public string Route { get; set; }

            public DateTime DepartureDate { get; set; }

            public int TotalDocument { get; set; }


        }
    }
}