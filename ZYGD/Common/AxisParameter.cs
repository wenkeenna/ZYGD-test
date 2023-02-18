using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.Common
{
    /// <summary>
    /// 轴参数
    /// </summary>
    public class AxisParameter
    {
        private string _name;   
        public string Name { get { return _name; } set { _name = value; } }
        private int id;
        public int ID { get { return id; } set { id = value; } }
        private int speed;
        public int Speed { get { return speed; } set { speed = value; } }
        private int acc;
        public int Acc { get { return acc; } set { acc = value; } }
        private int dec;
        public int Dec { get { return dec; } set { dec = value; } }


    }
}
