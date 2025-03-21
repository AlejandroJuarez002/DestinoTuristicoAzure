using ExploreSV.BusinessLogic.DTOs;
using MediatR;

namespace ExploreSV.BusinessLogic.UseCases.TouristDestinations.Queries.GetTouristDestinations;

public record GetTouristDestinationsQuery() : IRequest<List<TouristDestinationResponse>>;