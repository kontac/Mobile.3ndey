﻿using MvvmCross.Core.ViewModels;

namespace Mobile._3ndey.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        private string _title;
        private bool _isBusy;

        public BaseViewModel()
        {
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }
    }
}
