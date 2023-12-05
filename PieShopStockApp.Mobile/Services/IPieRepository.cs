using PieShopStockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PieShopStockApp.Services
{
    public interface IPieRepository
    {
        Task<Pie> AddPie(Pie pie);
        Task UpdatePie(Pie pie);
        Task<List<Pie>> GetAllPies();
    }
}
