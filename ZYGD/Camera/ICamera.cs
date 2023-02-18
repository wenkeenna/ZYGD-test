using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.Camera
{
   interface ICamera
    {
        /// <summary>
        /// 打开相机
        /// </summary>
        void OpenDevice();
        /// <summary>
        /// 关闭相机
        /// </summary>
        void CloseDevice();


        /// <summary>
        /// 显示或保存图像
        /// </summary>
        /// <param name="obj"></param>
        void ImageShowAndSave(object obj);
        /// <summary>
        /// 软触发命令
        /// </summary>
        void SoftTriggerCommand();


        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void Set(string key, string value);
        /// <summary>
        /// 获取参数
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object Get(string key);
    }
}
