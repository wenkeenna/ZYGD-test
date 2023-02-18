using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZYGD.Common;

namespace ZYGD.ViewModels
{
    class ContralCardViewModel : BindableBase
    {
        public IEventAggregator _eventAggregator;
        private IDialogService _dialogService;
        public DelegateCommand<string> btnCommand { get; private set; }

        private ObservableCollection<AxisParameter> axisparas;
        public ObservableCollection<AxisParameter> AxisParas
        {
            get { return axisparas; }
            set { axisparas = value; RaisePropertyChanged(); }
        }

        public ContralCardViewModel(IEventAggregator ea, IDialogService dialogService)
        {
            _eventAggregator = ea;
            _dialogService = dialogService;
            btnCommand = new DelegateCommand<string>(btnFun);
            AxisParas =new ObservableCollection<AxisParameter>();

            AxisParas.Add(new AxisParameter() { Name = "A1", ID = 001, Speed = 1000, Acc = 100, Dec = 100 });
            AxisParas.Add(new AxisParameter() { Name = "A2", ID = 001, Speed = 1000, Acc = 100, Dec = 100 });
            AxisParas.Add(new AxisParameter() { Name = "A3", ID = 001, Speed = 1000, Acc = 100, Dec = 100 });
            AxisParas.Add(new AxisParameter() { Name = "A4", ID = 001, Speed = 1000, Acc = 100, Dec = 100 });


        }
        private void btnFun(object obj)
        {
           
        }
    }
}
