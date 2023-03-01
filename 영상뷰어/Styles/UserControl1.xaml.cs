using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 영상뷰어.Styles
{
    /// <summary>
    /// UserControl1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
        }
        public static readonly DependencyProperty kWValueProperty = DependencyProperty.Register(
       "kWValue", typeof(string), typeof(UserControl1), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));   


        public string kWValue
        {
            get { return (string)GetValue(kWValueProperty); }
            set { SetValue(kWValueProperty, value); }
        }
    }
}
