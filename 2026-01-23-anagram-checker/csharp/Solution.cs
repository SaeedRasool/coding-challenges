using System;
using System.Collections.Generic;
using System.Linq;

class AnagramCheck
{
    public static bool IsAnagram(string s1, string s2)
    {
        // Normalize
        s1 = new string(s1.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());
        s2 = new string(s2.ToLower().Where(c => !char.IsWhiteSpace(c)).ToArray());

        if (s1.Length != s2.Length)
            return false;

        Dictionary<char, int> map = new Dictionary<char, int>();

        foreach (char c in s1)
        {
            map[c] = map.GetValueOrDefault(c, 0) + 1;
        }

        foreach (char c in s2)
        {
            if (!map.ContainsKey(c)) return false;

            map[c]--;
            if (map[c] < 0) return false;
            if (map[c] == 0)
                map.Remove(c);
        }

        return map.Count == 0;
    }
}
