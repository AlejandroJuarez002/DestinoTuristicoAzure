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

namespace ExploreSV.BusinessLogic.UseCases.Events.Queries;
internal sealed class GetEventsHandler(IEfRepository<Category> _repository)
    : IRequestHandler<GetEventsQuery, List<EventResponse>>
{
    public async Task<List<EventResponse>> Handle(GetEventsQuery query, CancellationToken cancellationToken)
    {
        var events = await _repository.ListAsync(cancellationToken);
        if (events == null || !events.Any())
        {
            return new List<EventResponse>();
        }
        return events.Adapt<List<EventResponse>>();
    }
}

