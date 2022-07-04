using System;
using System.Linq;
using System.Threading.Tasks;
using ABP.GettingStarted.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ABP.GettingStarted.Products
{
    public class ProductRepository : EfCoreRepository<GettingStartedDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<GettingStartedDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<Product>> WithDetailsAsync()
        {
            return (await GetQueryableAsync()).IncludeDetails();
        }
    }
}
