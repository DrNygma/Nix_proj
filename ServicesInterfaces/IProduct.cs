using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;

namespace InfrastructureData
{
    public interface IProduct
    {
        IEnumerable<Product> GetbyPriceLowToHigh();                  // Сортировка от дешевых к дорогим продуктам
        IEnumerable<Product> GetbyPriceHighToLow();                  // Сортировка от дорогих к дешевым продуктам
        IEnumerable<Product> GetBestselling();                           // Сортировка по популярности (проверять на наличие в заказах)
        double GetProductRating(Guid productId);               // Средний рейтинг продукта
        Product GetProduct(Guid productId);                          // Получить информацию о конкретном продукте
        IEnumerable<Product> GetAllProducts();                       // Получить все продукты
        Product FindByName(string productName);                      // Поиск по названию продукта
        IEnumerable<Product> GetProductsByBrand(string brandName);
        IEnumerable<Product> GetProductsByCategory(string categoryName);// Получить продукт по марке производителя
    }
}
