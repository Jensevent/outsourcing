using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using outsource_onderdeel.Dataset.DataContext;
using outsource_onderdeel.Dataset.DataContext.MSSQL;
using outsource_onderdeel.Dataset.DataContext.Repositories;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Controllers
{
    public class MapController : Controller
    {
        private readonly UserRepo userRepo;
        private readonly LocationRepo locationRepo;

        public MapController()
        {
            IUserContext IUContext = new UserMSSQLContext();
            ILocationContext ILContext = new LocationMSSQLContext();
            userRepo = new UserRepo(IUContext);
            locationRepo = new LocationRepo(ILContext);
        }

        public IActionResult Index()
        {
            int uvm;
            uvm = userRepo.GetCurrentUserLocation(1);
            LocationViewModel lvm = new LocationViewModel();
            lvm = locationRepo.GetByID(uvm);
            return View(lvm);
        }

        [HttpGet]
        public IActionResult RoomChange(long id)
        {
            UserViewModel vm = new UserViewModel();
            vm = userRepo.InsertUserLocationByID(1, id);
            return View(vm);
        }
    }
}