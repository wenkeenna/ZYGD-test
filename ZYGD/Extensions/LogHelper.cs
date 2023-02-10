using log4net.Config;
using log4net;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Repository.Hierarchy;
using ZYGD.Events;


namespace ZYGD.Extensions
{
    class LogHelper
    {
        public LogHelper(IEventAggregator ea)
        {
            _eventAggregator = ea;
        }
        private readonly IEventAggregator _eventAggregator;
        static ILog loger = null;

        //日志类初始化（读取配置文件）
        public void LogInit()
        {
            XmlConfigurator.Configure(new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log4NetConfig.Config")));
            loger = LogManager.GetLogger(typeof(Logger));
            loger.Info("系统初始化Logger模块");
            _eventAggregator.GetEvent<Event_LogMessage>().Publish("系统初始化Logger模块");
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public void Error(string msg = "出现异常", Exception ex = null)
        {

            loger.Error(msg, ex);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Warn(string msg)
        {

            loger.Warn(msg);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Info(string msg)
        {

            loger.Info(msg);
            _eventAggregator.GetEvent<Event_LogMessage>().Publish(msg);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Debug(string msg)
        {

            loger.Debug(msg);
        }
    }
}
