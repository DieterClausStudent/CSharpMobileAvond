using Microsoft.EntityFrameworkCore;
using PieShop.API.DbContexts;
using PieShop.API.Entitites;

namespace PieShop.API.Services
{
 
    public class PieRepository : IPieRepository
    {
        private readonly PieShopDbContext _context;


        public PieRepository(PieShopDbContext context)
        {
            _context = context;
        }
        public async Task<Pie> AddPieAsync(Pie pie)
        {
            await _context.Pies.AddAsync(pie);
            return pie;
        }

        public void DeletePie(Pie pie)
        {
            _context.Pies.Remove(pie);
        }
        public async Task<Pie?> GetPieAsync(Guid id)
        {
            return await _context.Pies.Where(p => p.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Pie>> GetPiesAsync()
        {
            return await _context.Pies.OrderBy(p => p.PieName).AsNoTracking().ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() >= 0);
        }

        public void UpdatePie(Pie pie)
        {
            _context.Pies.Update(pie);
        }
    }
}
