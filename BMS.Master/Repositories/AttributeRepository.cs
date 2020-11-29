using BMS.Master.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Master.Repositories
{
    public class AttributeRepository : IAttributeRepository
    {
        private readonly MasterContext _masterContext;

        public AttributeRepository(MasterContext masterContext)
        {
            _masterContext = masterContext;
        }

        public async Task<IEnumerable<Entities.Attribute>> GetAttributes()
        {
            return await _masterContext.Attributes.ToListAsync();
        }
    }
}
