using MauiAvondLes07.Models;
using MauiAvondLes07.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiAvondLes07.ViewModels
{
    public class PieDetailViewModel : BaseViewModel
    {
        private Pie _selectedPie;
        private IPieRepository _pieRepository;

        public ICommand SaveCommand { get; }

        public PieDetailViewModel(IPieRepository pieRepository)
        {
            _selectedPie = new Pie();
            _pieRepository = pieRepository;
            SaveCommand = new Command(OnSaveCommand);

        }
        public Pie SelectedPie
        {
            get { return _selectedPie; }
            set { _selectedPie = value; 
                    OnPropertyChanged(nameof(_selectedPie));
                    }
        }
        private void OnSaveCommand()
        {

        }
    }
}
