using MauiAvondLes07.Models;
using MauiAvondLes07.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAvondLes07.ViewModels
{
    public class PieOverviewViewModel : BaseViewModel
    {
        private ObservableCollection<Pie> _pies;
        private IPieRepository _pieRepository;

        public ICommand LoadCommand { get;  }
        public ICommand AddCommand { get; }
       

        public ICommand PieSelectedCommand { get; }

        public PieOverviewViewModel(IPieRepository pieRepository)
        {
           
           
            _pieRepository = pieRepository;

            LoadCommand = new Command(OnLoadCommand);
            AddCommand = new Command(OnAddCommand);
            PieSelectedCommand = new Command<Pie>(OnPieSelectedCommand);
        }

        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set { _pies = value;
               // OnPropertyChanged(nameof(Pies));
                //[CallerMemberName] toevoegen en nameof niet nodig
                OnPropertyChanged();
            }
        }

        private void OnLoadCommand()
        {
            Pies = new ObservableCollection<Pie>(_pieRepository.GetAllPies());
        }
        private void OnAddCommand()
        {

        }
       
        private void OnPieSelectedCommand(Pie taart)
        {

        }
    }
}
