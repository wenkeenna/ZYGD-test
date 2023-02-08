using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.Common
{
    public class MenuBar
    {
        private string title;
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get { return title; } set { title = value; } }

        private string icon;
        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get { return icon; } set { icon = value; } }

        private string nameSpace;
        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace { get { return nameSpace; } set { nameSpace = value; } }
    }
}
