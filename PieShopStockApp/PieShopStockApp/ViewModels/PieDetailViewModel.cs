using PieShopStockApp.Models;
using PieShopStockApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using PieShopStockApp.Messages;
using CommunityToolkit.Mvvm.Messaging;
using PieShopStockApp.Utility;

namespace PieShopStockApp.ViewModels
{
    [QueryProperty(nameof(SelectedPie),"SelectedPie")]
    //of
   // [QueryProperty("SelectedPie","SelectedPie")]
    public  class PieDetailViewModel : BaseViewModel
    {
        private Pie _selectedPie;
        private IPieRepository _pieRepository;

        public ICommand SaveCommand { get; }

        public PieDetailViewModel(IPieRepository pieRepository, INavigationService navigationService) :base(navigationService)
        {
            SelectedPie = new Pie();
            _pieRepository = pieRepository;

            SaveCommand = new AsyncRelayCommand(OnSaveCommand);
        }

        public Pie SelectedPie
        {
            get => _selectedPie;
            set
            {
                _selectedPie = value;
                OnPropertyChanged();
            }
        }

        private async Task OnSaveCommand()
        {
            if(SelectedPie.Id == Guid.Empty)
            {
                _pieRepository.AddPie(SelectedPie);
                WeakReferenceMessenger.Default.Send(new PieMessage(MessageNames.PieChangedMessage));
            }
            else
            {
                _pieRepository.UpdatePie(SelectedPie);
            }
              await NavigationService.PopAsync();
        }

       
    }
}
