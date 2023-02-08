using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZYGD.ViewModels;
using ZYGD.Views;

namespace ZYGD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<HomeView, HomeViewModel>();
            containerRegistry.RegisterForNavigation<ManualView, ManualViewModel>();
            containerRegistry.RegisterForNavigation<CameraView, CameraViewModel>();
            containerRegistry.RegisterForNavigation<ContralCardView,ContralCardViewModel>();
            containerRegistry.RegisterForNavigation<InspectView, InspectViewModel>();
        }
    }
}
