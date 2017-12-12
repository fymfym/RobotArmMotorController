using StepperMotorShieldController;
using Velmann_VM167;

namespace MotorController
{
    public class MotorController : StepperMotorShieldController.IStepperMotorPhysicalInterface
    {

        IVelmann_VM167USBDriver _velmann;
        int _out1;
        int _out2;
        int _out3;
        int _out4;

        public MotorController(IVelmann_VM167USBDriver Velmann, int Out1, int Out2, int Out3, int Out4)
        {
            _velmann = Velmann;
            _out1 = Out1;
            _out2 = Out2;
            _out3 = Out3;
            _out4 = Out4;
        }

        public void SetOutput(OutputNumber Output, OutputState State)
        {
            switch(Output)
            {
                case OutputNumber.Out1:
                    _velmann.SetDigitalOutput(_out1, State == OutputState.On);
                    break;
                case OutputNumber.Out2:
                    _velmann.SetDigitalOutput(_out2, State == OutputState.On);
                    break;
                case OutputNumber.Out3:
                    _velmann.SetDigitalOutput(_out3, State == OutputState.On);
                    break;
                case OutputNumber.Out4:
                    _velmann.SetDigitalOutput(_out4, State == OutputState.On);
                    break;
            }
        }

    }
}
