using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Interfaces;
using CoreVjezbaMvc.Data.Model;

namespace CoreVjezbaMvc.ViewModels
{
    public class DrinkListViewModel : Controller
    {
       public IEnumerable<Drink> Drinks { get; set; }
       public string CurrentCategory { get; set; }
    }
}
