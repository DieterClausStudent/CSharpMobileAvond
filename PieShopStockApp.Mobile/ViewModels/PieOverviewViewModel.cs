using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using PieShopStockApp.Messages;
using PieShopStockApp.Models;
using PieShopStockApp.Services;
using PieShopStockApp.Utility;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PieShopStockApp.ViewModels
{
    public  partial class PieOverviewViewModel : BaseViewModel, IRecipient<PieMessage>
    {
        private ObservableCollection<Pie> _pies;
        private IPieRepository _pieRepository;

        //public ICommand LoadCommand { get; }
        //public ICommand AddCommand { get; }

        //public ICommand PieSelectedCommand { get; }

        public PieOverviewViewModel(IPieRepository pieRepository, INavigationService navigationService) : base(navigationService)
        {
            // Bij databinding moeten de Pies geïnitialiseerd worden. Indien null, werkt databinding niet!
            Pies = new ObservableCollection<Pie>();
            _pieRepository = pieRepository;

           //LoadCommand = new AsyncRelayCommand(OnLoadCommand);
            //AddCommand = new AsyncRelayCommand(OnAddCommand);
            //PieSelectedCommand = new AsyncRelayCommand<Pie>(OnPieSelectedCommand);

            WeakReferenceMessenger.Default.Register(this);
        }
        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged(nameof(Pies));
            }
        }

        [RelayCommand]
        public async Task Load()
        {
            Pies = new ObservableCollection<Pie>(await _pieRepository.GetAllPies());
        }

        [RelayCommand]
        public async Task Add()
        {
            await NavigationService.NavigateToAsync("PieDetailView");
        }

        [RelayCommand]
        public async Task PieSelected(Pie pie)
        {
            await NavigationService.NavigateToAsync("PieDetailView", new Dictionary<string, object>
            {
                { "selectedPie", pie }
            });
        }

        public async void Receive(PieMessage message)
        {
            if (message.Value == MessageNames.PieChanged)
            {
                Pies = new ObservableCollection<Pie>(await _pieRepository.GetAllPies());
            }
        }
    }
}
