import java.util.HashMap;
import java.util.Map;

public class AnagramCheck {

    public static boolean isAnagram(String s1, String s2) {
        // Normalize
        s1 = s1.toLowerCase().replaceAll("\\s+", "");
        s2 = s2.toLowerCase().replaceAll("\\s+", "");

        if (s1.length() != s2.length()) {
            return false;
        }

        Map<Character, Integer> count = new HashMap<>();

        for (char c : s1.toCharArray()) {
            count.put(c, count.getOrDefault(c, 0) + 1);
        }

        for (char c : s2.toCharArray()) {
            if (!count.containsKey(c)) return false;
            count.put(c, count.get(c) - 1);
            if (count.get(c) < 0) return false;
            if (count.get(c) == 0) {
                count.remove(c);
            }
        }

        return count.isEmpty();
    }
}
