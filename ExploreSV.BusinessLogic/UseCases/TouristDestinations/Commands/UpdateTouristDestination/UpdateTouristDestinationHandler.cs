using ExploreSV.DataAccess.Interfaces;
using ExploreSV.Entities;
using MediatR;
using Mapster;

namespace ExploreSV.BusinessLogic.UseCases.TouristDestinations.Commands.UpdateTouristDestination;

internal sealed class UpdateTouristDestinationHandler(IEfRepository<TouristDestination> _repository)
    : IRequestHandler<UpdateTouristDestinationCommand, int>
{
    public async Task<int> Handle(UpdateTouristDestinationCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var existingTouristDestination = await _repository.GetByIdAsync(command.Request.TouristDestinationId);
            
            if (existingTouristDestination is null) return 0;

            existingTouristDestination = command.Request.Adapt(existingTouristDestination);

            await _repository.UpdateAsync(existingTouristDestination, cancellationToken);

            return existingTouristDestination.TouristDestinationId;
        }
        catch(Exception)
        {
            return 0;
            throw;
        }
    }
}