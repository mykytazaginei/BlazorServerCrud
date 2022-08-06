using Microsoft.EntityFrameworkCore;

namespace BlazorServerCrud.Data
{
    public class GameService : IGameService
    {

        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public List<Game> Games { get; set; } = new List<Game>();

        public async Task LoadGames()
        {

            Games = await _context.Games.ToListAsync();

        }

    }
}
