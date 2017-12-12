using StepperMotorShieldController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepperMotorShieldControllerUnitTest.Helpers
{
    public class StepperMotorPhysicalInterfaceStub : IStepperMotorPhysicalInterface
    {

        public Dictionary<OutputNumber, OutputState> List;
        public StepperMotorPhysicalInterfaceStub()
        {
            List = new Dictionary<OutputNumber, OutputState>();
        }

        public void SetOutput(OutputNumber Output, OutputState State)
        {
            List.Add(Output, State);
        }
    }
}
