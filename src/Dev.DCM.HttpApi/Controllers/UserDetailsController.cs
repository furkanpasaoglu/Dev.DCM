using Asp.Versioning;
using Dev.DCM.Services.Cities;
using Dev.DCM.Services.UserDetails;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Dev.DCM.Controllers
{
    [RemoteService]
    [Area("app")]
    [ControllerName("UserDetails")]
    [Route("api/app/user-details")]
    public class UserDetailsController(IUserDetailAppService userDetailAppService) : DCMController
    {
        [HttpGet]
        [ProducesResponseType(typeof(PagedResultDto<UserDetailDto>), 200)]
        public async Task<PagedResultDto<UserDetailDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await userDetailAppService.GetListAsync(input);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [ProducesResponseType(typeof(UserDetailDto), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public async Task<UserDetailDto> GetAsync(Guid id)
        {
            return await userDetailAppService.GetAsync(id);
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserDetailDto), 201)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public async Task<UserDetailDto> CreateAsync(CreateUpdateUserDetailDto input)
        {
            return await userDetailAppService.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [ProducesResponseType(typeof(UserDetailDto), 200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public async Task<UserDetailDto> UpdateAsync(Guid id, CreateUpdateUserDetailDto input)
        {
            return await userDetailAppService.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(ProblemDetails), 400)]
        public async Task DeleteAsync(Guid id)
        {
            await userDetailAppService.DeleteAsync(id);
        }
    }
}