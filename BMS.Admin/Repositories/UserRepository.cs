using BMS.Admin.Data;
using BMS.Admin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Admin.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AdminContext _adminContext;

        public UserRepository(AdminContext context)
        {
            _adminContext = context;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _adminContext.Users.ToListAsync();
        }
    }
}
