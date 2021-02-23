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

    }
}
