using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MotorControllerUnitTest.Helpers
{
    public class VM167_stub : Velmann_VM167.IVelmann_VM167USBDriver
    {
        public int GetButtonValues => throw new NotImplementedException();

        public int LastOut;
        public bool LastState;

        public int SendSignal(int channel, int HoldMS)
        {
            return 0;
        }

        public int SetDigitalOutput(int channel, bool State)
        {
            LastOut = channel;
            LastState = State;
            return 0;
        }

        public void SetupPWM1(byte PWM)
        {
        }

        public void SetupPWM2(byte PWM)
        {
        }

        public int SetupUSB()
        {
            return 0;
        }

        public void Stop()
        {
        }

        public void _offTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
        }
    }
}
