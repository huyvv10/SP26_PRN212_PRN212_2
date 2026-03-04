using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Models;

namespace ProductManagement.DAL
{

    public class ProductDAL
    {
        public Dbsp26prn2122Context _dbContext;

        public List<Product> GetAllProducts()
        {
            _dbContext = new();
            List<Product> prodList = new List<Product>();
            prodList = _dbContext.Products.Include(c => c.Cat).ToList();
            return prodList;
        }

        public void AddNewProduct(Product x)
        {
            try
            {
                _dbContext = new();
                _dbContext.Products.Add(x);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteProduct(Product x)
        {
            try
            {
                _dbContext = new();
                _dbContext.Products.Remove(x);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message) ;
            }
        }

        public void UpdateProduct(Product x) {
            try
            {
                _dbContext = new();
                _dbContext.Products.Update(x);
                _dbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message) ;
            }
        }
    }
}
