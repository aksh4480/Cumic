using Cumic.Database;
using CumicEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cumic.Services
{
   public class CategoriesService
    {
        public void SaveCategory(Category category)
        {
            using (var context = new CumicContext())
            {
                context.Categories.Add(category);

                context.SaveChanges();
            }
        }
    }
}
