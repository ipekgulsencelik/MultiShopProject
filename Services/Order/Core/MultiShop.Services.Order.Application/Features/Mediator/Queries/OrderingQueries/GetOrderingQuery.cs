using MediatR;
using MultiShop.Services.Order.Application.Features.Mediator.Results.OrderingResults;

namespace MultiShop.Services.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
    }
}