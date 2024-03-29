using MediatR;
using MultiShop.Services.Order.Application.Features.Mediator.Results.OrderingResults;

namespace MultiShop.Services.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
