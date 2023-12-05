using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PieShopStockApp.Models
{
    public partial class Pie : ObservableObject
    {
        public Guid Id { get; set; }
        // private Guid _id;
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

        //public Guid Id
        //{
        //    get => _id;
        //    set
        //    {
        //        _id = value;
        //        RaisePropertyChanged(nameof(Id));
        //    }
        //}

        //public string PieName
        //{
        //    get => _pieName;
        //    set
        //    {
        //        _pieName = value;
        //        RaisePropertyChanged(nameof(PieName));
        //    }
        //}

        //public string Description
        //{
        //    get => _description;
        //    set
        //    {
        //        _description = value;
        //        RaisePropertyChanged(nameof(Description));
        //    }
        //}

        //public double Price
        //{
        //    get => _price;
        //    set
        //    {
        //        _price = value;
        //        RaisePropertyChanged(nameof(Price));
        //    }
        //}

        //public string ImageUrl
        //{
        //    get => _imageUrl;
        //    set
        //    {
        //        _imageUrl = value;
        //        RaisePropertyChanged(nameof(ImageUrl));
        //    }
        //}

        //public bool InStock
        //{
        //    get => _inStock;
        //    set
        //    {
        //        _inStock = value;
        //        RaisePropertyChanged(nameof(InStock));
        //    }
        //}


        //public event PropertyChangedEventHandler PropertyChanged;

        //public void RaisePropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
