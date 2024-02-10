using System.Diagnostics.Tracing;

namespace Palindrome_linked_list
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Time O(n);
			var node = new Node(1);
			node.Next = new Node(2);
			node.Next.Next = new Node(3);
			node.Next.Next.Next = new Node(2);
			node.Next.Next.Next.Next = new Node(1);
			//node.Next.Next.Next.Next.Next = new Node(1);

			var singleLinkList = new SingleLinkList();
			singleLinkList.Head = node;

			Node slow = singleLinkList.Head, fast = singleLinkList.Head;

			while (fast != null)
			{
				slow = slow.Next;
				if(fast.Next != null)
					fast = fast.Next.Next;
				else
				{
					fast = fast.Next;
				}
			}

			var right = ReverseSingleLinkList(slow);
			var left = singleLinkList.Head;

			var IsPalindome = true;
			while (right != null)
			{
				if (left.Data != right.Data)
				{
					IsPalindome = false;
					break;
				}

				left = left.Next;
				right = right.Next;

			}

			if (IsPalindome)
			{
				Console.WriteLine("the LinkedList is Palindome");
			}
			else
			{
				Console.WriteLine("the LinkedList is Not Palindome");
			}



		}

		public static Node ReverseSingleLinkList(Node head)
		{
			var curent = head;
			Node pre = null;
			Node next = null;

			while (curent != null)
			{
				next = curent.Next;
				curent.Next = pre;
				pre = curent;
				curent = next;
			}

			return pre;
		}
	}
}
