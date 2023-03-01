using System.Windows;
using System.Windows.Controls;

namespace 영상뷰어.Styles
{
    /// <summary>
    /// PlaceHolderTextBox.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PlaceHolderTextBox : UserControl
    {
        public string TextBoxValue
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public string TextBoxHintText
        {
            get { return (string)GetValue(HitTextProperty); }
            set { SetValue(HitTextProperty, value); }
        }
        public PlaceHolderTextBox()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register(
            nameof(TextBoxValue),
            typeof(string),
            typeof(PlaceHolderTextBox),
            new PropertyMetadata(default(string)));

        public static readonly DependencyProperty HitTextProperty =
            DependencyProperty.Register(
                nameof(TextBoxHintText),
                typeof(string),
                typeof(PlaceHolderTextBox),
                new PropertyMetadata(default(string)));
    }
}
