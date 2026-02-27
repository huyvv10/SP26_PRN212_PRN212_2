using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.Models;

namespace ProductManagement.DAL
{

    public class CategoryDAL
    {
        Dbsp26prn2122Context _context;

        public List<Category> GetAllCategory()
        {
            //_context = new Dbsp26prn2122Context();
            _context = new();
            List<Category> catList = new List<Category>();
            catList = _context.Categories.ToList();
            return catList;
        }

        public void AddCategory(Category x)
        {
            try
            {
                _context = new();
                _context.Categories.Add(x);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteCategory(Category x)
        {
            try
            {
                _context = new();
                _context.Categories.Remove(x);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void UpdateCategory(Category x)
        {
            try
            {
                _context = new();
                _context.Categories.Update(x);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
