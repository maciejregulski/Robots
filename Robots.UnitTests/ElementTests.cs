// ElementTests.cs
//
// Comments : 
// Date     : 2021/02/20
// Author   : Maciej Regulski
// <copyright file="ElementTests.cs" company="Datacom Maciej Regulski">
//     Copyright (c) Maciej Regulski. All rights reserved.
// </copyright>

using System;
using System.Threading;
//using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robots.Model;
//using Moq;

namespace Robots.UnitTests
{
    /// <summary>
    /// Unit tests for Robots.
    /// </summary>
    [TestClass]
    public class ElementTests
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
        /// Verify if Element is painted.
        /// </summary>
        [TestMethod]
        [Owner("Maciej Regulski")]
        [TestCategory("UnitTest")]
        [TestCategory("CheckIn")]
        public void Element_WhenAllPaintMethodsExecuted_VerifyIsPaintedIsTrue()
        {
            this.element.PaintRed();
            this.element.PaintGreen();
            this.element.PaintBlue();

            Assert.IsTrue(this.element.IsPainted);
        }

        [TestMethod]
        [Owner("Maciej Regulski")]
        [TestCategory("UnitTest")]
        [TestCategory("CheckIn")]
        public void Element_WhenAllPaintMethodsExecuted_VerifyStateTransitionToComplete()
        {
            this.element.PaintRed();
            this.element.FinishUp();
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));
            this.element.PaintGreen();
            this.element.FinishUp();
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));
            this.element.PaintBlue();
            this.element.FinishUp();
            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateCompleted));
            Assert.IsTrue(this.element.IsComplete);
        }

        [TestMethod]
        [Owner("Maciej Regulski")]
        [TestCategory("UnitTest")]
        [TestCategory("CheckIn")]
        public void Element_WhenPaintRedMethodsExecuted_VerifyStateTransitionToIdle()
        {
            this.element.PaintRed();
            this.element.FinishUp();

            Assert.IsInstanceOfType(this.element.State, typeof(ElementStateIdle));
        }
        /// <summary>
        /// Verify if Element is painted.
        /// </summary>
        [TestMethod]
        [Owner("Maciej Regulski")]
        [TestCategory("UnitTest")]
        [TestCategory("CheckIn")]
        [Ignore]
        public void Element_WhenAllPaintMethodsExecuted_RaisesCompletedEvent()
        {
            var eventRaised = new AutoResetEvent(false);
            //this.element.Completed += (s, e) =>
            //{
            //    eventRaised.Set();
            //};

            this.element.PaintRed();
            this.element.PaintGreen();
            this.element.PaintBlue();
            this.element.FinishUp();

            bool wasRaised = eventRaised.WaitOne(TimeSpan.FromSeconds(1));

            Assert.IsTrue(wasRaised);
        }

    }
}
