using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepperMotorShieldController
{

    /// <summary>
    /// Controls the motor shield (HW) throught 4 digital outputs. The outputrs are parsed to "IStepperMotorPhysicalInterface" for physical execution
    /// Motor1: Uses Out1 and Out2 (OutA / OutB)
    /// Motor2: Uses Out3 and Out4 (OutA / OutB)
    /// Stop: Both OutA and OutB is set to off
    /// Forward: OutA on / OutB off
    /// Reverse: OutA off / OutB on
    /// </summary>
    
    public class StepperMotorShield
    {
        public enum MotorNumber { Motor1, Motor2 };
        public enum Direction { Stop, Forward, Reverse };

        IStepperMotorPhysicalInterface _outputDriver;

        public StepperMotorShield(IStepperMotorPhysicalInterface OutputDriver)
        {
            _outputDriver = OutputDriver;
        }

        public void ChangeMotor(MotorNumber Number, Direction direction)
        {
            switch (Number)
            {
                case MotorNumber.Motor1:
                    DoAction(StepperMotorShieldController.OutputNumber.Out1, StepperMotorShieldController.OutputNumber.Out2, direction);
                    break;
                case MotorNumber.Motor2:
                    DoAction(StepperMotorShieldController.OutputNumber.Out3, StepperMotorShieldController.OutputNumber.Out4, direction);
                    break;

            }
        }

        void DoAction(StepperMotorShieldController.OutputNumber Out1, StepperMotorShieldController.OutputNumber Out2, Direction direction)
        {
            switch (direction)
            {
                case Direction.Stop:
                    _outputDriver.SetOutput(Out1, StepperMotorShieldController.OutputState.Off);
                    _outputDriver.SetOutput(Out2, StepperMotorShieldController.OutputState.Off);
                    break;
                case Direction.Forward:
                    _outputDriver.SetOutput(Out2, StepperMotorShieldController.OutputState.Off);
                    _outputDriver.SetOutput(Out1, StepperMotorShieldController.OutputState.On);
                    break;
                case Direction.Reverse:
                    _outputDriver.SetOutput(Out1, StepperMotorShieldController.OutputState.Off);
                    _outputDriver.SetOutput(Out2, StepperMotorShieldController.OutputState.On);
                    break;

            }
        }
    }
}
