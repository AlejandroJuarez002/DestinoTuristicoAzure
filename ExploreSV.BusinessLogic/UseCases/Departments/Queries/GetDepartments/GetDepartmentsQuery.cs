using ExploreSV.BusinessLogic.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreSV.BusinessLogic.UseCases.Departments.Queries.GetDepartments;

public record GetDepartmentsQuery() : IRequest<List<DepartmentResponse>>;