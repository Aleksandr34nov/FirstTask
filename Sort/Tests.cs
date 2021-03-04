using NUnit.Framework;
using static Sort.SortTask;
using static Sort.SortTask;

namespace Sort
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestPush()
        {
            int[] Array1 = { 2, 3, 1, 2, 8, 5, 6, 100 };
            int[] Array2 = { 1, 2, 2, 3, 5, 6, 8, 100 };
            SortTask.Sort(Array1);
            for (int i = 0; i < 8; i++)
            {
                Assert.AreEqual(Array1[i], Array2[i]);
            }
        }
    }
}