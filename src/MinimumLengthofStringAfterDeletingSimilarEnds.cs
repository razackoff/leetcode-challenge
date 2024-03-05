public class Solution {
    public int MinimumLength(string s) {
        int start = 0, end = s.Length - 1;

        // Пока совпадают символы на обоих концах и строка не закончилась
        while (start < end && s[start] == s[end]) {
            char ch = s[start];

            // Убираем одинаковые символы с обоих концов
            while (start <= end && s[start] == ch) start++;
            while (start <= end && s[end] == ch) end--;
        }

        // Если строка симметрична, возвращаем 0, иначе возвращаем оставшуюся длину
        return start > end ? 0 : end - start + 1;
    }
}
