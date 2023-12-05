using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using PieShopStockApp.Messages;
using PieShopStockApp.Models;
using PieShopStockApp.Services;
using PieShopStockApp.Utility;
using PieShopStockApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PieShopStockApp.ViewModels
{
   public partial class PieOverviewViewModel : BaseViewModel, IRecipient<PieMessage>
    {
        private ObservableCollection<Pie> _pies;
        private IPieRepository _pieRepository;
       // public ICommand LoadCommand { get; }
       // public ICommand AddCommand { get; }
        //public ICommand PieSelectedCommand { get; }
        public PieOverviewViewModel(IPieRepository pieRepository, INavigationService navigationService) : base(navigationService)
        {
            Pies = new ObservableCollection<Pie>();
            _pieRepository = pieRepository;
          //  LoadCommand = new AsyncRelayCommand(OnLoadCommand);
           // AddCommand = new AsyncRelayCommand(OnAddCommand);
           // PieSelectedCommand = new AsyncRelayCommand<Pie>(OnPieSelectedCommand);
            WeakReferenceMessenger.Default.Register(this);
        }

        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                //OnPropertyChanged(nameof(Pies));
                OnPropertyChanged();
            }
        }
        [RelayCommand]
        public async Task Load()
        {
            //in xaml code moet LoadCommand staan !!!!!!!!
            Pies = new ObservableCollection<Pie>(_pieRepository.GetAllPies());
        }
        [RelayCommand]
        public async Task Add()
        {
            await NavigationService.NavigateToAsync(nameof(PieDetailView));
        }
        [RelayCommand]
        public async Task PieSelect(Pie pie)
        {
            await NavigationService.NavigateToAsync(nameof(PieDetailView), new Dictionary<string, object>
            {
                { "SelectedPie", pie }
            });

        }

        public void Receive(PieMessage message)
        {
           if(message.Value == MessageNames.PieChangedMessage)
            {
                Pies = new ObservableCollection<Pie>(_pieRepository.GetAllPies());
            }
        }
    }
}
