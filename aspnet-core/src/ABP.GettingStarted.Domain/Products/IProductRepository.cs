using System;
using Volo.Abp.Domain.Repositories;

namespace ABP.GettingStarted.Products
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}