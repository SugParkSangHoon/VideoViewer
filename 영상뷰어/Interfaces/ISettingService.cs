using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Services.Setting;

namespace 영상뷰어.Interfaces
{
    public interface ISettingService
    {
        public SeteliteAPISetting SeteliteAPISetting { get; }
        public void SaveSetting();
    }
    public class SettingService : ISettingService
    {
        private SeteliteAPISetting? _seteliteAPISetting;
        public SettingService()
        {
            _seteliteAPISetting = new SeteliteAPISetting();
            this.DefaultSetting();
        }

        public SeteliteAPISetting? SeteliteAPISetting { get => _seteliteAPISetting; }

        public void SaveSetting()
        {
            throw new NotImplementedException();
        }
        private void DefaultSetting()
        {
            SeteliteAPISetting.CameraType = enums.eCameraType.sw038;
            SeteliteAPISetting.CameraArea = enums.eCameraArea.ko;
            SeteliteAPISetting.Datetime = DateTime.Now.AddDays(-1).ToString("yyyyMMdd");
        }

    }
}
