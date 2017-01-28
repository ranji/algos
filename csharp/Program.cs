using System;

namespace ConsoleApplication
{
    using charp;
    public class Program
    {
        public static void Main(string[] args)
        {
            FindAllBinaryTreePathsToLeafNodes();
        }
        
        
        /*
        Given a binary tree, return all root-to-leaf paths.
        */
        public static void FindAllBinaryTreePathsToLeafNodes()
        {
            /*
                0
              /    \
            10      100
            /\       \
          20  25      200  
            */

            var tree = new TreeNode(0);
            tree.left = new TreeNode(10);
            tree.right = new TreeNode(100);
            tree.left.left = new TreeNode(20);
            tree.left.right = new TreeNode(25);
            tree.right.right = new TreeNode(200);
            var binTreeSol = new BinaryTreePathsSolution();
            var paths = binTreeSol.BinaryTreePaths(tree);
            foreach (string p in paths)
            {
                Console.WriteLine(p);
            }

        }
    }
}


