using System;
using System.Threading.Tasks;

namespace BaseXamarinFormsProject.Services
{
	public interface IWebService
	{
        Task<T> GetAsync<T>(string method);
        Task<T> PostAsync<T>(object body, string method);
    }
}

