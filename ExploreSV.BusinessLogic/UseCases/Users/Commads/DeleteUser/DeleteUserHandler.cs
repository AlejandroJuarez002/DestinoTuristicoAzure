using ExploreSV.DataAccess.Interfaces;
using ExploreSV.Entities;
using MediatR;

namespace ExploreSV.BusinessLogic.UseCases.Users.Commads.DeleteUser;

internal sealed class DeleteUserHandler(IEfRepository<User> _repository)
    : IRequestHandler<DeleteUserCommand, int>
{
    public async Task<int> Handle(DeleteUserCommand command, CancellationToken cancellationToken)
    {
        var existingUser = await _repository.GetByIdAsync(command.UserId);

        if (existingUser is null) return 0;

        await _repository.DeleteAsync(existingUser, cancellationToken);

        return existingUser.UserId;
    }
}

