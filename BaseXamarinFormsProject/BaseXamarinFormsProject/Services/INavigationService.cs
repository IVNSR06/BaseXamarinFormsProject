using System;
using System.Threading.Tasks;
using BaseXamarinFormsProject.ViewModels;

namespace BaseXamarinFormsProject.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync<TViewModel>() where TViewModel : BaseViewModel;

        Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : BaseViewModel;
    }
}

