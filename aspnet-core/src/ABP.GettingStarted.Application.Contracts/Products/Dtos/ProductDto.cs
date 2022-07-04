using System;
using Volo.Abp.Application.Dtos;

namespace ABP.GettingStarted.Products.Dtos
{
    [Serializable]
    public class ProductDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}