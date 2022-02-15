using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;

namespace ServicesInterfaces
{
    public interface IProduct
    {
        Product GetProduct(Guid productId);
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetbyPriceLowToHigh();                 
        IEnumerable<Product> GetbyPriceHighToLow();                  
        IEnumerable<Product> GetBestselling();                          
        double GetProductRating(Guid productId);                                
        Product GetByName(string productName);                      
        IEnumerable<Product> GetByBrand(string brandName);
        IEnumerable<Product> GetByCategory(string categoryName);
    }
}
