namespace Reverse_binary_tree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var root = new BinaryTree();

			root.Data = 1;

			root.Left = new BinaryTree();
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


			ReverseBinaryTree(root);

			
		}

		public static void ReverseBinaryTree(BinaryTree root)
		{
			if (root != null)
			{
				// Swap

				(root.Left, root.Right) = (root.Right, root.Left);

				ReverseBinaryTree(root.Left);
				ReverseBinaryTree(root.Right);
			}
		}

		
	}
}
