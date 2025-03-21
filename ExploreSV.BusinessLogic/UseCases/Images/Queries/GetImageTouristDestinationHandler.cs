using ExploreSV.BusinessLogic.DTOs;
using ExploreSV.DataAccess.Interfaces;
using ExploreSV.Entities;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreSV.BusinessLogic.UseCases.Images.Queries;

internal class GetImageTouristDestinationHandler(IEfRepository<Image> _repository)
    : IRequestHandler<GetImageTouristDestinationQuery, List<ImageTouristDestinationResponse>>
{
    public async Task<List<ImageTouristDestinationResponse>> Handle(GetImageTouristDestinationQuery query, CancellationToken cancellationToken)
    {
        var categories = await _repository.ListAsync(cancellationToken);
        if (categories == null || !categories.Any())
        {
            return new List<ImageTouristDestinationResponse>();
        }
        return categories.Adapt<List<ImageTouristDestinationResponse>>();
    }
}

