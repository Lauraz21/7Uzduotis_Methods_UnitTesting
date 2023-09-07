using _7Uzduotis_Methods_UnitTesting;
namespace Test7_Methods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPassword()
        {
            string input = "Bananas123";

            bool actual = Program.IsPasswordValid(input);

            Assert.IsTrue(actual);
        }
    }
}