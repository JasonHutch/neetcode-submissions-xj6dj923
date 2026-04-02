# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        # None <- 1 <- 2 <- 3 <- 4 (head)

        # take the current head and save the obj saved to it's .next prop
        # point head to none
        # Take the .net object and point to current node
        # Repeat

        current_node = head
        prev_node = None

        while current_node is not None:
            # None <- 1 <- 2 <- 3 <- 4
            
            # temp = None
            temp = current_node.next

            # None <- 1
            current_node.next = prev_node

            prev_node = current_node
            current_node = temp
        return prev_node
