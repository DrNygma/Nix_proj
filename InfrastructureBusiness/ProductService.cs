using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;
using InfrastructureData.DataAccess;
using ServicesInterfaces;
using System.Web;
using System.Web.Mvc;

namespace InfrastructureBusiness
{
    public class ProductService : IProduct
    {
        private UnitOfWork unitOfWork;
        public ProductService(UnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }
        public Product GetProduct(Guid productId)
        {
            var product = unitOfWork.ProductRepository.GetById(productId);
            if (product != null)
                return mapper.Map<Charger, ChargerDTO>(product);
            else
                return new ChargerDTO();
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var model = unitOfWork.ProductRepository.GetAll();
            return View(model);
        }
        public IEnumerable<Product> GetbyPriceLowToHigh()
        {

        }
        public IEnumerable<Product> GetbyPriceHighToLow()
        {

        }
        public IEnumerable<Product> GetBestselling()
        {

        }
        public double GetProductRating(Guid productId)
      
        public Product GetByName(string productName)
        {
            if (!string.IsNullOrEmpty(productName))
            {
                List<Product> products = unitOfWork.ProductRepository.Find(n => n.Name == productName).ToList();
                if (products.Count != 0)
                    return mapper.Map<Product, ProductDTO>(products[0]);
                else
                    return new ProductDTO();
            }
            else
                return new ProductDTO();
        }
        public IEnumerable<Product> GetProductsByBrand(string brandName)
        public IEnumerable<Product> GetProductsByCategory(string categoryName)





        
        public Product FindByName(string productName)
        {
            if (!string.IsNullOrEmpty(productName))
            {
                List<Product> products = unitOfWork.ProductRepository.Find(n => n.Name == productName).ToList();
                if (products.Count != 0)
                    return mapper.Map<Product, ProductDTO>(products[0]);
                else
                    return new ProductDTO();
            }
            else
                return new ProductDTO();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var model = unitOfWork.ProductRepository.GetAll();
            return View(model);
        }

        public IEnumerable<Product> GetByReview()
        {
            List<Product> products = unitOfWork.ProductRepository.GetAll().OrderBy(n => n.Reviews.Count).ToList();
            return mapper.Map<List<Product>, IList<ProductDTO>>(products);
        }

        public IEnumerable<Product> GetbyPriceLowToHigh()
        {
            return mapper.Map<IEnumerable<Product>, List<ProductDTO>>(unitOfWork.ProductRepository.GetAll().OrderBy(u => u.Price));
        }

        public IEnumerable<Product> GetbyPriceHighToLow()
        {
            return mapper.Map<IEnumerable<Product>, List<ProductDTO>>(unitOfWork.ProductRepository.GetAll().OrderByDescending(u => u.Price));
        }

        public IEnumerable<Product> GetPopular()
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(Guid productId)
        {
            var product = unitOfWork.ProductRepository.Get(productId);
            if (product != null)
                return mapper.Map<Product, ProductDTO>(product);
            else
                return new ProductDTO();
        }

        public double GetProductRating(Guid productId)
        {
            var product = unitOfWork.ProductRepository.Get(productId);
            if (product != null)
            {
                List<Review> resultList = unitOfWork.ReviewRepository.Find(n => n.ProductProductId == productId).ToList();
                return resultList.Average(n => n.Rating);
            }
            else
                return 0;
        }

        public IEnumerable<Product> GetProductsByBrand(string modelName)
        {
            if (!string.IsNullOrEmpty(modelName))
            {
                List<Product> products = unitOfWork.ProductRepository.Find(n => n.Trademark.Name == modelName).ToList();
                if (products.Count != 0)
                {
                    return mapper.Map<List<Product>, IList<ProductDTO>>(products);
                }
                else
                    return new List<ProductDTO>();
            }
            else
                return new List<ProductDTO>();
        }

        public int GetReviewsNumber(Guid productId)
        {
            var products = unitOfWork.ProductRepository.Get(productId);
            if (products != null)
            {
                int count = unitOfWork.ReviewRepository.GetAll().Count(n => n.ProductProductId == productId);
                return count;
            }
            else
                return 0;
        }
    }
}