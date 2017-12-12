using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MotorControllerUnitTest
{
    [TestClass]
    public class MotorControllerUnitTest
    {

        [TestMethod]
        public void SetOutput1()
        {
            var vm = new Helpers.VM167_stub();
            var mc = new MotorController.MotorController(vm,1,2,3,4);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out1, StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(!vm.LastState);
            Assert.IsTrue(vm.LastOut == 1);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out1, StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(vm.LastState);
            Assert.IsTrue(vm.LastOut == 1);

        }

        [TestMethod]
        public void SetOutput2()
        {
            var vm = new Helpers.VM167_stub();
            var mc = new MotorController.MotorController(vm, 1, 2, 3, 4);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out2, StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(!vm.LastState);
            Assert.IsTrue(vm.LastOut == 2);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out2, StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(vm.LastState);
            Assert.IsTrue(vm.LastOut == 2);

        }

        [TestMethod]
        public void SetOutput3()
        {
            var vm = new Helpers.VM167_stub();
            var mc = new MotorController.MotorController(vm, 1, 2, 3, 4);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out3, StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(!vm.LastState);
            Assert.IsTrue(vm.LastOut == 3);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out3, StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(vm.LastState);
            Assert.IsTrue(vm.LastOut == 3);

        }


        [TestMethod]
        public void SetOutput4()
        {
            var vm = new Helpers.VM167_stub();
            var mc = new MotorController.MotorController(vm, 1, 2, 3, 4);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out4, StepperMotorShieldController.OutputState.Off);
            Assert.IsTrue(!vm.LastState);
            Assert.IsTrue(vm.LastOut == 4);

            mc.SetOutput(StepperMotorShieldController.OutputNumber.Out4, StepperMotorShieldController.OutputState.On);
            Assert.IsTrue(vm.LastState);
            Assert.IsTrue(vm.LastOut == 4);

        }

    }
}
