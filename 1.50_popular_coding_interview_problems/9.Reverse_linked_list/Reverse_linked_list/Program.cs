using System.Threading.Channels;

namespace Reverse_linked_list
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var node = new Node(1);
			node.Next = new Node(2);
			node.Next.Next = new Node(3);

			var singleLinkList = new SingleLinkList();
			singleLinkList.Head = node;

			var p = singleLinkList.Head;
			while (p != null)
			{
				Console.Write(p.Data + " ");
				p = p.Next;
			}
			Console.WriteLine();
			Console.WriteLine("**************************");

			var q = ReverseSingleLinkList(singleLinkList.Head);

			
			while (q != null)
			{
				Console.Write(q.Data + " ");
				q = q.Next;
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
