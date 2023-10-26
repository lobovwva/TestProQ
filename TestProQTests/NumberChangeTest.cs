using TestProQ;

namespace TestProQTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Convert_ShouldReturnCorrectList()
        {
            // Arrange
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> expected = new List<string>() { "1", "2", "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", "11", "dog-muzz", "13", "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz" };

            // Act
            List<string> result = NumberChange.ReplaceNumbers(numbers);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}