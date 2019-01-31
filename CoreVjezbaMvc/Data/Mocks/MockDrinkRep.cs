using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Interfaces;
using CoreVjezbaMvc.Data.Model;

namespace CoreVjezbaMvc.Data
{
    public class MockDrinkRep : IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRep();

        public IEnumerable<Drink> Drinks
        {
            get
            {
                return new List<Drink>
                {
                    new Drink {
                        Name = "Beer",
                        Price = 7.95M,
                        ShortDesc = "The most widely consumed alcohol",
                        LongDesc = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = _categoryRepository.Category.First(),
                        ImageUrl = "http://imgh.us/beerL_2.jpg",
                        IsPrefered = true
                    } };
            }
        }

        public IEnumerable<Drink> PreferedDrinks { get; set; }
        public IEnumerable<Category> Category { get; set; }


        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }
    }
}
