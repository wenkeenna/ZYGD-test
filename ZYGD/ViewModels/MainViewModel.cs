using Prism.Commands;
using Prism.Events;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ZYGD.Common;
using ZYGD.Extensions;

namespace ZYGD.ViewModels
{
    class MainViewModel: BindableBase
    {
        public MainViewModel(IRegionManager regionManager, IContainerExtension containerExtension, IEventAggregator ea)
        {
            this._regionManager = regionManager;
            _containerExtension = containerExtension;
            NavigateCommand = new DelegateCommand<string>(Navigate);
            



        }
       private Dictionary<string, string> _Menu;
        
        private IContainerExtension? _containerExtension;
      
        private readonly IRegionManager _regionManager;
        public DelegateCommand<string> NavigateCommand{ get; private set; }
      

        private void Navigate(string obj)
        {
            if (obj == null || string.IsNullOrWhiteSpace(obj))
                return;


            _regionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(obj);

        }
      

        //void CreateMenuBar()
        //{
        //    MenuBars.Add(new MenuBar() { Title = "主    页", Icon = "Home", NameSpace = "HomeView" });
        //    MenuBars.Add(new MenuBar() { Title = "手    动", Icon = "GestureTap", NameSpace = "ManualView" });
        //    MenuBars.Add(new MenuBar() { Title = "相机参数", Icon = "Camera", NameSpace = "CameraView" });
        //    MenuBars.Add(new MenuBar() { Title = "板卡参数", Icon = "Cog", NameSpace = "ContralCardView" });
        //    MenuBars.Add(new MenuBar() { Title = "检测参数", Icon = "TabSearch", NameSpace = "InspectView" });

        //}
    }
}
