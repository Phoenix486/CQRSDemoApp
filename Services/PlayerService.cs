using CQRSDemoApp.Data;
using CQRSDemoApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemoApp.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly AppDbContext _dbContext;
        public PlayerService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Player> CreatePlayer(Player player)
        {
            _dbContext.Players.Add(player);
            await _dbContext.SaveChangesAsync();
            return player;
        }

        public async Task<int> DeletePlayer(Player player)
        {
            var result =  _dbContext.Players.Remove(player);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Player> GetPlayerById(int id)
        {
            return await _dbContext.Players.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Player>> GetPlayersList()
        {
            return await _dbContext.Players.ToListAsync();
        }

        public async Task<int> UpdatePlayer(Player player)
        {
            _dbContext.Players.Update(player);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
