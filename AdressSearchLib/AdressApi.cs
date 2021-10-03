using Dadata;
using Dadata.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdressSearchLib
{
    public static class AdressApi
    {
        private const string _token = "f6f86b3c58c844cca33619a502aed8442ba40a67";
        private const string _secret = "fcdd432b179932a6763d7d199a0c7441c8c1c5a6";
        public static async Task<IList<Suggestion<Address>>> GetSuggestionAdresses(string adress)
{
            var api = new SuggestClientAsync(_token);
            var result = await api.SuggestAddress(adress);
            return result.suggestions;
        }
        public static Address GetInfoByAdress(string adress)
        { 
            var api = new CleanClient(_token, _secret);
            var result = api.Clean<Address>(adress);
            return result;
        }
    }
}
