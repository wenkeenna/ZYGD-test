using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZYGD.Motion
{
    internal class Leadshine : IMotionControl
    {
        public void AxisEnable(int AxisNumber, bool State)
        {
            throw new NotImplementedException();
        }

        public void CleraAlarm()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void GetAllAxisEnc()
        {
            throw new NotImplementedException();
        }

        public bool GetAxisState(int axisnumber)
        {
            throw new NotImplementedException();
        }

        public bool GetIO(string InputANDOutput, int number)
        {
            throw new NotImplementedException();
        }

        public double GetSingleAxisEnc(int axisnumber)
        {
            throw new NotImplementedException();
        }

        public Task Home(int axisnumber)
        {
            throw new NotImplementedException();
        }

        public void JOG(int axisNumber, int vel)
        {
           
        }

        public Task MoveAbsolute(int axisNumber, int pos, int vel)
        {
            throw new NotImplementedException();
        }

        public void MoveRelative()
        {
          
        }

        public void Open()
        {
           
        }

        public void SetIO(int number, short state)
        {
          
        }

        public void Stop(int axisNumber)
        {
         
        }
    }
}
