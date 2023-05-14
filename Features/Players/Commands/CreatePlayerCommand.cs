using CQRSDemoApp.Models;
using CQRSDemoApp.Services;
using MediatR;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CQRSDemoApp.Features.Players.Commands
{
    public class CreatePlayerCommand : IRequest<Player>
    {
        [Key]
        public int? ShirtNo { get; set; }
        [Required]
        public string? Name { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }

        public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, Player>
        {
            private readonly IPlayerService _playerService;
            public CreatePlayerCommandHandler(IPlayerService PlayerService)
            {
                _playerService = PlayerService;
            }
            public async Task<Player> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
            {
                var player = new Player()
                {
                    ShirtNo = request.ShirtNo,
                    Name = request.Name,
                    Appearances = request.Appearances,
                    Goals = request.Goals
                };

                return await _playerService.CreatePlayer(player);
            }
        }
    }
}
