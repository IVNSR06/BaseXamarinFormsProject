using System;
using BaseXamarinFormsProject.Services;

namespace BaseXamarinFormsProject.ViewModels
{
	public class MainPageViewModel : BaseViewModel
	{
		public MainPageViewModel(IWebService webService, INavigationService navigationService) : base(webService, navigationService)
		{
		}
	}
}

