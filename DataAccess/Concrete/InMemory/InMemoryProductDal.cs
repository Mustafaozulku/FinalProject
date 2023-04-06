using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{CategoryId=1,ProductId=1,ProdactName="bardak",UnitPrice=15,UnitsİnStock=20},
                new Product{CategoryId=1,ProductId=2,ProdactName="telefon",UnitPrice=20000,UnitsİnStock=10},
                new Product{CategoryId=2,ProductId=3,ProdactName="kamera",UnitPrice=1500,UnitsİnStock=8},
                new Product{CategoryId=2,ProductId=4,ProdactName="kulaklık",UnitPrice=1000,UnitsİnStock=15},
                new Product{CategoryId=2,ProductId=5,ProdactName="klavye",UnitPrice=800,UnitsİnStock=3}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
          
          Product prodactToDelete = _products.SingleOrDefault(p=>p.ProductId ==product.ProductId);
            
            _products.Remove(prodactToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;  
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product prodactToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            prodactToUpdate.UnitsİnStock = product.UnitsİnStock;
            prodactToUpdate.UnitPrice = product.UnitPrice;
            prodactToUpdate.CategoryId = product.CategoryId;
            prodactToUpdate.ProdactName = product.ProdactName;
        }
       
    }
}
