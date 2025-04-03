using ExploreSV.BusinessLogic.DTOs;
using ExploreSV.DataAccess.Interfaces;
using ExploreSV.Entities;
using Mapster;
using MediatR;

namespace ExploreSV.BusinessLogic.UseCases.Categories.Queries.GetCategories;

internal sealed class GetCategoriesHandler(IEfRepository<Category> _repository)
    : IRequestHandler<GetCategoriesQuery, List<CategoryResponse>>
{
    public async Task<List<CategoryResponse>> Handle(GetCategoriesQuery query, CancellationToken cancellationToken)
    {
        var categories = await _repository.ListAsync(cancellationToken);

        if (categories == null || !categories.Any())
        {
            return new List<CategoryResponse>();
        }
        return categories.Adapt<List<CategoryResponse>>();
    }
}