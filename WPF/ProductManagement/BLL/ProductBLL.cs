using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagement.DAL;
using ProductManagement.Models;

namespace ProductManagement.BLL
{
    public class ProductBLL
    {
        ProductDAL _prdDAL = new();

        public List<Product> GetAllProduct()
        {
            return _prdDAL.GetAllProducts();
        }

        public void AddNewProduct(Product x) { 
            _prdDAL.AddNewProduct(x);
        }

        public void UpdateProduct(Product x)
        {
            _prdDAL.UpdateProduct(x);
        }

        public void DeleteProduct(Product x)
        {
            _prdDAL.DeleteProduct(x);
        }

        public List<Product> SearchByName(string kw)
        {
            var listPrd = new List<Product>();
            if (kw.Trim().Length == 0)
            {
                listPrd = _prdDAL.GetAllProducts().ToList();
            }
            else
            {
                listPrd = _prdDAL.GetAllProducts()
                        .Where(p => p.PName.ToLower()
                        .Contains(kw.Trim().ToLower()))
                        .ToList();
            }
            return listPrd;
        }
    }
}
