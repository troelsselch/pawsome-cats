using PawsomeCats.Data.CatFacts;

namespace PawsomeCats.UnitTests
{
    [TestClass]
    public class CatFactTests
    {
        [TestMethod]
        public void CanInstantiateCatFacts()
        {
            // Arrange
            string id = "test-id";
            string text = "A cat fact";

            // Act
            CatFact sut = new CatFact()
            {
                Id = id,
                Text = text
            };

            // Assert
            Assert.AreEqual(id, sut.Id);
            Assert.AreEqual(text, sut.Text);
        }
    }
}