﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Prism.Navigation;
using Prism.Services;

namespace Igry.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
