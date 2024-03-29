using MediatR;
using MultiShop.Services.Order.Application.Features.Mediator.Queries.OrderingQueries;
using MultiShop.Services.Order.Application.Features.Mediator.Results.OrderingResults;
using MultiShop.Services.Order.Application.Interfaces;
using MultiShop_Services.Order.Domain.Entities;

namespace MultiShop.Services.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingByIdQueryHandler : IRequestHandler<GetOrderingByIdQuery, GetOrderingByIdQueryResult>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingByIdQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<GetOrderingByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetOrderingByIdQueryResult
            {
                OrderDate = values.OrderDate,
                OrderingID = values.OrderingID,
                TotalPrice = values.TotalPrice,
                UserID = values.UserID
            };
        }
    }
}