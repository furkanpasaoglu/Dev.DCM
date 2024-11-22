using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace Dev.DCM.Services.UserDetails
{
    public class UserDetailDto : EntityDto<Guid>
    {
        //Tc Kimlik No
        public string? IdentityNumber { get; set; }

        //Doğum Tarihi
        public DateTime? BirthDate { get; set; }

        //Telefon Numarası
        public string? PhoneNumber { get; set; }

        // IdentityUser Id
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public IdentityUserDto User { get; set; }
    }
}
