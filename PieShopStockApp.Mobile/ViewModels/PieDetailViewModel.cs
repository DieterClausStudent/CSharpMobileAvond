using PieShopStockApp.Models;
using PieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using PieShopStockApp.Utility;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.ComponentModel;
using PieShopStockApp.Messages;


namespace PieShopStockApp.ViewModels
{
    [QueryProperty("SelectedPie", "selectedPie")]
    public partial class PieDetailViewModel : BaseViewModel
    {
        // Toont detail van 1 Pie


        private IPieRepository _pieRepository;
      //  private Pie _selectedPie;

       // public ICommand SaveCommand { get; set; }

        public PieDetailViewModel(IPieRepository pieRepository, INavigationService navigationService): base(navigationService) 
        {
            _pieRepository  = pieRepository;
            SelectedPie = new Pie();
            //SaveCommand = new AsyncRelayCommand(OnSaveCommand);
        }

        [ObservableProperty]
        private Pie selectedPie;
        //public Pie SelectedPie
        //{
        //    get { return _selectedPie; }
        //    set
        //    {
        //        _selectedPie = value;
        //        OnPropertyChanged(nameof(SelectedPie));
        //    }
        //}


        [RelayCommand]
        private async Task Save()
        {
            if(SelectedPie.Id == Guid.Empty)
            {
                await _pieRepository.AddPie(SelectedPie);
            }
            else
            {
                await _pieRepository.UpdatePie(SelectedPie);
            }

            WeakReferenceMessenger.Default.Send(new PieMessage(MessageNames.PieChanged));

            await NavigationService.PopAsync();
        }


    }
}
