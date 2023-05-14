using CQRSDemoApp.Models;
using CQRSDemoApp.Services;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRSDemoApp.Features.Players.Commands
{
    public class UpdatePlayerCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }

        public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand, int>
        {
            private readonly IPlayerService _playerService;
            public UpdatePlayerCommandHandler(IPlayerService PlayerService)
            {
                _playerService = PlayerService;
            }
            public async Task<int> Handle(UpdatePlayerCommand request, CancellationToken cancellationToken)
            {
                var player = await _playerService.GetPlayerById(request.Id);
                if (player == null)
                    return default;

                player.ShirtNo = request.ShirtNo;
                player.Name = request.Name;
                player.Appearances = request.Appearances;
                player.Goals = request.Goals;

                return await _playerService.UpdatePlayer(player);
            }
        }
    }
}
