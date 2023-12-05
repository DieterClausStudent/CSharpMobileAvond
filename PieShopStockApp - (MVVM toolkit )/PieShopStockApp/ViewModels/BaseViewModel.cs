using CommunityToolkit.Mvvm.ComponentModel;
using PieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PieShopStockApp.ViewModels
{
    public class BaseViewModel : ObservableObject
    {
      //  public event PropertyChangedEventHandler PropertyChanged;

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public INavigationService NavigationService { get; set; }

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
