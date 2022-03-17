using CarPark.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class PersonelsController : Controller
    {
        private readonly IPersonelService _personelService;
        public PersonelsController(IPersonelService personelService)
        {
            _personelService = personelService;
        }

        public IActionResult Index()
        {
            return View(_personelService.GetPersonelsByAge().Entities);
        }
    }
}
