using PieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;


namespace PieShopStockApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public INavigationService NavigationService { get; private set; }

   
    }
}
