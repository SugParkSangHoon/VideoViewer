using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 영상뷰어.Services.Setting;
using 영상뷰어.Stores;

namespace 영상뷰어.Interfaces
{
    public interface ISettingService
    {
        public SeteliteAPISetting SeteliteAPISetting { get; }
        public AccountStore AccountStore { get; }
        public void SaveSetting();
    }
    public class SettingService : ISettingService
    {
        private readonly SeteliteAPISetting? _seteliteAPISetting;
        private readonly AccountStore? _accountStore;
        public SettingService()
        {
            _seteliteAPISetting = new SeteliteAPISetting();
            _accountStore = new AccountStore();
            this.DefaultSetting();
        }

        public SeteliteAPISetting? SeteliteAPISetting { get => _seteliteAPISetting; }
        public AccountStore AccountStore { get => _accountStore;  }
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
