namespace LinkedList
{
	public class SingleLinkedListNode<T>
	{
		public T Value;

		public SingleLinkedListNode<T> Next;

		public SingleLinkedListNode(T value, SingleLinkedListNode<T> next = null)
		{
			Value = value;
			Next = next;
		}
	}
}