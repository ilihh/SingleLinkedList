namespace LinkedList
{
	using System.Collections;
	using System.Collections.Generic;

	public class SingleLinkedList<T> : IEnumerable, IEnumerable<SingleLinkedListNode<T>>
	{
		public struct Enumerator: IEnumerator<SingleLinkedListNode<T>>, IEnumerator
		{
			private bool start;

			private SingleLinkedListNode<T> initial;
			private SingleLinkedListNode<T> current;

			internal Enumerator(SingleLinkedListNode<T> first)
			{
				start = true;
				initial = first;
				current = first;
			}

			public bool MoveNext()
			{
				if (start)
				{
					start = false;
					return current != null;
				}

				current = current.Next;

				return current != null;
			}

			public SingleLinkedListNode<T> Current
			{
				get
				{
					return current;
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return current;
				}
			}

			void IEnumerator.Reset()
			{
				start = true;
				current = initial;
			}

			public void Dispose()
			{
				initial = null;
				current = null;
			}
		}

		// вывод количества элементов
		public int Count
		{
			get
			{
				int result = 0;

				var item = first;
				while (item != null)
				{
					item = item.Next;

					result += 1;
				}

				return result;
			}
		}

		SingleLinkedListNode<T> first;

		// добавление нового элемента в конец
		public void Add(SingleLinkedListNode<T> item)
		{
			if (first == null)
			{
				first = item;
				return;
			}

			Last().Next = item;
		}

		public SingleLinkedListNode<T> Peek()
		{
			return first;
		}

		// удаление первого элемента
		public SingleLinkedListNode<T> Pop()
		{
			var result = first;
			if (first != null)
			{
				first = first.Next;
			}

			return result;
		}

		// вывод всех элементов
		public Enumerator GetEnumerator()
		{
			return new Enumerator(first);
		}

		IEnumerator<SingleLinkedListNode<T>> IEnumerable<SingleLinkedListNode<T>>.GetEnumerator()
		{
			return GetEnumerator();
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>An IEnumerator object that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		SingleLinkedListNode<T> Last()
		{
			if (first == null)
			{
				return first;
			}

			var item = first;
			while (item.Next != null)
			{
				item = item.Next;
			}

			return item;
		}
	}
}