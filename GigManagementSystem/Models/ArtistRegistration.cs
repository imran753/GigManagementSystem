using System;
using System.Collections.Generic;

#nullable disable

namespace GigManagementSystem.Models
{
    public partial class ArtistRegistration
    {
        public ArtistRegistration()
        {
            GigDetails = new HashSet<GigDetail>();
        }

        public string EmailId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
        public string DateofReg { get; set; }
        public string PhoneNo { get; set; }
        public int NoofGigs { get; set; }

        public virtual ICollection<GigDetail> GigDetails { get; set; }
    }
}
