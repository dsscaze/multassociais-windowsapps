﻿using Caliburn.Micro;

namespace MultasSociais.WinStoreApp.ViewModels
{
    public abstract class ViewModelBase : Screen
    {
        protected readonly INavigationService navigationService;
        private string parameter;

        protected ViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public void GoBack()
        {
            navigationService.GoBack();
        }

        public bool CanGoBack
        {
            get
            {
                return navigationService.CanGoBack;
            }
        }

        public string Parameter
        {
            get { return parameter; }
            set
            {
                parameter = value;
                BeforeInitialize();
            }
        }

        protected virtual void BeforeInitialize()
        {
        }
    }
}