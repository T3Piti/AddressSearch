using AdressSearchLib;
using Dadata.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdressSearch.ViewModels
{
    public class AdressInfoWindowViewModel : INotifyPropertyChanged
    {
        private string _city;
        public string City 
        {
            get => _city;
            set 
            {
                _city = value;
                OnPropertyChanged();
            }

        }
        private string _fiasCity;
        public string FiasCity 
        {
            get => _fiasCity;
            set
            {
                _fiasCity = value;
                OnPropertyChanged();
            }
        }
        private string _fiasStreet;
        public string FiasStreet 
        {
            get => _fiasStreet;
            set 
            {
                _fiasStreet = value;
                OnPropertyChanged();
            }
        }
        private string _houseNumber;
        public string HouseNumber
        {
            get => _houseNumber;
            set
            {
                _houseNumber = value;
                OnPropertyChanged();
            }
        }
        private string _houseBuilding;
        public string HouseBuilding
        {
            get => _houseBuilding;
            set 
            {
                _houseBuilding = value;
                OnPropertyChanged();
            }
        }
        private string _fiasHouse;
        public string FiasHouse
        {
            get => _fiasHouse;
            set 
            {
                _fiasHouse = value;
                OnPropertyChanged();
            }
        }
        private string _geoHouseLat;
        public string GeoHouseLat
        {
            get => _geoHouseLat;
            set
            {
                _geoHouseLat = value;
                OnPropertyChanged();
            }
        }
        private string _geoHouseLon;
        public string GeoHouseLon
        {
            get => _geoHouseLon;
            set
            {
                _geoHouseLon = value;
                OnPropertyChanged();
            }
        }      
        public AdressInfoWindowViewModel(Suggestion<Address> adress)
        {
            FillAdressInfo(adress).Wait();
        }

        private async Task FillAdressInfo(Suggestion<Address> adress)
        {
            var adressInfo = await AdressApi.GetInfoByAdress(adress.value);
            City = adressInfo.city != null ? adressInfo.city : "Нет";
            FiasCity = adressInfo.city_fias_id != null ? adressInfo.city_fias_id : "Нет";
            FiasStreet = adressInfo.street_fias_id != null ? adressInfo.street_fias_id : "Нет";
            HouseNumber = adressInfo.house != null ? adressInfo.house : "Нет";
            HouseBuilding = adressInfo.block != null ? adressInfo.block : "Нет";
            FiasHouse = adressInfo.house_fias_id != null ? adressInfo.house_fias_id : "Нет";
            GeoHouseLat = adressInfo.geo_lat != null ? adressInfo.geo_lat : "Нет";
            GeoHouseLon = adressInfo.geo_lon != null ? adressInfo.geo_lon : "Нет";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
