using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Interfaces;
using CoreVjezbaMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreVjezbaMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;

        public HomeController( IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferedDrinks
            };
            return View(homeViewModel);
        }
    }
}