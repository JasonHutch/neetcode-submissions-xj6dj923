# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def diameterOfBinaryTree(self, root: Optional[TreeNode]) -> int:

        max_val = 0

        def traverse(root):
            nonlocal max_val
            #Base case
            if root is None:
                return 0

            dl = traverse(root.left)
            dr = traverse(root.right)

            max_val = max(dl + dr , max_val)

            return max(dl, dr) + 1

        
        traverse(root)
        return max_val

        
        