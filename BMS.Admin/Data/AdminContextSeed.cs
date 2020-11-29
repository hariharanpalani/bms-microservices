using BMS.Admin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Admin.Data
{
    public class AdminContextSeed
    {
        public static async Task SeedAsync(AdminContext context)
        {
            context.Users.AddRange(new User
            {
                Id = 1,
                FirstName = "Firstname 1",
                LastName = "Lastname 1",
                Username = "user1",
                Role = "Administrator"
            },
                new User
                {
                    Id = 2,
                    FirstName = "Firstname 2",
                    LastName = "Lastname 2",
                    Username = "user2",
                    Role = "Super Admin"
                },
                new User
                {
                    Id = 3,
                    FirstName = "Firstname 3",
                    LastName = "Lastname 3",
                    Username = "user3",
                    Role = "Project Manager"
                },
                new User
                {
                    Id = 4,
                    FirstName = "Firstname 4",
                    LastName = "Lastname 4",
                    Username = "user4",
                    Role = "Project Viewer"
                },
                new User
                {
                    Id = 5,
                    FirstName = "Firstname 5",
                    LastName = "Lastname 5",
                    Username = "user5",
                    Role = "Project Approver"
                });

            await context.SaveChangesAsync();
        }
    }
}
