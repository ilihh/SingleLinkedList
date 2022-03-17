namespace LinkedList.Test
{
	using UnityEngine;

	public class Test : MonoBehaviour
	{
		public void Run()
		{
			var list = new SingleLinkedList<int>()
			{
				new SingleLinkedListNode<int>(5),
				new SingleLinkedListNode<int>(7),
				new SingleLinkedListNode<int>(10),
			};

			foreach (var item in list)
			{
				Debug.Log(item.Value);
			}
		}
	}
}
