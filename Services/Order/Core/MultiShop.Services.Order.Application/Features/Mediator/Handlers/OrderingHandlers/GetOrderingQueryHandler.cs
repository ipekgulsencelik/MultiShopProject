using MediatR;
using MultiShop.Services.Order.Application.Features.Mediator.Queries.OrderingQueries;
using MultiShop.Services.Order.Application.Features.Mediator.Results.OrderingResults;
using MultiShop.Services.Order.Application.Interfaces;
using MultiShop_Services.Order.Domain.Entities;

namespace MultiShop.Services.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingQueryHandler : IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
    {
        private readonly IRepository<Ordering> _repository;

        public GetOrderingQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetOrderingQueryResult
            {
                OrderingID = x.OrderingID,
                OrderDate = x.OrderDate,
                TotalPrice = x.TotalPrice,
                UserID = x.UserID
            }).ToList();
        }
    }
}
