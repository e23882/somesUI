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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OracleStudio
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            breatheLine();

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);
            InitializeComponent();
        }

        public void breatheLine()
        {
            DoubleAnimation fadeInOutAnimation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(1)
            };
            Storyboard storyboard = new Storyboard
            {
                Duration = TimeSpan.FromSeconds(2),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTarget(fadeInOutAnimation, cvCircle);
            Storyboard.SetTargetProperty(fadeInOutAnimation, new PropertyPath(Ellipse.OpacityProperty));
            storyboard.Children.Add(fadeInOutAnimation);
            cvCircle.BeginStoryboard(storyboard);


            DoubleAnimation da1 = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromSeconds(1)
            };
            Storyboard sb1 = new Storyboard
            {
                Duration = TimeSpan.FromSeconds(3),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTarget(da1, cvCircle1);
            Storyboard.SetTargetProperty(da1, new PropertyPath(Ellipse.OpacityProperty));
            sb1.Children.Add(da1);
            cvCircle1.BeginStoryboard(sb1);

            DoubleAnimation da2 = new DoubleAnimation()
            {
                From = 100,
                To = 2000,
                Duration = TimeSpan.FromSeconds(1)
            };
            Storyboard sb2 = new Storyboard
            {
                Duration = TimeSpan.FromSeconds(1),
                AutoReverse = true,
                RepeatBehavior = RepeatBehavior.Forever
            };
            Storyboard.SetTarget(da2, line);
            Storyboard.SetTargetProperty(da2, new PropertyPath(Line.WidthProperty));
            sb2.Children.Add(da2);
            line.BeginStoryboard(sb2);
        }
    }
}
