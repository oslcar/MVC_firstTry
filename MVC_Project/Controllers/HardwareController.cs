using MVC_Project.Repositories;
using MVC_Project.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Project.Controllers
{
    public class HardwareController : Controller
    {
        // GET: Hardware
        private readonly IHardwareService _hardwareService;
        public HardwareController(IHardwareService hardwareService)
        {
            _hardwareService = hardwareService;
        }
        public ActionResult ListOfHardware(int? id)
        {
            return View(_hardwareService.GetHardwareByOwner(id));
        }
    }
}