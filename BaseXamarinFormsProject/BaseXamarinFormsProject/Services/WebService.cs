using System;
using System.Threading.Tasks;
using BaseXamarinFormsProject.Helpers;
using Flurl;
using Flurl.Http;

namespace BaseXamarinFormsProject.Services
{
	public class WebService : IWebService
    {
        public async Task<T> GetAsync<T>(string method)
        {
            return await Constants.BaseURL.AppendPathSegment(method).GetJsonAsync<T>();
        }

        public async Task<T> PostAsync<T>(object body, string method)
        {
            return await Constants.BaseURL.WithHeader("Content-Type", "application/json").AppendPathSegment(method).PostJsonAsync(body).ReceiveJson<T>();
        }
    }
}

