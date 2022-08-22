namespace Demo.Common.UnitTests
{
    public class DemoStringTextTests
    {
        [Fact]
        public void CombineStringsTest()
        {
            var input1 = "Some";
            var input2 = "more text";
            Assert.Equal($"{input1}{input2}", DemoStringText.CombineStrings(input1, input2));
        }
    }
}