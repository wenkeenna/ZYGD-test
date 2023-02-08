using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.Common
{
    public class ProductMatrix
    {

        //private int x_number;
        ///// <summary>
        ///// X方向点数
        ///// </summary>
        //public int X_Number { get { return x_number; } set { x_number = value; } }


        //private int y_number;
        ///// <summary>
        ///// Y方向点数
        ///// </summary>
        //public int Y_Number { get { return y_number; } set { y_number = value;} }

        ////private int x_startpoint;
        ////public int X_startpoint { get { return x_startpoint; } set { x_startpoint = value; } }

        ////private int y_startpoint;
        ////public int Y_startpoint { get { return y_startpoint; } set { y_startpoint = value; } }

        //private int x_spacing;
        ///// <summary>
        ///// X方向间距
        ///// </summary>
        //public int X_Spacing { get { return x_spacing; } set { x_spacing = value;} }


        //private int y_spacing;
        ///// <summary>
        ///// Y方向间距
        ///// </summary>
        //public int Y_Spacing { get { return y_spacing; } set { y_spacing = value; } }

        private int xcoordinate;
        public int XCorrdinate { get { return xcoordinate; } set { xcoordinate = value; } }

        private int ycoordinate;
        public int YCorrdinate { get { return ycoordinate; } set { ycoordinate = value; } }

        private int radius;
        public int Radius { get { return radius;} set { radius = value; } }

        private string backgroundcolor;
        public string BackgroundColor { get { return backgroundcolor; } set { backgroundcolor = value; } }

    }
}
