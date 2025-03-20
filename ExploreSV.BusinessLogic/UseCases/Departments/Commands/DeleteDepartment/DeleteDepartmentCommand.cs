using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreSV.BusinessLogic.UseCases.Departments.Commands.DeleteDepartment;

public record DeleteDepartmentCommand(int DepartmentId) : IRequest<int>;