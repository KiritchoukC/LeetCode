/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        return Recursive(root);
    }
    
    private IList<int> Recursive(TreeNode root, List<int> result = null){
        result = result ?? new List<int>();
        
        if(root != null){
            result.Add(root.val);

            if(root.left != null){
                result.AddRange(Recursive(root.left));
            } 
            
            if(root.right != null){
                result.AddRange(Recursive(root.right));
            }
        }
        
        return result;
    }
}