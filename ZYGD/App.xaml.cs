using Prism.DryIoc;
using Prism.Ioc;
using Prism.Services.Dialogs;
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
            containerRegistry.RegisterDialog<LoginView, LoginViewModel>("LoginView");
            containerRegistry.RegisterDialog<DialogView, DialogViewModel>("DialogView");
        }


        private static System.Threading.Mutex mutex;
        protected override void OnStartup(StartupEventArgs e)
        {
            mutex = new System.Threading.Mutex(true, "OnlyRun_CRNS");
            if (mutex.WaitOne(0, false))
            {
                base.OnStartup(e);
            }
            else
            {
                MessageBox.Show("程序已经在运行！", "提示");
                this.Shutdown();
            }

        }


        IDialogParameters parameters { get; set; }
        IDialogService dialog;
        protected override void OnInitialized()
        {
            dialog = Container.Resolve<IDialogService>();

            dialog.ShowDialog("LoginView", parameters, Callback);
        }


        private void Callback(IDialogResult result)
        {

            if (result.Result == ButtonResult.OK)
            {
                //给主窗体传值
                base.OnInitialized();
                //return;
            }
            else
            {

                Environment.Exit(0);

            }

        }
    }
}
