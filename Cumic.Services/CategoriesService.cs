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
        public Category GetCategory(int ID)
        {
            using (var context = new CumicContext())
            {
                return context.Categories.Find(ID);
            }
        }
        public List<Category> GetCategories()
        {
            using( var context = new CumicContext())
            {
                return context.Categories.ToList();
            }
        }
        public void SaveCategory(Category category)
        {
            using (var context = new CumicContext())
            {
                context.Categories.Add(category);

                context.SaveChanges();
            }
        }
        public void UpdateCategory(Category category)
        {
            using (var context = new CumicContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }
    }
}
