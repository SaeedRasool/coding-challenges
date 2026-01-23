from collections import Counter
import re

def is_anagram(s1, s2):
    # Normalize
    s1 = re.sub(r'\s+', '', s1.lower())
    s2 = re.sub(r'\s+', '', s2.lower())

    if len(s1) != len(s2):
        return False

    return Counter(s1) == Counter(s2)
