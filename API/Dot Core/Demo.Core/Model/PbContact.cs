using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Core.Model
{
    public partial class PbContact
    {
        public Guid ContactId { get; set; }
        public Guid MemberId { get; set; }
        public string ContactType { get; set; }
        public string ContactTitle { get; set; }
        public string ContactRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public string IdType { get; set; }
        public string Email { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneMobile { get; set; }
        public string Fax { get; set; }
        public string Skype { get; set; }
        public string Password { get; set; }
    }
}
