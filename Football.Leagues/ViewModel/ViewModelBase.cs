using Football.Leagues.Core;
using Football.Leagues.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Leagues.ViewModel
{
    public abstract class ViewModelBase : ObservableObject
    {
        private INavigationService? _navigationService;

        public INavigationService? NavigationService
        {
            get => _navigationService;
            set { _navigationService = value; OnPropertyChanged(); }
        }
    }
}
