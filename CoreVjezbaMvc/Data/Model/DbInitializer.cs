using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreVjezbaMvc.Data.Model;

namespace CoreVjezbaMvc.Data.Model
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Category.Any())
            {
                context.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                    (
                  new Drink
                  {
                      Name = "Beer",
                      Price = 7.95M,
                      ShortDesc = "The most widely consumed alcohol",
                      LongDesc = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                      Category = Categories["Alcoholic"],
                      ImageUrl = "",
                      InStock = 1,
                      IsPrefered = true,

                  },
                     new Drink
                     {
                         Name = "Tequila ",
                         Price = 12.95M,
                         ShortDesc = "Beverage made from the blue agave plant.",
                         LongDesc = "Teq",
                         Category = Categories["Alcoholic"],
                         ImageUrl = "",
                         InStock = 1,
                         IsPrefered = true,

                     }

                    );
            }
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Desc="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Desc="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }

}
