using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _ICategorydal;
        public CategoryManager(ICategoryDal ıCategorydal)
        {
            _ICategorydal = ıCategorydal;
        }

        public void CategoryAdd(Category category)
        {
            _ICategorydal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _ICategorydal.List();
        }
        
    }
}
