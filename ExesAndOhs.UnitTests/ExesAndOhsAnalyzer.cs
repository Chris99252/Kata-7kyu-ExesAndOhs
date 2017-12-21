using NUnit.Framework;

namespace ExesAndOhs.UnitTests
{
    [TestFixture]
    public class ExesAndOhsAnalyzerTests
    {
        [Test]
        public void VaildStringHasSameAmountXandO_StringIsEmpty_ReturnTrue()
        {
            ExesAndOhsAnalyzer analyzer = new ExesAndOhsAnalyzer();

            var result = analyzer.VaildStringHasSameAmountXandO(string.Empty);

            Assert.IsTrue(result);
        }

        [TestCase("ooxx", true)]
        [TestCase("OOXX", true)]
        [TestCase("xooxx", false)]
        [TestCase("zpzpzpp", true)]
        [TestCase("zzoo", false)]
        [TestCase("ooxXm", true)]
        public void VaildStringHasSameAmountXandO_InputText_Vaild(string text, bool expected)
        {
            ExesAndOhsAnalyzer analyzer = new ExesAndOhsAnalyzer();

            var result = analyzer.VaildStringHasSameAmountXandO(text);

            Assert.AreEqual(expected, result);
        }
    }
}
