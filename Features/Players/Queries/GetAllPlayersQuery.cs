using CQRSDemoApp.Models;
using CQRSDemoApp.Services;
using MediatR;

namespace CQRSDemoApp.Features.Players.Queries
{
    public class GetAllPlayersQuery : IRequest<IEnumerable<Player>>
    {
        public class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQuery, IEnumerable<Player>>
        {
            private readonly IPlayerService _playerService;
            public GetAllPlayersQueryHandler(IPlayerService PlayerService)
            {
                _playerService = PlayerService;
            }
            public async Task<IEnumerable<Player>> Handle(GetAllPlayersQuery query, CancellationToken cancellationToken)
            {
                return await _playerService.GetPlayersList();
            }
        }
    }
}
