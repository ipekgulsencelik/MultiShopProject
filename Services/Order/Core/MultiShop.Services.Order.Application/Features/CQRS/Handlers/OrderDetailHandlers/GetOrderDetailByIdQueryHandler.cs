using MultiShop.Services.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using MultiShop.Services.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Services.Order.Application.Interfaces;
using MultiShop_Services.Order.Domain.Entities;

namespace MultiShop.Services.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class GetOrderDetailByIdQueryHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        
        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetOrderDetailByIdQueryResult
            {
                OrderDetailID = values.OrderDetailID,
                ProductAmount = values.ProductAmount,
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                OrderingID = values.OrderingID,
                ProductPrice = values.ProductPrice,
                ProductTotalPrice = values.ProductTotalPrice
            };
        }
    }
}