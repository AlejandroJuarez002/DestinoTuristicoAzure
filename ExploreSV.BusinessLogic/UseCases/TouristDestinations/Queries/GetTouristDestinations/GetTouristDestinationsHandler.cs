using ExploreSV.BusinessLogic.DTOs;
using ExploreSV.BusinessLogic.UseCases.TouristDestinations.Specifications;
using ExploreSV.DataAccess.Interfaces;
using ExploreSV.Entities;
using Mapster;
using MediatR;

namespace ExploreSV.BusinessLogic.UseCases.TouristDestinations.Queries.GetTouristDestinations;

internal sealed class GetTouristDestinationsHandler(IEfRepository<TouristDestination> _repository)
    : IRequestHandler<GetTouristDestinationsQuery, List<TouristDestinationResponse>>
{
    public async Task<List<TouristDestinationResponse>> Handle(GetTouristDestinationsQuery query, CancellationToken cancellationToken)
    {
        var touristDestinations = await _repository.ListAsync(new GetTouristDestinationWithCategorySpec(), cancellationToken);

        if (touristDestinations == null && !touristDestinations.Any())
        {
            return new List<TouristDestinationResponse>();
        }

        return touristDestinations.Adapt<List<TouristDestinationResponse>>();
    }
}