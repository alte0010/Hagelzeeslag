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
    public class KruiserTest
    {
        [TestMethod]
        public void TestInitialStateIsNotSunk()
        {
            // Arrange
            var ship = new Kruiser();

            // Act
            bool isSunk = ship.IsSunk();

            // Assert
            Assert.IsFalse(isSunk);
        }
    }
}
