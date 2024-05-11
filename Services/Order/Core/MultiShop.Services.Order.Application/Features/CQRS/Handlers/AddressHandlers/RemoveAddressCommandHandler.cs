using MultiShop.Services.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Services.Order.Application.Interfaces;
using MultiShop_Services.Order.Domain.Entities;

namespace MultiShop.Services.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class RemoveAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;
     
        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        
        public async Task Handle(RemoveAddressCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.DeleteAsync(value);
        }
    }
}