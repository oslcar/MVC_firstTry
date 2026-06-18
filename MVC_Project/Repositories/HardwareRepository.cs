using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Project.Repositories
{
    public class HardwareRepository : RepositoryBase<Hardware>
    {
        public HardwareRepository(DbContext context) : base(context)
        { 
        }

        public IQueryable<Hardware> GetHardwareByOwner(int? id)
        {
            return _context.Set<Hardware>()
                .Include(emp => emp.Owner)
                .Where(hw => hw.Owner_ID == id);
        }
    }
}