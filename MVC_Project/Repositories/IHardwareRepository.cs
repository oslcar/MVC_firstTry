using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Repositories
{
    public interface IHardwareRepository : IRepositoryBase<Hardware>
    {
        IQueryable<Hardware> GetHardwareByOwner(int? id);
    }
}
