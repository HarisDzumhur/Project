using Football.Leagues.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Leagues.Service.Common
{
    public interface INavigationService
    {
        ViewModelBase CurrentView { get; }
        ViewModelBase CurrentContent { get; set; }

        void NavigateTo<T>() where T : ViewModelBase;
        void NavigateTo<T>(object parameters) where T : ViewModelBase;
        void NavigateToContent<T>() where T : ViewModelBase;
        void NavigateToContent<T>(object parameters) where T : ViewModelBase;
    }
}
