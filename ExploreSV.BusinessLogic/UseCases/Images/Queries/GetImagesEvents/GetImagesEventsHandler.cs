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

namespace ExploreSV.BusinessLogic.UseCases.Images.Queries.GetImagesEvents;
internal class GetImagesEventsHandler(IEfRepository<Image> _repository)
    : IRequestHandler<GetImagesEventsQuery, List<ImageEventResponse>>
{
    public async Task<List<ImageEventResponse>> Handle(GetImagesEventsQuery query, CancellationToken cancellationToken)
    {
        var categories = await _repository.ListAsync(cancellationToken);
        if (categories == null || !categories.Any())
        {
            return new List<ImageEventResponse>();
        }
        return categories.Adapt<List<ImageEventResponse>>();
    }
}

