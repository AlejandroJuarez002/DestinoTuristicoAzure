using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreSV.BusinessLogic.UseCases.Users.Commads.DeleteUser;

public record DeleteUserCommand(int UserId) : IRequest<int>;
