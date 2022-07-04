using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ABP.GettingStarted.Order
{
    public class OrderItem: Entity<Guid>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Unit { get; set; }


        protected OrderItem()
        {
        }

        public OrderItem(
            Guid id,
            string code,
            string description,
            int unit
        ) : base(id)
        {
            Code = code;
            Description = description;
            Unit = unit;
        }
    }
}
