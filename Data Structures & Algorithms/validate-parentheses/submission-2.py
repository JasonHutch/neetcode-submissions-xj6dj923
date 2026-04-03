class Solution:
    def isValid(self, s: str) -> bool:
        # have a set of open chars
        # map open char to closing char
        # if this is an open, append
        # if this is close, pop, check and see if popped value matches
        # if not return false
        # if it does continue through the string

        stack = []
        openChars = {"(","{","["}
        mapping = {"}":"{", ")":"(", "]":"["}

        for operand in s:
            if operand in openChars:
                stack.append(operand)
            else:
                if len(stack) == 0:
                    return False
                openOp = stack.pop()
                if mapping[operand] != openOp:
                    return False

        return len(stack) == 0
        
