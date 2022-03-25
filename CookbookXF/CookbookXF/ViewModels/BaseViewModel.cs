using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;

namespace CookbookXF.ViewModels
{
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //izbaci konstruktor
        //public BaseViewModel(string title)
        //{
        //    Title = title; 
        //}

        //private string _title;

        //public string Title
        //{
        //    get => _title;
        //    set 
        //    {
        //        if (_title == value)
        //        {
        //            return;
        //        }

        //        _title = value;

        //        OnePropertyChanged();
        //    }
        //}

        //private bool _isBusy;
        //public bool IsNotBusy => !IsBusy;

        //public bool IsBusy
        //{
        //    get { return _isBusy; }
        //    set 
        //    {
        //        if (_isBusy == value)
        //        {
        //            return;
        //        } 

        //        _isBusy = value;

        //        OnePropertyChanged();
        //        OnePropertyChanged(nameof(IsNotBusy));
        //    }
        //}

        ////internet connection
        //private HttpClient _httpClient;
        //protected HttpClient Client => _httpClient ?? (_httpClient = new HttpClient());


    }
}
