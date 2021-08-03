using System;
using System.Collections.Generic;

#nullable disable

namespace GigManagementSystem.Models
{
    public partial class Following
    {
        public string EmailId { get; set; }
        public string ArtistEmailId { get; set; }

        public virtual ArtistRegistration ArtistEmail { get; set; }
        public virtual UserRegistration Email { get; set; }
    }
}
