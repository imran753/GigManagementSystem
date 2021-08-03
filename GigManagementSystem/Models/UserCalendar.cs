using System;
using System.Collections.Generic;

#nullable disable

namespace GigManagementSystem.Models
{
    public partial class UserCalendar
    {
        public string ClId { get; set; }
        public string EmailId { get; set; }
        public DateTime Day { get; set; }
        public DateTime Month { get; set; }
        public DateTime Year { get; set; }
        public TimeSpan Time { get; set; }
        public string Venue { get; set; }
        public string Location { get; set; }

        public virtual UserRegistration Email { get; set; }
    }
}
