using CQRSDemoApp.Models;
using CQRSDemoApp.Services;
using MediatR;

namespace CQRSDemoApp.Features.Players.Queries
{
    public class GetPlayerByIdQuery : IRequest<Player>
    {
        public int Id { get; set; }
       public class GetPlayerByIdHandler : IRequestHandler<GetPlayerByIdQuery, Player>
        {
            private readonly IPlayerService _playerService;
            public GetPlayerByIdHandler(IPlayerService PlayerService)
            {
                _playerService = PlayerService;
            }
            public async Task<Player> Handle(GetPlayerByIdQuery query, CancellationToken cancellationToken)
            {
                return await _playerService.GetPlayerById(query.Id);
            }
        }
    }
}
