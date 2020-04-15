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

        public MapController()
        {
            IUserContext Icontext = new UserMSSQLContext();
            userRepo = new UserRepo(Icontext);
        }

        public IActionResult Index()
        {
            return View();
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