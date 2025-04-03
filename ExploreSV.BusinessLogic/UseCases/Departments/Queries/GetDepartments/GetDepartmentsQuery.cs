using ExploreSV.BusinessLogic.DTOs;
using MediatR;

namespace ExploreSV.BusinessLogic.UseCases.Departments.Queries.GetDepartments;

public record GetDepartmentsQuery() : IRequest<List<DepartmentResponse>>;