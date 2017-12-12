using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StepperMotorShieldControllerUnitTest
{
    [TestClass]
    public class StepperMotorShieldUnitTest
    {
        [TestMethod]
        public void CahngeMotor1Stop()
        {
            var mi = new Helpers.StepperMotorPhysicalInterfaceStub();
            var smc = new StepperMotorShieldController.StepperMotorShield(mi);
            smc.ChangeMotor(StepperMotorShieldController.StepperMotorShield.MotorNumber.Motor1, StepperMotorShieldController.StepperMotorShield.Direction.Stop);

            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out1] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out2] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List.Count == 2);
        }

        [TestMethod]
        public void CahngeMotor1Forward()
        {
            var mi = new Helpers.StepperMotorPhysicalInterfaceStub();
            var smc = new StepperMotorShieldController.StepperMotorShield(mi);
            smc.ChangeMotor(StepperMotorShieldController.StepperMotorShield.MotorNumber.Motor1, StepperMotorShieldController.StepperMotorShield.Direction.Forward);

            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out1] == StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out2] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List.Count == 2);
        }

        [TestMethod]
        public void CahngeMotor1Reverse()
        {
            var mi = new Helpers.StepperMotorPhysicalInterfaceStub();
            var smc = new StepperMotorShieldController.StepperMotorShield(mi);
            smc.ChangeMotor(StepperMotorShieldController.StepperMotorShield.MotorNumber.Motor1, StepperMotorShieldController.StepperMotorShield.Direction.Reverse);

            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out1] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out2] == StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(mi.List.Count == 2);
        }

        [TestMethod]
        public void CahngeMotor2Stop()
        {
            var mi = new Helpers.StepperMotorPhysicalInterfaceStub();
            var smc = new StepperMotorShieldController.StepperMotorShield(mi);
            smc.ChangeMotor(StepperMotorShieldController.StepperMotorShield.MotorNumber.Motor2, StepperMotorShieldController.StepperMotorShield.Direction.Stop);

            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out3] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out4] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List.Count == 2);
        }

        [TestMethod]
        public void CahngeMotor2Forward()
        {
            var mi = new Helpers.StepperMotorPhysicalInterfaceStub();
            var smc = new StepperMotorShieldController.StepperMotorShield(mi);
            smc.ChangeMotor(StepperMotorShieldController.StepperMotorShield.MotorNumber.Motor2, StepperMotorShieldController.StepperMotorShield.Direction.Forward);

            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out3] == StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out4] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List.Count == 2);
        }

        [TestMethod]
        public void CahngeMotor2Reverse()
        {
            var mi = new Helpers.StepperMotorPhysicalInterfaceStub();
            var smc = new StepperMotorShieldController.StepperMotorShield(mi);
            smc.ChangeMotor(StepperMotorShieldController.StepperMotorShield.MotorNumber.Motor2, StepperMotorShieldController.StepperMotorShield.Direction.Reverse);

            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out3] == StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(mi.List[StepperMotorShieldController.OutputNumber.Out4] == StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(mi.List.Count == 2);
        }



    }
}
