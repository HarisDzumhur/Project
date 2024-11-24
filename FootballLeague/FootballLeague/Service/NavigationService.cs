﻿using FootballLeague.Core;
using FootballLeague.Service.Interfaces;
using FootballLeague.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Service
{
    public class NavigationService : ObservableObject, INavigationService
    {
        private ViewModelBase _currentView;
        public ViewModelBase CurrentView
        {
            get => _currentView!;
            set { _currentView = value; OnPropertyChanged(); }
        }

        private readonly Func<Type, ViewModelBase> _viewModelFactory;


        public NavigationService(Func<Type, ViewModelBase> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
        {
            var viewModel = _viewModelFactory(typeof(TViewModel));

            if (viewModel is IHandleParameters handleParameters)
            {
                handleParameters.HandleParameters(null);
            }

            CurrentView = viewModel;
        }
        public void NavigateTo<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            var viewModel = _viewModelFactory(typeof(TViewModel));

            if (viewModel is IHandleParameters handleParameters)
            {
                handleParameters.HandleParameters(parameter);
            }

            CurrentView = viewModel;
        }
    }
}
