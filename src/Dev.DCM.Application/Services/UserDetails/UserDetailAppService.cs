using Dev.DCM.Entities.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Dev.DCM.Services.UserDetails
{
    public class UserDetailAppService(IRepository<UserDetail, Guid> repository)
        : CrudAppService<
                UserDetail,
                UserDetailDto,
                Guid,
                PagedAndSortedResultRequestDto,
                CreateUpdateUserDetailDto>(repository),
            IUserDetailAppService
    {
        protected override string? GetPolicyName { get; set; } = Permissions.DCMPermissions.UserDetails.Default;
        protected override string? GetListPolicyName { get; set; } = Permissions.DCMPermissions.UserDetails.Default;
        protected override string? CreatePolicyName { get; set; } = Permissions.DCMPermissions.UserDetails.Create;
        protected override string? UpdatePolicyName { get; set; } = Permissions.DCMPermissions.UserDetails.Edit;
        protected override string? DeletePolicyName { get; set; } = Permissions.DCMPermissions.UserDetails.Delete;

        public override async Task<PagedResultDto<UserDetailDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var queryable = await Repository.WithDetailsAsync(c => c.User);
            var totalCount = await AsyncExecuter.CountAsync(queryable);
            var items = await AsyncExecuter.ToListAsync(
                queryable.PageBy(input)
                    .OrderBy(c => c.PhoneNumber)
            );

            return new PagedResultDto<UserDetailDto>(
                totalCount,
                ObjectMapper.Map<List<UserDetail>, List<UserDetailDto>>(items)
            );
        }


    }
}
