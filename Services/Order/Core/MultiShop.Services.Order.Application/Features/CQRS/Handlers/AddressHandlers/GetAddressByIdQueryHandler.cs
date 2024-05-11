using MultiShop.Services.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Services.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Services.Order.Application.Interfaces;
using MultiShop_Services.Order.Domain.Entities;

namespace MultiShop.Services.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAddressByIdQueryResult
            {
                AddressID = values.AddressID,
                City = values.City,
                Detail = values.Detail,
                District = values.District,
                UserID = values.UserID
            };
        }
    }
}