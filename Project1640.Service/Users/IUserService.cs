using Project1640.Dto.Common;
using Project1640.Dto.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1640.Service.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Login(LoginDto request);
    }
}
