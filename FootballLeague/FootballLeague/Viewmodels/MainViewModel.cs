using FootballLeague.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Viewmodels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            NavigationService.NavigateTo<LoginViewModel>();
        }
    }
}
