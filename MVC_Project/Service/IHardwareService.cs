using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Service
{
    public interface IHardwareService
    {
        IEnumerable<Hardware> GetHardwareByOwner(int? id);
    }
}
