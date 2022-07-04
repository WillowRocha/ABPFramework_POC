using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ABP.GettingStarted.Order
{
    public class Order : AggregateRoot<Guid>
    {
        public DateTime DateTime { get; set; }
        public uint SerialNumber { get; set; }
        public Customer Customer { get; set; }
        public OrderItem[] Items { get; set; }


        protected Order()
        {
        }

        public Order(
            Guid id,
            DateTime dateTime,
            uint serialNumber,
            Customer customer,
            OrderItem[] items
        ) : base(id)
        {
            DateTime = dateTime;
            SerialNumber = serialNumber;
            Customer = customer;
            Items = items;
        }
    }
}
