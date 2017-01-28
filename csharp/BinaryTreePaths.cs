namespace charp
{
    using System.Collections.Generic;

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class BinaryTreePathsSolution
    {

        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var result = new List<string>();
            PathMaker(root,root.val.ToString(),result);
            return result;
        }

        public void PathMaker(TreeNode node,string path,IList<string> paths){
            if (node.left == null && node.right == null) {
                paths.Add(path);
                return;
            }
            if (node.left!=null){
                PathMaker(node.left,path+"->" +node.left.val,paths);
            }
            if (node.right!=null){
                PathMaker(node.right,path+"->" +node.right.val,paths);
            }
        }
    }
}