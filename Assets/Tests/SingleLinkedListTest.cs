namespace SingleLinkedList.Test
{
	using LinkedList;
	using NUnit.Framework;

	public class SingleLinkedListTest
	{
		[Test]
		public void Empty()
		{
			var list = new SingleLinkedList<int>();
			Assert.AreEqual(list.Count, 0);
			Assert.AreEqual(list.Peek(), null);
		}

		[Test]
		public void AddOne()
		{
			var list = new SingleLinkedList<int>();
			var item = new SingleLinkedListNode<int>(5);
			list.Add(item);
			Assert.AreEqual(list.Count, 1);
			Assert.AreEqual(list.Peek(), item);
		}

		[Test]
		public void Pop()
		{
			var list = new SingleLinkedList<int>();
			var item = new SingleLinkedListNode<int>(5);
			list.Add(item);
			Assert.AreEqual(list.Count, 1);
			Assert.AreEqual(list.Pop(), item);
			Assert.AreEqual(list.Count, 0);
			Assert.AreEqual(list.Peek(), null);
		}

		[Test]
		public void AddMany()
		{
			var list = new SingleLinkedList<int>();
			var item = new SingleLinkedListNode<int>(5);
			list.Add(item);

			var last = new SingleLinkedListNode<int>(10);
			list.Add(last);

			Assert.AreEqual(list.Count, 2);
			Assert.AreEqual(list.Pop(), item);
			Assert.AreNotEqual(list.Pop(), null);
			Assert.AreEqual(list.Pop(), null);
		}

		[Test]
		public void SetNext()
		{
			var list = new SingleLinkedList<int>();
			var item = new SingleLinkedListNode<int>(5);
			list.Add(item);

			var last = new SingleLinkedListNode<int>(10);
			list.Add(last);

			var middle = new SingleLinkedListNode<int>(7);
			item.Next = middle;

			Assert.AreEqual(list.Count, 2);
			Assert.AreEqual(list.Pop(), item);
			Assert.AreEqual(list.Count, 1);
			Assert.AreEqual(list.Pop(), middle);
			Assert.AreEqual(list.Count, 0);
			Assert.AreEqual(list.Pop(), null);
		}

		[Test]
		public void EnumeratorEmpty()
		{
			var list = new SingleLinkedList<int>();

			Assert.AreEqual(list.Count, 0);
			var index = 0;
			foreach (var node in list)
			{
				index += 1;
			}

			Assert.AreEqual(list.Count, index);
		}

		[Test]
		public void Enumerator()
		{
			var list = new SingleLinkedList<int>()
			{
				new SingleLinkedListNode<int>(5),
				new SingleLinkedListNode<int>(7),
				new SingleLinkedListNode<int>(10),
			};

			var expected = new[] { 5, 7, 10 };

			Assert.AreEqual(list.Count, 3);
			var index = 0;
			foreach (var node in list)
			{
				Assert.AreEqual(node.Value, expected[index]);
				index += 1;
			}

			Assert.AreEqual(list.Count, index);
		}
	}
}