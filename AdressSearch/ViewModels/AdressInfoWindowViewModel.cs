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
            get => this._city;
            set 
            {
                this._city = value;
                OnPropertyChanged();
            }

        }
        private string _fiasCity;
        public string FiasCity 
        {
            get => this._fiasCity;
            set
            {
                this._fiasCity = value;
                OnPropertyChanged();
            }
        }
        private string _fiasStreet;
        public string FiasStreet 
        {
            get => this._fiasStreet;
            set 
            {
                this._fiasStreet = value;
                OnPropertyChanged();
            }
        }
        private string _houseNumber;
        public string HouseNumber
        {
            get => this._houseNumber;
            set
            {
                this._houseNumber = value;
                OnPropertyChanged();
            }
        }
        private string _houseBuilding;
        public string HouseBuilding
        {
            get => this._houseBuilding;
            set 
            {
                this._houseBuilding = value;
                OnPropertyChanged();
            }
        }
        private string _fiasHouse;
        public string FiasHouse
        {
            get => this._fiasHouse;
            set 
            {
                this._fiasHouse = value;
                OnPropertyChanged();
            }
        }
        private string _geoHouseLat;
        public string GeoHouseLat
        {
            get => this._geoHouseLat;
            set
            {
                this._geoHouseLat = value;
                OnPropertyChanged();
            }
        }
        private string _geoHouseLon;
        public string GeoHouseLon
        {
            get => this._geoHouseLon;
            set
            {
                this._geoHouseLon = value;
                OnPropertyChanged();
            }
        }
        private string _floorNumber;
        public string FloorNumber
        {
            get => this._floorNumber;
            set
            {
                this._floorNumber = value;
                OnPropertyChanged();
            }
        }
        private string _entranceNumber;
        public string EntranceNumber
        {
            get => this._entranceNumber;
            set
            {
                this._entranceNumber = value;
                OnPropertyChanged();
            }
        }
        public AdressInfoWindowViewModel(Suggestion<Address> adress)
        {
            var adressInfo = AdressApi.GetInfoByAdress(adress.value);
            City = adress.data.city ?? "Нет";
            FiasCity = adress.data.city_fias_id ?? "Нет";
            FiasStreet = adressInfo.street_fias_id ?? "Нет";
            HouseNumber = adressInfo.house ?? "Нет";
            HouseBuilding = adressInfo.block ?? "Нет";
            FiasHouse = adressInfo.house_fias_id ?? "Нет";
            GeoHouseLat = adressInfo.geo_lat ?? "Нет";
            GeoHouseLon = adressInfo.geo_lon ?? "Нет";
            FloorNumber = adressInfo.floor ?? "Нет";
            EntranceNumber = adressInfo.entrance ?? "Нет";

        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
