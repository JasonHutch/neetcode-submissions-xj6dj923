class Solution:
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        cn_1 = list1
        cn_2 = list2

        if not cn_1: return cn_2
        if not cn_2: return cn_1

        merged_head = None
        cmn = None

        while cn_1 is not None and cn_2 is not None:
            if cn_1.val < cn_2.val:
                if merged_head is None:
                    merged_head = cn_1
                else:
                    cmn.next = cn_1
                cmn = cn_1
                cn_1 = cn_1.next
            else:
                if merged_head is None:
                    merged_head = cn_2
                else:
                    cmn.next = cn_2
                cmn = cn_2
                cn_2 = cn_2.next
                
        if cn_1 is None:
            cmn.next = cn_2
        
        if cn_2 is None:
            cmn.next = cn_1

        return merged_head