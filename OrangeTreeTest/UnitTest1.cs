using OrangeTreeSim;
namespace OrangeTreeTest
    
{
    [TestClass]
    public class UnitTest1
    {
        private OrangeTree orangeTree;

        [TestInitialize]
        public void SetupForTest()
        {
            // Start an orange tree
            orangeTree = new OrangeTree();
            orangeTree.Age = 0;
            orangeTree.Height = 6;
            orangeTree.TreeAlive = true;
        }

        [TestMethod]
        public void ShouldIncrementTheTreesAgeWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(1, orangeTree.Age = 1);
        }
        [TestMethod]
        public void ShouldIncrementTheTreesHeightByTwoWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(8, orangeTree.Height = 8);
        }
        [TestMethod]
        public void ShouldDieAfter80Years()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.TreeAlive = false);
        }

        [TestMethod]
        public void ShouldProduceFruitAfter2Years()
        {
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges = 0);

            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.NumOranges = 5);

        }
        [TestMethod]
        public void ShouldIncreaseFruitProductionBy5PiecesEachYearAfterMaturity()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.NumOranges = 5);

            orangeTree.OneYearPasses();
            Assert.AreEqual(10, orangeTree.NumOranges = 10);

        }
        [TestMethod]
        public void ShouldCountNumberOfOrangesEatenThisYear()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);

            Assert.AreEqual(1, orangeTree.OrangesEaten = 1);

            orangeTree.EatOrange(3);
            Assert.AreEqual(4, orangeTree.OrangesEaten = 4);

            Assert.AreEqual(1, orangeTree.NumOranges = 1);
        }
        [TestMethod]
        public void OrangesEatenOneYearPasses()
        {
            //Act
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);
            orangeTree.EatOrange(3);
            orangeTree.OneYearPasses();
            //Assert
            Assert.AreEqual(0, orangeTree.OrangesEaten = 0);
            Assert.AreEqual(10, orangeTree.NumOranges = 10);
        }

        [TestMethod]
        public void DeadTreeDoNotGrowAndProduceFruit()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.TreeAlive = false);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges = 0);
            Assert.AreEqual(164, orangeTree.Height = 164);
            Assert.AreEqual(81, orangeTree.Age = 81);
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.NumOranges = 0);
            Assert.AreEqual(164, orangeTree.Height = 164);
            Assert.AreEqual(82, orangeTree.Age = 82);
        }
    }
}