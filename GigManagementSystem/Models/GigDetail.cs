using System;
using System.Collections.Generic;

#nullable disable

namespace GigManagementSystem.Models
{
    public partial class GigDetail
    {
        public int GigId { get; set; }
        public string EmailId { get; set; }
        public string GigName { get; set; }
        public string Genre { get; set; }
        public string Venue { get; set; }
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public string IsCancelled { get; set; }

        public virtual ArtistRegistration Email { get; set; }
    }
}
