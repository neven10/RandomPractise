using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Model;

namespace CoreVjezbaMvc.Data.Interfaces
{
   public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferedDrinks { get; }
        Drink GetDrinkById(int drinkId);
    }
}
