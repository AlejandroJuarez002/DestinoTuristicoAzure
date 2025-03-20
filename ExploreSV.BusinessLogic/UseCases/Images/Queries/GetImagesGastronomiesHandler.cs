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

internal class GetImagesGastronomiesHandler(IEfRepository<Image> _repository)
    : IRequestHandler<GetImagesGastronomiesQuery, List<ImageGastronomyResponse>>
{
    public async Task<List<ImageGastronomyResponse>> Handle(GetImagesGastronomiesQuery query, CancellationToken cancellationToken)
    {
        var categories = await _repository.ListAsync(cancellationToken);
        if (categories == null || !categories.Any())
        {
            return new List<ImageGastronomyResponse>();
        }
        return categories.Adapt<List<ImageGastronomyResponse>>();
    }
}
