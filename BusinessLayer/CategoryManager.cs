using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();


        public List<Category> GetAllCategories()
        {
            return repo.List();
        }
        public void AddCategory(Category category)
        {
            if(category.CategoryName.Length <= 5)
            {
                throw new ArgumentException(message: "5'ten az karakter kullanmayınız");
            }
            else
            {
                repo.Insert(category);
            }
        }
    }
}
