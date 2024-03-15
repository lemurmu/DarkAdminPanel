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
    /// InfoCard.xaml 的交互逻辑
    /// </summary>
    public partial class InfoCard : UserControl
    {
        public InfoCard() {
            InitializeComponent();
        }



        public string Title {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(InfoCard), new PropertyMetadata(""));



        public string Number {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Number.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberProperty =
            DependencyProperty.Register("Number", typeof(string), typeof(InfoCard), new PropertyMetadata(""));


        public IconChar Icon {
            get { return (IconChar)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Icon.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(IconChar), typeof(InfoCard));


        public Color Background1 {
            get { return (Color)GetValue(Background1Property); }
            set { SetValue(Background1Property, value); }
        }

        // Using a DependencyProperty as the backing store for Background1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Background1Property =
            DependencyProperty.Register("Background1", typeof(Color), typeof(InfoCard), new PropertyMetadata(Color.FromRgb(0xff, 0xff, 0xff)));



        public Color Background2 {
            get { return (Color)GetValue(Background2Property); }
            set { SetValue(Background2Property, value); }
        }

        // Using a DependencyProperty as the backing store for Background2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Background2Property =
            DependencyProperty.Register("Background2", typeof(Color), typeof(InfoCard), new PropertyMetadata(Color.FromRgb(0xff, 0xff, 0xff)));


        public Color EllipseBackground1 {
            get { return (Color)GetValue(EllipseBackground1Property); }
            set { SetValue(EllipseBackground1Property, value); }
        }

        // Using a DependencyProperty as the backing store for EllipseBackground1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EllipseBackground1Property =
            DependencyProperty.Register("EllipseBackground1", typeof(Color), typeof(InfoCard), new PropertyMetadata(Color.FromRgb(0xff, 0xff, 0xff)));

        public Color EllipseBackground2 {
            get { return (Color)GetValue(EllipseBackground2Property); }
            set { SetValue(EllipseBackground2Property, value); }
        }

        // Using a DependencyProperty as the backing store for EllipseBackground2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EllipseBackground2Property =
            DependencyProperty.Register("EllipseBackground2", typeof(Color), typeof(InfoCard), new PropertyMetadata(Color.FromRgb(0xff, 0xff, 0xff)));


    }
}
