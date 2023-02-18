using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZYGD.Extensions;

namespace ZYGD.ViewModels
{
   public class LoginViewModel : BindableBase, IDialogAware
    {
        private LogHelper _logHelper;
        //private YamlHelper _yamlHelper;

        private IEventAggregator _eventAggregator;
        public DelegateCommand btn_Login { get; private set; }
        public DelegateCommand btn_Close { get; private set; }
        public string Title => "消息框";

        private string remind;
        public string Remind { get { return remind; } set { remind = value; RaisePropertyChanged(); } }
        private string username;
        public string Username { get { return username; } set { username = value; RaisePropertyChanged(); } }
        private string password;

        public event Action<IDialogResult> RequestClose;

        public string Password { get { return password; } set { password = value; RaisePropertyChanged(); } }


        public LoginViewModel(IEventAggregator ea)
        {
            _eventAggregator = ea;

            _logHelper = new LogHelper(_eventAggregator);
            _logHelper.LogInit();



            Username = "Enna1";
            password = "123456";



            btn_Login = new DelegateCommand(LoginFun);
            btn_Close = new DelegateCommand(CloseFun);
        }


        private void LoginFun()
        {


            bool temp1 = ParameterCheck.IsValidDecimal("124444443.4544444446");
            bool temp2 = ParameterCheck.IsValidInteger("123.777");
            bool temp3 = ParameterCheck.IsValidInteger("123");
            bool temp4 = ParameterCheck.IsValidBoolean("True");
            bool temp5 = ParameterCheck.IsValidBoolean("False");

            _logHelper.Info("登录系统");
            RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
            //if (UserManagement.CheckUser(Username, Password))
            //{
            //    _logHelper.Info("登录系统");
            //    RequestClose?.Invoke(new DialogResult(ButtonResult.OK));
            //}
            //else
            //{

            //    Remind = "用户名或密码错误";
            //}

        }
        private void CloseFun()
        {
            _logHelper.Info("退出登录");
            RequestClose?.Invoke(new DialogResult(ButtonResult.No));
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
           
        }
    }
}
