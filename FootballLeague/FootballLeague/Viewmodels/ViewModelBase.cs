using FootballLeague.Core;
using FootballLeague.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Viewmodels
{
    public abstract class ViewModelBase : ObservableObject
    {
        private INavigationService _navigationService;

        public INavigationService NavigationService
        {
            get { return _navigationService; }
            set { _navigationService = value; OnPropertyChanged(); }
        }
    }
}
