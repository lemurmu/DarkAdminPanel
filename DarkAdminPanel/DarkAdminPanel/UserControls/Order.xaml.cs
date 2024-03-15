using FontAwesome.Sharp;
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

namespace DarkAdminPanel.UserControls
{
    /// <summary>
    /// Order.xaml 的交互逻辑
    /// </summary>
    public partial class Order : UserControl
    {
        public Order() {
            InitializeComponent();
        }



        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Order), new PropertyMetadata(""));


        public string Des {
            get { return (string)GetValue(DesProperty); }
            set { SetValue(DesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Des.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DesProperty =
            DependencyProperty.Register("Des", typeof(string), typeof(Order), new PropertyMetadata(""));

        public IconChar Icon {
            get { return (IconChar)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(IconChar), typeof(Order));


    }
}
