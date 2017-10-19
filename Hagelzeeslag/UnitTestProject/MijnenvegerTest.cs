using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hagelzeeslag;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MijnenvegerTest
    {
        [TestMethod]
        public void TestInitialStateIsNotSunk()
        {
            // Arrange
            var ship = new Mijnenveger();

            // Act
            bool isSunk = ship.IsSunk();

            // Assert
            Assert.IsFalse(isSunk);
        }

        [TestMethod]
        public void TestIfShipIsSunkAfterTwoRockets()
        {
            // Arrange
            var ship = new Mijnenveger();

            // Act
            ship.AcceptRocket();
            ship.AcceptRocket();

            bool isSunk = ship.IsSunk();

            // Assert
            Assert.IsTrue(isSunk);
        }
    }
}
