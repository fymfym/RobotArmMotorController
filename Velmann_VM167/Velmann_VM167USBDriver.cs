using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Velmann_VM167
{
    public class Velmann_VM167USBDriver : IVelmann_VM167USBDriver
    {
        int _cardAddress;
        int _cardsDiscovered;

        System.Timers.Timer _offTimer;
        int _offTimerChannel;

        public int GetButtonValues
        {
            get
            {
                if (_cardsDiscovered != VM167DLL.Connected())
                {
                    throw new Exception("Card not present, reconnect and restart program");
                }
                int x = VM167DLL.ReadAllDigital(_cardAddress);
                if (x != 0)
                {
                    var q = x + 1;
                }
                return x;
            }
        }

        public int SetDigitalOutput(int channel, bool State)
        {
            if (_cardsDiscovered != VM167DLL.Connected())
            {
                throw new Exception("Card not present, reconnect and restart program");
            }

            if (State)
            {
                VM167DLL.SetDigitalChannel(_cardAddress, channel);
            }
            else
            {
                VM167DLL.ClearDigitalChannel(_cardAddress, channel);
            }
            return 1;
        }

        public int SendSignal(int channel, int HoldMS)
        {
            if (_cardsDiscovered != VM167DLL.Connected())
                throw new Exception("Card not present, reconnect and restart program");

            if (_offTimer == null) _offTimer = new System.Timers.Timer();
            if (_offTimer.Enabled) return 0;
            _offTimerChannel = channel;

            _offTimer.Elapsed += _offTimer_Elapsed;
            _offTimer.Interval = HoldMS;
            VM167DLL.ClearDigitalChannel(_cardAddress, _offTimerChannel);

            _offTimer.Start();
            return 1;
        }

        private void _offTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            VM167DLL.SetDigitalChannel(_cardAddress, _offTimerChannel);
            _offTimer.Stop();
        }

        public void Stop()
        {
            VM167DLL.CloseDevices();
        }

        public void SetupPWM1(byte PWM)
        {
            VM167DLL.SetPWM(_cardAddress, 1, PWM, 1);
        }

        public void SetupPWM2(byte PWM)
        {
            VM167DLL.SetPWM(_cardAddress, 2, PWM, 1);
        }

        public int SetupUSB()
        {
            _cardsDiscovered = VM167DLL.OpenDevices();
            switch (_cardsDiscovered)
            {
                case 0:
                    throw new Exception("Card not working");
                case 1:
                    _cardAddress = 0;
                    break;
                case 2:
                    _cardAddress = 1;
                    break;
                case 3:
                    throw new Exception("More than one card connected, or no card connected");
                case -1:
                    throw new Exception("No card connected");
            }
            VM167DLL.InOutMode(_cardAddress, 0, 0);
            VM167DLL.ClearAllDigital(_cardAddress);
            return 1;
        }

    }
}
