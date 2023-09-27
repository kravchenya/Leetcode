namespace LeetCode.BinaryTree.Easy;

using System;
using System.Collections.Generic;

public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
     public TreeNode()
    {
        this.val = 0;
        this.left = new TreeNode();
        this.right = new TreeNode();
    }

    public TreeNode( TreeNode left, TreeNode right, int val=0)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class AverageLevelBinaryTree
{

    public void GetAverageOfLevels() 
    {
        var treeNode = new TreeNode();
        var result = AverageOfLevels(treeNode);
        foreach(var res in result) {
            Console.Write(" " + res);
        }
    }

    private IList<double> AverageOfLevels(TreeNode root) {
        var result = new List<double>(){};
        if (root == null){
            return result;
        }
        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        while (queue.Count != 0) 
        {
            int size = queue.Count;
            double sum = 0.0;
            for(int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                sum += node.val;
                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }
            result.Add(sum/size);
        }

        return result;
    }
}
