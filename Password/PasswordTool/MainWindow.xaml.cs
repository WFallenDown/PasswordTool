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

namespace PasswordTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            #region Ellipse

            Ellipse ellipse1 = new Ellipse();
            Ellipse ellipse2 = new Ellipse();

            ellipse1.Height = 300;
            ellipse1.Width = 300;
            ellipse1.Stroke = Brushes.Black;
            ellipse1.HorizontalAlignment = HorizontalAlignment.Left;
            ellipse1.Margin = new Thickness(290, 0, 0, 0);
            ellipse1.VerticalAlignment = VerticalAlignment.Center;

            ellipse2.Height = 200;
            ellipse2.Width = 200;
            ellipse2.Stroke = Brushes.Black;
            ellipse2.HorizontalAlignment = HorizontalAlignment.Left;
            ellipse2.Margin = new Thickness(340, 0, 0, 0);
            ellipse2.VerticalAlignment = VerticalAlignment.Center;

            mainpage.Children.Add(ellipse1);
            mainpage.RegisterName("ellipse1", ellipse1);
            mainpage.Children.Add(ellipse2);
            mainpage.RegisterName("ellipse2", ellipse2);
            #endregion

            #region Separator

            double number = 0;

            for (int i = 0; i < 13; i++)
            {
                Separator separator = new Separator();
                separator.RenderTransform = new RotateTransform(number);
                separator.Width = 300;
                separator.Height = 1;
                separator.Margin = new Thickness(290, 0, 0, 0);
                separator.HorizontalAlignment = HorizontalAlignment.Left;
                separator.RenderTransformOrigin = new Point(0.5, 0.5);
                separator.VerticalAlignment = VerticalAlignment.Center;

                mainpage.Children.Add(separator);
                mainpage.RegisterName("separator" + i, separator);
                number += 13.8;
            }

            #endregion

            #region text

            var r = 80;
            double j = 0;
            for (int i = 0; i < 26; i++)
            {
                TextBlock text = new TextBlock();
                text.Name = "text" + i;

                double dd = Math.PI / 180 * j;
                double x = 440 + r * Math.Cos(dd);
                double y = 210 + r * Math.Sin(dd);
                text.Margin = new Thickness(x, y, 0, 0);
                text.Text = "B";
                j += 13.8;
                

                mainpage.Children.Add(text);
                mainpage.RegisterName("text" + i, text);
            }

            #endregion
        }

        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
