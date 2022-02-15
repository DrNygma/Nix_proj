using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainCore.Models;

namespace InfrastructureData
{
    public interface ICart
    {
        void AddToCart(Guid clientId, Guid productId);                 
        void RemoveFromCart(Guid clientId, Guid productId);
    }
}
