using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.Common
{
    public class ProductMatrix
    {

        private int xcoordinate;
        /// <summary>
        /// X坐标
        /// </summary>
        public int XCorrdinate { get { return xcoordinate; } set { xcoordinate = value; } }

        private int ycoordinate;
        /// <summary>
        /// Y坐标
        /// </summary>
        public int YCorrdinate { get { return ycoordinate; } set { ycoordinate = value; } }

        private int radius;
        /// <summary>
        /// 半径
        /// </summary>
        public int Radius { get { return radius;} set { radius = value; } }

        private string backgroundcolor;
        /// <summary>
        /// 颜色
        /// </summary>
        public string BackgroundColor { get { return backgroundcolor; } set { backgroundcolor = value; } }
        private int number;
        /// <summary>
        /// 编号
        /// </summary>
        public int Number { get { return number; } set { number = value; } }

    }
}
