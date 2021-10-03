using AdressSearchLib;
using Dadata.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace AdressSearch.ViewModels
{
    public class AdressSearchWindowViewModel : INotifyPropertyChanged
    {
        private bool _isDropDownListOpen;
        public bool IsDropDownListOpen
        {
            get => _isDropDownListOpen;
            set
            {
                _isDropDownListOpen = value;
                OnPropertyChanged();
            }
        }
        private DispatcherTimer timer;
        public Action<Suggestion<Address>> ShowAdressInfoWindowAction { get; set; }
        public ObservableCollection<Suggestion<Address>> SuggestionAdresses { get; set; }
        private Suggestion<Address> _selectedAdress;
        public Suggestion<Address> SelectedAdress
        {
            get => _selectedAdress;
            set
            {
                _selectedAdress = null;
                OnPropertyChanged();
                if(value != null)
                {
                    this.ShowAdressInfoWindowAction(value);
                }
            }
        }
        private string adress;
        public string Adress {
            get => adress;
            set
            {
                adress = value;
                OnPropertyChanged();
                TimerStart(value);
            } 
        }
        private void TimerStart(string value)
        {
            if(timer != null)
                timer.Stop();

            timer = new DispatcherTimer();
            timer.Tick += (s, args) =>
            {
                GetSuggestAdress(value);
                timer.Stop();
            };
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Start();
        }
        private async Task GetSuggestAdress(string value)
        {
            var result = await AdressApi.GetSuggestionAdresses(value);
            this.SuggestionAdresses.Clear();
            foreach(var item in result)
            {
                SuggestionAdresses.Add(item);
            }
            if(this.SuggestionAdresses.Count > 0)
            {
                IsDropDownListOpen = true;
            }
            else
            {
                IsDropDownListOpen = false;
            }
        }

        public AdressSearchWindowViewModel()
        {
            this.SuggestionAdresses = new ObservableCollection<Suggestion<Address>>();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
