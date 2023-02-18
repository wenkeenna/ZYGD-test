using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.Motion
{
    interface IMotionControl
    {
        /// <summary>
        /// 打开控制卡
        /// </summary>
        void Open();
        /// <summary>
        /// 关闭控制卡
        /// </summary>
        void Close();
        /// <summary>
        /// 绝对值运动
        /// </summary>
        /// <param name="axisNumber">轴号</param>
        /// <param name="pos">位置</param>
        /// <param name="vel">速度</param>
        /// <returns></returns>
        Task MoveAbsolute(int axisNumber, int pos, int vel);
        /// <summary>
        /// 相对位置运动
        /// </summary>
        void MoveRelative();
        /// <summary>
        /// 回原点
        /// </summary>
        /// <param name="axisnumber"></param>
        /// <returns></returns>
        Task Home(int axisnumber);
        /// <summary>
        /// 设置IO
        /// </summary>
        /// <param name="number"></param>
        /// <param name="state"></param>
        void SetIO(int number, short state);
        /// <summary>
        /// 获取IO
        /// </summary>
        /// <param name="InputANDOutput"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        bool GetIO(string InputANDOutput, int number);
        /// <summary>
        /// Jog运动
        /// </summary>
        /// <param name="axisNumber">轴号</param>
        /// <param name="vel">速度</param>
        void JOG(int axisNumber, int vel);
        /// <summary>
        /// 停止轴运动
        /// </summary>
        /// <param name="axisNumber"></param>
        void Stop(int axisNumber);
        /// <summary>
        /// 获取全部轴编码器值
        /// </summary>
        void GetAllAxisEnc();
        /// <summary>
        /// 获取单个轴编码器值
        /// </summary>
        /// <param name="axisnumber">轴号</param>
        /// <returns></returns>
        double GetSingleAxisEnc(int axisnumber);
        /// <summary>
        /// 轴使能
        /// </summary>
        /// <param name="AxisNumber">轴号</param>
        /// <param name="State">ON/OFF使能</param>
        void AxisEnable(int AxisNumber, bool State);
        /// <summary>
        /// 清除报警
        /// </summary>
        void CleraAlarm();

        /// <summary>
        /// 获取轴状态
        /// </summary>
        /// <param name="axisnumber">轴号</param>
        /// <returns></returns>
        bool GetAxisState(int axisnumber);
    }
}
