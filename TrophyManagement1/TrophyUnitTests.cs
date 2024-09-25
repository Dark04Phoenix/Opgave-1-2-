using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrophyManagement1
{
    [TestClass]
    public class TrophyUnitTests
    {
        [TestMethod]
        public void Trophy_ValidInput_CreateTrophy()
        {
            // Arrange & Act
            var trophy = new Trophy(1, "Olympics", 2021);

            // Assert
            Assert.AreEqual(1, trophy.Id);
            Assert.AreEqual("Olympics", trophy.Competition);
            Assert.AreEqual(2021, trophy.Year);
        }

        [TestMethod]
        public void Trophy_InvalidCompetition_ThrowArgumentException()
        {
            // Arrange
            string invalidCompetition = "AB";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Trophy(1, invalidCompetition, 2021));
        }

        [TestMethod]
        public void Trophy_InvalidYear_ThrowArgumentOutOfRangeException()
        {
            // Arrange
            int invalidYear = 1969;

            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Trophy(1, "World Cup", invalidYear));
        }

        [TestMethod]
        public void Trophy_InvalidId_ThrowArgumentException()
        {
            // Arrange
            int invalidId = -5;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Trophy(invalidId, "World Championship", 2021));
        }

        [TestMethod]
        public void ToString_ReturnCorrectString()
        {
            // Arrange
            var trophy = new Trophy(1, "Champions League", 2020);

            // Act
            var result = trophy.ToString();

            // Assert
            Assert.AreEqual("Trophy Id: 1, Competition: Champions League, Year: 2020", result);
        }

        [TestMethod]
        public void Trophy_EmptyCompetition_ThrowArgumentException()
        {
            // Arrange
            string invalidCompetition = "";

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Trophy(1, invalidCompetition, 2021));
        }

        [TestMethod]
        public void Trophy_NullCompetition_ThrowArgumentException()
        {
            // Arrange
            string nullCompetition = null;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Trophy(1, nullCompetition, 2021));
        }

        [TestMethod]
        public void Trophy_ValidLowerYear_CreateTrophy()
        {
            // Arrange & Act
            var trophy = new Trophy(1, "Olympics", 1970);

            // Assert
            Assert.AreEqual(1970, trophy.Year);
        }
    }
}