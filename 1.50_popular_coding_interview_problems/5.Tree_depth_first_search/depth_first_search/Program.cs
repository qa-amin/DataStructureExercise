namespace depth_first_search
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var root = new BinaryTree();

			root.Data = 1;

			root.Left = new BinaryTree() ;
			root.Left.Data = 2;

			root.Left.Left = new BinaryTree();
			root.Left.Left.Data = 3;

			root.Left.Right = new BinaryTree();
			root.Left.Right.Data = 4;

			root.Right = new BinaryTree();
			root.Right.Data = 5;

			root.Right.Left = new BinaryTree();
			root.Right.Left.Data = 6;

			root.Right.Right = new BinaryTree();
			root.Right.Right.Data = 7;

			Console.WriteLine("Pre Order Print is : ");
			PreOrder(root);

			Console.WriteLine("********************************");

			Console.WriteLine("In Order Print is : ");
			InOrder(root);

			Console.WriteLine("********************************");

			Console.WriteLine("Post Order Print is : ");
			PostOrder(root);
		}

		public static void PreOrder(BinaryTree root)
		{
			if (root != null)
			{
				Console.WriteLine(root.Data);

				PreOrder(root.Left);
				PreOrder(root.Right);
			}
				
		}

		public static void InOrder(BinaryTree root)
		{
			if (root != null)
			{
				InOrder(root.Left);

				Console.WriteLine(root.Data);
				InOrder(root.Right);
			}
		}

		public static void PostOrder(BinaryTree root)
		{
			if (root != null)
			{
				PostOrder(root.Left);
				PostOrder(root.Right);

				Console.WriteLine(root.Data);
			}
		}
	}
}
