public class Solution {
    public string RemoveKdigits(string num, int k) {
        // Если k равно длине строки, значит нужно удалить все цифры
        if (k == num.Length) return "0";
        
        // Преобразуем строку в массив символов для удобства удаления элементов
        char[] stack = new char[num.Length];
        int top = 0;
        
        // Перебираем все цифры в num
        foreach (char c in num) {
            // Пока есть элементы в стеке, k больше 0 и текущая цифра меньше последней цифры в стеке,
            // удаляем цифры из стека, пока выполняется условие
            while (top > 0 && k > 0 && c < stack[top - 1]) {
                top--;
                k--;
            }
            // Добавляем текущую цифру в стек
            stack[top++] = c;
        }
        
        // Если после удаления к-цифр остались лишние цифры в стеке,
        // обрезаем стек, убирая из него эти лишние цифры
        while (k > 0) {
            top--;
            k--;
        }
        
        // Из стека формируем строку результата
        int start = 0;
        // Пропускаем ведущие нули, если они есть
        while (start < top && stack[start] == '0') {
            start++;
        }
        
        // Если после удаления всех цифр получается пустая строка, возвращаем "0"
        if (start == top) return "0";
        
        // Формируем строку результата из оставшихся цифр в стеке
        return new string(stack, start, top - start);
    }
}