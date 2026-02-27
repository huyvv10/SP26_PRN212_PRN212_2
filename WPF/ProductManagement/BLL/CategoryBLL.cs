using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.DAL;
using ProductManagement.Models;

namespace ProductManagement.BLL
{
    public class CategoryBLL
    {
        CategoryDAL _catDAL;
        public List<Category> GetAllCategory()
        {
            _catDAL = new();
            return _catDAL.GetAllCategory();
        }

        public void AddNewCategory(Category x)
        {
            _catDAL = new();
            _catDAL.AddCategory(x);            
        }

        public void DeleteCategory(Category x)
        {
            _catDAL = new();
            _catDAL.DeleteCategory(x);
        }

        public void UpdateCategory(Category x)
        {
            _catDAL = new();
            _catDAL.UpdateCategory(x);
        }

    }
}
