using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;

namespace PieShopStockApp.Models
{
    public partial class Pie : ObservableObject
    {
       public Guid Id { get; set; }

        [ObservableProperty]
        private string pieName;
        [ObservableProperty]
        private string description;
        [ObservableProperty]
        private double price;
        [ObservableProperty]
        private string imageUrl;
        [ObservableProperty]
        private bool inStock;

      
    }
}
