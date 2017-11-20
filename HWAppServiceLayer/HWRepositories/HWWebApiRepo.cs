using HWAppInterfaces.HwRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HWAppServiceLayer.HwRepositories
{
    public class HwWebApiRepo : IHwRepository
    {
        private string _apiUri;
        private string _getHwCmd;

        public HwWebApiRepo(string ApiUri, string GetHwCmd)
        {
            _apiUri = ApiUri;
            _getHwCmd = GetHwCmd;
        }
            

        public string GetHelloWorld()
        {
            Task<string> callApi = MakeApiCall(_apiUri);

            callApi.Wait();
            string result = callApi.Result;

            return result;
        }


        private async Task<string> MakeApiCall(string ApiUri)
        {
            string result = string.Empty;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ApiUri);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage response = await client.GetAsync(_getHwCmd);
            if (response.IsSuccessStatusCode)
            {
                result= await response.Content.ReadAsAsync<string>();
            }

            return result;
        }
    }
}
