using System;
using System.Collections.Generic;

#nullable disable

namespace BookmyMovie.Models
{
    public partial class FinalBooking
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int? NoOfTickets { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Meal { get; set; }
        public decimal? TotalFare { get; set; }
        public string UserName { get; set; }
    }
}
