using Prism.Events;
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
using ZYGD.Events;

namespace ZYGD.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        private IEventAggregator _eventAggregator;
        public MainView(IEventAggregator ea)
        {
            InitializeComponent();

            _eventAggregator = ea;

            BtnMin.Click += (s, e) => { this.WindowState = WindowState.Minimized; };
            BtnMax.Click += (s, e) =>
            {
                if (this.WindowState == WindowState.Maximized)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Maximized;
            };
            BtnClose.Click += async (s, e) =>
            {

                this.Close();
                System.Environment.Exit(0);
            };

            TitleBorder.MouseMove += (s, e) =>
            {
                if (e.LeftButton == MouseButtonState.Pressed)
                    this.DragMove();
            };
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _eventAggregator.GetEvent<Event_Window_Loaded>().Publish("HomeView");
        }
    }
}
