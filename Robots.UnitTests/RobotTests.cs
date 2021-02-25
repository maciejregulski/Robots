// RobotTests.cs
//
// Comments : 
// Date     : 2021/02/24
// Author   : Maciej Regulski
// <copyright file="RobotTests.cs" company="Datacom Maciej Regulski">
//     Copyright (c) Maciej Regulski.
// </copyright>


using System;
using System.Threading;
using System.Threading.Tasks;
//using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots.Model;
//using Moq;

namespace Robots.UnitTests
{
    [TestClass]
    public class RobotTests
    {
        private IElement element;

        /// <summary>
        /// Common setup method for all tests in this class.
        /// </summary>
        [TestInitialize]
        public void SetUp()
        {
            this.element = new Element(1);
        }

        /// <summary>
        /// Clean up used resources after test is finished.
        /// </summary>
        [TestCleanup]
        public void TearDown()
        {
        }

        /// <summary>
        /// Verify if Paint method whit the same color is not executed twice.
        /// </summary>
        [TestMethod]
        [Owner("Maciej Regulski")]
        [TestCategory("UnitTest")]
        [TestCategory("CheckIn")]
        public void RobotRed_WhenPaintMethodIsExecutedTwice_VerifyIsPaintedOnlyOnce()
        {
            IRobot robot = new RobotRed(1, 10);
            robot.Paint(this.element);
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateRed));
            this.element.FinishUp();
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));
            robot.Paint(this.element);
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));
        }

        /// <summary>
        /// Verify when all paint methods executed element is completed.
        /// </summary>
        [TestMethod]
        [Owner("Maciej Regulski")]
        [TestCategory("UnitTest")]
        [TestCategory("CheckIn")]
        public void RobotRedGreenBlue_WhenPaintMethodIsExecutedOnEachRobot_VerifyElementIsCompleted()
        {
            new RobotRed(1, 10).Paint(this.element);
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateRed));
            this.element.FinishUp();
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));
            
            new RobotGreen(1, 10).Paint(this.element);
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateGreen));
            this.element.FinishUp();
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));

            new RobotBlue(1, 10).Paint(this.element);
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateBlue));
            this.element.FinishUp();
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateCompleted));
        }

        /// <summary>
        /// Verify when job abort is called no painting is done.
        /// </summary>
        [TestMethod]
        [Owner("Maciej Regulski")]
        [TestCategory("UnitTest")]
        [TestCategory("CheckIn")]
        public void RobotRed_WhenPaintMethodIsAborted_VerifyElementIsNotPaintedRed()
        {
            var startPainting = new ManualResetEvent(false);
            var paintFinished = new ManualResetEvent(false);
            var robot = new RobotRed(1, 1000);
            Task.Run(() => {
                startPainting.WaitOne(TimeSpan.FromSeconds(1));
                robot.Paint(this.element);
                paintFinished.Set();
            });
            startPainting.Set();
            robot.Abort = true;
            paintFinished.WaitOne(TimeSpan.FromSeconds(2));
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));
            Assert.IsFalse(this.element.IsRed);
        }
    }
}
