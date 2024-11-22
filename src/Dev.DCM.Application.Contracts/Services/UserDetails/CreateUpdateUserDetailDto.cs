using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.DCM.Services.UserDetails
{
    public class CreateUpdateUserDetailDto
    {
        public string? IdentityNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public Guid UserId { get; set; }
    }
}
