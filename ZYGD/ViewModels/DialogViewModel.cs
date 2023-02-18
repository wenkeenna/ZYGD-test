using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.ViewModels
{
    class DialogViewModel : IDialogAware
    {
        public string Title =>"";

        public event Action<IDialogResult> RequestClose;
        public string ShowMessage { get; set; }
        public DelegateCommand<object> ConfirmCommand { get; private set; }
        public DelegateCommand<object> CancelCommand { get; private set; }

        public DialogViewModel() 
        {
            ConfirmCommand = new DelegateCommand<object>(ConfirmFun);
            CancelCommand = new DelegateCommand<object>(CancelFun);
        }
        private void ConfirmFun(object obj)
        {
            IDialogParameters parameters = new DialogParameters();
            parameters.Add("key", "返回OK");
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK, parameters));
        }
        private void CancelFun(object obj)
        {
            IDialogParameters parameters = new DialogParameters();
            parameters.Add("key", "返回Cancel");
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel, parameters));
        }

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
           
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            ShowMessage = parameters.GetValue<string>("key");

        }
    }
}
