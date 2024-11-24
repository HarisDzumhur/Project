using FootballLeague.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Service.Interfaces
{
    public interface INavigationService
    {
        ViewModelBase CurrentView { get; }
        void NavigateTo<T>() where T : ViewModelBase;
        void NavigateTo<T>(object parameters) where T : ViewModelBase;
    }
}
