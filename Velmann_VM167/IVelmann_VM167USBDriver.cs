using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velmann_VM167
{
    public interface IVelmann_VM167USBDriver
    {
        int GetButtonValues { get; }
        int SetDigitalOutput(int channel, bool State);
        int SendSignal(int channel, int HoldMS);
        void Stop();
        void SetupPWM1(byte PWM);
        void SetupPWM2(byte PWM);
        int SetupUSB();

    }
}
