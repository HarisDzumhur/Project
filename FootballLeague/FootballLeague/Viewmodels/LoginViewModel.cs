using FootballLeague.Service;
using FootballLeague.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FootballLeague.Viewmodels
{
    public class LoginViewModel : ViewModelBase
    {
        public LoginViewModel(INavigationService navigationService) { NavigationService = navigationService; }

    }
}
