using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABP.GettingStarted.Products
{
    public class Product: FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        protected Product()
        {
        }

        public Product(
            Guid id,
            string name,
            string description,
            decimal price
        ) : base(id)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
