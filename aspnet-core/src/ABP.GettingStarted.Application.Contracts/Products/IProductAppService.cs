using System;
using ABP.GettingStarted.Products.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ABP.GettingStarted.Products
{
    public interface IProductAppService :
        ICrudAppService< 
            ProductDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateProductDto,
            CreateUpdateProductDto>
    {

    }
}