using System;
using NUnit.Framework;
//using static List.ListTask;

namespace List
{
    [TestFixture]
    public class TestList
    {
        [Test]
        public void TestPush()
        {
            ListTask.MyList<int> linkedList = new ListTask.MyList<int>();
            linkedList.Push(3);
            Assert.AreEqual(3, linkedList.headNode.element);
        }

        [Test]
        public void TestRemove()
        {
            ListTask.MyList<int> linkedList = new ListTask.MyList<int>();
            linkedList.Push(3);
            linkedList.Push(1);
            linkedList.Push(2);
            linkedList.Push(5);
            linkedList.Push(9);
            Assert.IsTrue(linkedList.Remove(5));
        }

        [Test]
        public void TestContains()
        {
            ListTask.MyList<int> linkedList = new ListTask.MyList<int>();
            linkedList.Push(3);
            linkedList.Push(1);
            linkedList.Push(2);
            linkedList.Push(5);
            linkedList.Push(9);
            Assert.IsTrue(linkedList.Contains(5));
        }

        [Test]
        public void TestReverse()
        {
            ListTask.MyList<int> linkedList1 = new ListTask.MyList<int>();
            linkedList1.Push(3);
            linkedList1.Push(1);
            linkedList1.Push(2);
            linkedList1.Push(5);
            linkedList1.Push(9);
            ListTask.MyList<int> linkedList2 = new ListTask.MyList<int>();
            linkedList2.Push(9);
            linkedList2.Push(5);
            linkedList2.Push(2);
            linkedList2.Push(1);
            linkedList2.Push(3);
            linkedList1.Reverse();
            ListTask.Node<int> current1 = linkedList1.headNode;
            ListTask.Node<int> current2 = linkedList2.headNode;
            while (current1 != null && current2 != null)
            {
                Assert.AreEqual(current1.element, current2.element);
                current1 = current1.next;
                current2 = current2.next;

            }
        }
    }
}