using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrophyManagement1
{
    [TestClass]
    public class TrophiesRepositoryUnitTests
    {
        private TrophiesRepository _repository;

        [TestInitialize]
        public void Setup()
        {
            _repository = new TrophiesRepository();
        }

        [TestMethod]
        public void Get_ReturnsAllTrophies()
        {
            // Act
            var trophies = _repository.Get();

            // Assert
            Assert.AreEqual(5, trophies.Count);
        }

        [TestMethod]
        public void Add_AddsTrophyToList()
        {
            // Arrange
            var newTrophy = new Trophy(1, "Europa League", 2019);

            // Act
            var addedTrophy = _repository.Add(newTrophy);
            var trophies = _repository.Get();

            // Assert
            Assert.AreEqual(6, trophies.Count);
            Assert.AreEqual(6, addedTrophy.Id);
        }

        [TestMethod]
        public void Update_UpdatesExistingTrophy()
        {
            // Arrange
            var updatedTrophy = new Trophy(1, "Updated Competition", 2023);

            // Act
            var result = _repository.Update(1, updatedTrophy);
            var trophy = _repository.GetById(1);

            // Assert
            Assert.IsNotNull(result, "Update should return the updated trophy.");
            Assert.AreEqual("Updated Competition", trophy.Competition);
            Assert.AreEqual(2023, trophy.Year);
        }
    }
}