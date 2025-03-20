using ExploreSV.BusinessLogic.DTOs;
using ExploreSV.DataAccess.Interfaces;
using ExploreSV.Entities;
using MediatR;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ExploreSV.BusinessLogic.UseCases.Departments.Queries.GetDepartments;

internal sealed class GetDepartamentsHandler(IEfRepository<Department> _repository) : IRequestHandler<GetDepartmentsQuery, List<DepartmentResponse>>
{
    public async Task<List<DepartmentResponse>> Handle(GetDepartmentsQuery query, CancellationToken cancellationToken)
    {
        var departments = await _repository.ListAsync(cancellationToken);

        if (departments == null || !departments.Any())
        {
            return new List<DepartmentResponse>();
        }

        return departments.Adapt<List<DepartmentResponse>>();
    }
}