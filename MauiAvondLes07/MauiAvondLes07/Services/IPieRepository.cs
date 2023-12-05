using MauiAvondLes07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAvondLes07.Services
{
    public interface IPieRepository
    {
        void AddPie(Pie pie);
        void UpdatePie(Pie pie);
        List<Pie> GetAllPies();
    }
}
