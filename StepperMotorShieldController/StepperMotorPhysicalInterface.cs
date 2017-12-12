using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepperMotorShieldController
{
    public enum OutputNumber { Out1, Out2, Out3, Out4};
    public enum OutputState { On, Off };

    /// <summary>
    /// Interface implementing....
    /// </summary>
    public interface IStepperMotorPhysicalInterface
    {
        void SetOutput(OutputNumber Output, OutputState State);
    }
}
