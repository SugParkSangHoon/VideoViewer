﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using 영상뷰어.enums;
using 영상뷰어.Interfaces;
using 영상뷰어.Models;
using 영상뷰어.Services;

namespace 영상뷰어.ViewModels
{
    //Test
    [POCOViewModel]
    public class SateliteAPISettingsViewModel : ViewModelBase
    {
        private readonly ISettingService _settingServices;
        //private eCameraType _cameraType;
        //private eCameraArea _cameraArea;
        //private bool _isSelect;                
        //public bool IsSelected
        //{
        //    get { return _isSelect; }
        //    set { _isSelect = value; RaisePropertyChanged("IsSelected"); }
        //}
        //public eCameraType CameraType
        //{
        //    get { return _cameraType; }
        //    set {
        //        _settingServices.SeteliteAPISetting.CameraType = value; 
        //        SetValue(ref _cameraType, value);
        //    }
        //}
        public virtual bool IsSelected { get; set; }    
        public virtual eCameraType CameraType { get; set; }
        public virtual eCameraArea CameraArea { get; set; }
        public virtual DateTime YesterdayDateTIme { get; set; } 
        //public eCameraArea CameraArea
        //{
        //    get => _settingServices.SeteliteAPISetting.CameraArea;
        //    set
        //    {
        //        _settingServices.SeteliteAPISetting.CameraArea = value;
        //        SetValue(ref _cameraArea, value);
        //    }
        ////}
        //private DateTime _yesterdayDateTime; 
        //public DateTime YesterdayDateTIme
        //{
        //    get => _yesterdayDateTime;
        //    set {
        //        _yesterdayDateTime = value; 
        //        RaisePropertyChanged("YesterdayDateTIme");
        //        _settingServices.SeteliteAPISetting.Datetime = value.ToString("yyyyMMdd");                
        //    }
        //}
        public SateliteAPISettingsViewModel(ISettingService settingservice)
        {
            _settingServices = settingservice;
            CameraType = _settingServices.SeteliteAPISetting.CameraType;
            CameraArea = _settingServices.SeteliteAPISetting.CameraArea;
            YesterdayDateTIme = DateTime.ParseExact(_settingServices.SeteliteAPISetting.Datetime,"yyyyMMdd", CultureInfo.InvariantCulture); 
        }

        #region Requset Command

        /// <summary>
        /// myCommand
        /// </summary>
        //private DelegateCommand myCommand = null;

        ///// <summary>
        ///// Get Requset
        ///// </summary>
        //public ICommand Requset 
        //{
        //    get
        //    {
        //        if (this.myCommand == null)
        //        {
        //            this.myCommand = new DelegateCommand(() => this.OnRequset());
        //        }

        //        return this.myCommand;
        //    }
        //}
        //#endregion

        //#region OnRequset
        /// <summary>
        /// execute OnRequset
        /// </summary>
        public virtual async void OnRequset()
        {
            ObservableCollection<SatelliteData> SateliteDataList = new ObservableCollection<SatelliteData>();
            //SateliteAPIService APIService = new SateliteAPIService(_settingServices);
            //var data = await APIService.ResponseAPI();
            //SateliteJSONParsingService jsonParsing = new SateliteJSONParsingService(data);
            //var fileList = await jsonParsing.DownLoadIMage();            
            //foreach (var file in fileList)
            //{

            //    SatelliteData model = new SatelliteData();
            //    model.FileCreateDate = DateTime.Now;
            //    model.FilePath = file;
            //    model.UserID = "Park";
            //    model.SatelliteArea = _settingServices.SeteliteAPISetting.CameraArea.ToString();
            //    model.SatelliteType = _settingServices.SeteliteAPISetting.CameraType.ToString();
            //   // SateliteDataList.Add(model);
            //}

            SateliteDataList.Add(new SatelliteData
            {
                NumberID = 1,
                FileCreateDate = DateTime.Now,
                FilePath = @"C\data\dd.jpg",
                SatelliteArea = "test",
                SatelliteType = "Phone",
                UserID = "Park"
            }); ;
            Messenger.Default.Send(SateliteDataList);            

        }

        #endregion
    }
}
