using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMS.Master.Repositories
{
    public interface IAttributeRepository
    {
        Task<IEnumerable<Entities.Attribute>> GetAttributes();
    }
}
