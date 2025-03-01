﻿using AutoMapper;
using Ordening.Application.Features.Orders.CheckoutOrder;
using Ordening.Application.Features.Orders.Commands.UpdateOrder;
using Ordening.Application.Features.Queries.GetOrdersList;
// using Ordering.Application.Features.Orders.Commands.CheckoutOrder;
// using Ordering.Application.Features.Orders.Commands.UpdateOrder;
// using Ordering.Application.Features.Orders.Queries.GetOrdersList;
using Ordering.Domain.Entities;

namespace Ordering.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommand>().ReverseMap();
        }
    }
}