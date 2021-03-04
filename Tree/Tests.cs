using NUnit.Framework;

namespace Tree
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestPush()
        {
            TreeTask.Tree tre = new TreeTask.Tree();
            tre.Push(3);
            Assert.AreEqual(3, tre.headNode.element);
        }

        [Test]
        public void TestRemove()
        {
            TreeTask.Tree tre = new TreeTask.Tree();
            tre.Push(3);
            tre.Push(5);
            tre.Push(9);
            Assert.IsTrue(tre.Contains(3));
            Assert.IsTrue(tre.Remove(3));
        }

        [Test]
        public void TestContains()
        {
            TreeTask.Tree tre = new TreeTask.Tree();
            tre.Push(5);
            tre.Push(3);
            tre.Push(9);
            tre.Push(1);
            tre.Push(2);
            tre.Push(11);
            Assert.IsTrue(tre.Contains(11));
        }
    }
}