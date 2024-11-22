using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Dev.DCM.Services.UserDetails
{
    public interface IUserDetailAppService: ICrudAppService<
        UserDetailDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateUserDetailDto>

    {
    }
}
