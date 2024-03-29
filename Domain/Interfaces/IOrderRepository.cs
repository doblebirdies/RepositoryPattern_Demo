﻿using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersGreaterThan(decimal amount);
        Task<IEnumerable<Order>> GetOrdersBetween(DateTime startDate, DateTime endDate);
    }
}
