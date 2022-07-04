using System;
using ABP.GettingStarted.Permissions;
using ABP.GettingStarted.Products.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABP.GettingStarted.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto, CreateUpdateProductDto>,
        IProductAppService
    {
        protected override string GetPolicyName { get; set; } = GettingStartedPermissions.Product.Default;
        protected override string GetListPolicyName { get; set; } = GettingStartedPermissions.Product.Default;
        protected override string CreatePolicyName { get; set; } = GettingStartedPermissions.Product.Create;
        protected override string UpdatePolicyName { get; set; } = GettingStartedPermissions.Product.Update;
        protected override string DeletePolicyName { get; set; } = GettingStartedPermissions.Product.Delete;

        private readonly IProductRepository _repository;
        
        public ProductAppService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
