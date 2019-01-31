using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Interfaces;
using CoreVjezbaMvc.Data;
using CoreVjezbaMvc.Data.Model;
using Microsoft.AspNetCore.Mvc;
using CoreVjezbaMvc.ViewModels;

namespace CoreVjezbaMvc.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkRepository drinkRepository;
        private readonly ICategoryRepository categoryRepository;

        public DrinkController(IDrinkRepository drink , ICategoryRepository category)
        {
            drinkRepository = drink;
            categoryRepository = category;
        }

        public ViewResult List(string category)
        {

            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;
            if (string.IsNullOrEmpty(category))
            {
                drinks = drinkRepository.Drinks.OrderBy(n => n.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if(string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                {
                    drinks = drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Alcoholic")).OrderBy(p => p.Name);
                }
                else
                {
                    drinks = drinkRepository.Drinks.Where(p => p.Category.CategoryName.Equals("Non-alcoholic")).OrderBy(p => p.Name);
                }



            }
            currentCategory = _category;
            var drinkListViewModel = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };
                return View(drinkListViewModel);


        }

    }
}