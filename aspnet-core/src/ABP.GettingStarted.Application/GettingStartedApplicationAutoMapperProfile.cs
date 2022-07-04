using ABP.GettingStarted.Products;
using ABP.GettingStarted.Products.Dtos;
using AutoMapper;

namespace ABP.GettingStarted;

public class GettingStartedApplicationAutoMapperProfile : Profile
{
    public GettingStartedApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
            CreateMap<Product, ProductDto>();
            CreateMap<CreateUpdateProductDto, Product>(MemberList.Source);
    }
}
