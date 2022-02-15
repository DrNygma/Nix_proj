using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace InfrastructureData.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext _context;
        public GenericRepository<Brand> brandRepository;
        public GenericRepository<CartItem> cartItemRepository;
        public GenericRepository<Category> categoryRepository;
        public GenericRepository<Comment> commentRepository;
        public GenericRepository<Order> orderRepository;
        public GenericRepository<Product> productRepository;
        public GenericRepository<User> userRepository;
        public UnitOfWork(AppDbContext applicationContext, ILoggerFactory loggerFactory)
        {
            this._context = applicationContext;
        }
        public GenericRepository<Brand> BrandRepository
        {
            get
            {
                if (this.brandRepository == null)
                {
                    this.brandRepository = new GenericRepository<Brand>(_context);
                }
                return brandRepository;
            }
        }
        public GenericRepository<CartItem> CartItemRepository
        {
            get
            {
                if (this.cartItemRepository == null)
                {
                    this.cartItemRepository = new GenericRepository<CartItem>(_context);
                }
                return cartItemRepository;
            }
        }
        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this.categoryRepository == null)
                {
                    this.categoryRepository = new GenericRepository<Category>(_context);
                }
                return categoryRepository;
            }
        }
        public GenericRepository<Comment> CommentRepository
        {
            get
            {
                if (this.commentRepository == null)
                {
                    this.commentRepository = new GenericRepository<Comment>(_context);
                }
                return commentRepository;
            }
        }
        public GenericRepository<Order> OrderRepository
        {
            get
            {
                if (this.orderRepository == null)
                {
                    this.orderRepository = new GenericRepository<Order>(_context);
                }
                return orderRepository;
            }
        }
        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(_context);
                }
                return productRepository;
            }
        }
        public GenericRepository<User> UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new GenericRepository<User>(_context);
                }
                return userRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
