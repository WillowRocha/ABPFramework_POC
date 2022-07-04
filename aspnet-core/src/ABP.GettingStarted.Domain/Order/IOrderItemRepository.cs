using System;
using Volo.Abp.Domain.Repositories;

namespace ABP.GettingStarted.Order
{
    public interface IOrderItemRepository : IRepository<OrderItem, Guid>
    {
    }
}