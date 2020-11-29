using BMS.Admin.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Admin.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();

    }
}
