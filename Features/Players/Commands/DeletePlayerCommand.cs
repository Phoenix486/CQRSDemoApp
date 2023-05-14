using CQRSDemoApp.Services;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRSDemoApp.Features.Players.Commands
{
    public class DeletePlayerCommand : IRequest<int>
    {
        public int Id { get; set; }
        public class DeletePlayerCommandHandler : IRequestHandler<DeletePlayerCommand, int>
        {
            private readonly IPlayerService _playerService;
            public DeletePlayerCommandHandler(IPlayerService PlayerService)
            {
                _playerService = PlayerService;
            }
            public async Task<int> Handle(DeletePlayerCommand request, CancellationToken cancellationToken)
            {
                var player = await _playerService.GetPlayerById(request.Id);
                if (player == null)
                    return default;

                return await _playerService.DeletePlayer(player);
            }
        }
    }
}
