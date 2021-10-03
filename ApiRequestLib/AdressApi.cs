using System;
using System.Threading.Tasks;

namespace ApiRequestLib
{
    public class AdressApi
    {
        private string _url = "https://github.com/hflabs/dadata-csharp";
        private string _token = "f6f86b3c58c844cca33619a502aed8442ba40a67";
        public Task<string> GetAdresses(string adres)
        {
            var api =new SuggestClientAsync(_token);
        }
    }
}
