using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Master.Data
{
    public class MasterContextSeed
    {
        public static async Task SeedAsync(MasterContext context)
        {
            context.Attributes.AddRange(new Entities.Attribute
            {
                Id = 1,
                Name = "Quantity",
                ControlType = "Number"
            },
                new Entities.Attribute
                {
                    Id = 2,
                    Name = "Manufacturer",
                    ControlType = "MultiSelect"
                },
                new Entities.Attribute
                {
                    Id = 3,
                    Name = "IsLuxury",
                    ControlType = "CheckBox"
                });

            await context.SaveChangesAsync();
        }
    }
}
