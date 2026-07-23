using MVC_Project.Models;
using MVC_Project.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Project.Service
{
    public class HardwareService : IHardwareService
    {
        private readonly IHardwareRepository _hardwareRepository;
        public HardwareService(IHardwareRepository hardwareRepository)
        {
            _hardwareRepository = hardwareRepository;
        }
        public IEnumerable<Hardware> GetHardwareByOwner(int? id)
        {
            return _hardwareRepository.GetHardwareByOwner(id).ToList();
        }
    }
}