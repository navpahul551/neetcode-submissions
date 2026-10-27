class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        hashset = {}
        for c in s:
            if c in hashset:
                hashset[c] += 1
            else:
                hashset[c] = 1
        
        for c in t:
            if c in hashset:
                if hashset[c] > 0:
                    hashset[c] -= 1
                else:
                    return False
            else:
                return False
        
        for key in hashset:
            if hashset[key] != 0:
                return False
        
        return True