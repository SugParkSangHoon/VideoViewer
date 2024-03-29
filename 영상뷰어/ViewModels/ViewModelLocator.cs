﻿using DevExpress.Mvvm.POCO;
using Microsoft.Extensions.DependencyInjection;

namespace 영상뷰어.ViewModels
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => (MainViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(MainViewModel)));
        public SateliteAPISettingsViewModel SateliteAPISettingsViewModel => (SateliteAPISettingsViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(SateliteAPISettingsViewModel)));
        public SateliteAPIResultViewModel SateliteAPIResultViewModel => (SateliteAPIResultViewModel)App.ServiceProvider.GetRequiredService(ViewModelSource.GetPOCOType(typeof(SateliteAPIResultViewModel)));
        
    }
}
