﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainRingGame.Ui.Wpf.Common.Recourses.ViewModel.Base
{
    public class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;

            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected ViewModelBase()
        {
        }

        public void Dispose()
        {
            this.OnDispose();
        }
        protected virtual void OnDispose()
        {
        }

    }
}
