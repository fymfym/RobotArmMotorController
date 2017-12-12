using System.Runtime.InteropServices;

namespace Velmann_VM167
{
    public static class VM167DLL
    {
        [DllImport("vm167.dll")]
        public static extern int OpenDevices();

        [DllImport("vm167.dll")]
        public static extern void CloseDevices();

        [DllImport("vm167.dll")]
        public static extern int ReadAnalogChannel(int CardAddress, int Channel);

        [DllImport("vm167.dll")]
        public static extern void ReadAllAnalog(int CardAddress, int[] Buffer);

        [DllImport("vm167.dll")]
        public static extern void SetPWM(int CardAddress, int Channel, int Data, int Freq);

        [DllImport("vm167.dll")]
        public static extern void OutputAllPWM(int CardAddress, int Data1, int Data2);

        [DllImport("vm167.dll")]
        public static extern void OutputAllDigital(int CardAddress, int Data);

        [DllImport("vm167.dll")]
        public static extern void ClearDigitalChannel(int CardAddress, int Channel);

        [DllImport("vm167.dll")]
        public static extern void ClearAllDigital(int CardAddress);

        [DllImport("vm167.dll")]
        public static extern void SetDigitalChannel(int CardAddress, int Channel);

        [DllImport("vm167.dll")]
        public static extern void SetAllDigital(int CardAddress);

        [DllImport("vm167.dll")]
        public static extern bool ReadDigitalChannel(int CardAddress, int Channel);

        [DllImport("vm167.dll")]
        public static extern int ReadAllDigital(int CardAddress);

        [DllImport("vm167.dll")]
        public static extern void InOutMode(int CardAddress, int HighNibble, int LowNibble);

        [DllImport("vm167.dll")]
        public static extern uint ReadCounter(int CardAddress);

        [DllImport("vm167.dll")]
        public static extern void ResetCounter(int CardAddress);

        [DllImport("vm167.dll")]
        public static extern int Connected();

        [DllImport("vm167.dll")]
        public static extern int VersionFirmware(int CardAddress);

        [DllImport("vm167.dll")]
        public static extern int VersionDLL();

        [DllImport("vm167.dll")]
        public static extern void ReadBackPWMOut(int CardAddress, int[] Buffer);

        [DllImport("vm167.dll")]
        public static extern int ReadBackInOutMode(int CardAddress);


    }
}
