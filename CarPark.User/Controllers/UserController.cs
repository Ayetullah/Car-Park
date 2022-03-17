using CarPark.Core.Repository.Abstract;
using CarPark.Entities.Models;
using CarPark.User.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarPark.User.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _localizer;
        private readonly IRepository<Personel> _repository;

        public UserController(IStringLocalizer<UserController> localizer, IRepository<Personel> repository)
        {
            _localizer = localizer;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(UserCreateRequestModel models)
        {
            
            return View();
        }
    }
}
