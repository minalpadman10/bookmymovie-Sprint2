using System;
using System.Collections.Generic;

#nullable disable

namespace BookmyMovie.Models
{
    public partial class MyBooking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MovieName { get; set; }
        public string EmailId { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string Meal { get; set; }
        public int? NoOfTickets { get; set; }
    }
}
