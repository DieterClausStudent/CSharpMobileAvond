using PieShop.API.Entitites;

namespace PieShop.API.Services
{
    public interface IPieRepository
    {
        Task<IEnumerable<Pie>> GetPiesAsync();

        Task<Pie?> GetPieAsync(Guid id);

        Task<Pie> AddPieAsync(Pie pie);

        void UpdatePie(Pie pie);

        void DeletePie(Pie pie);

        Task<bool> SaveChangesAsync();
    }
}
