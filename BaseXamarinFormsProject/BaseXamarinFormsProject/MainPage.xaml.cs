using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseXamarinFormsProject.ViewModels;
using Xamarin.Forms;

namespace BaseXamarinFormsProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = App.ServiceProvider.GetService(typeof(MainPageViewModel));
        }
    }
}

