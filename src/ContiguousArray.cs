public class Solution {
    public int FindMaxLength(int[] nums) {
        // Используем словарь для хранения суммы и соответствующего индекса
        Dictionary<int, int> sumIndexMap = new Dictionary<int, int>();
        sumIndexMap.Add(0, -1); // Начальное значение для суммы 0
        int maxLength = 0;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++) {
            // Преобразуем 0 в -1, чтобы у нас были только два значения: -1 и 1
            sum += nums[i] == 0 ? -1 : 1;

            // Если текущая сумма уже встречалась ранее, вычисляем длину подмассива
            if (sumIndexMap.ContainsKey(sum)) {
                int startIndex = sumIndexMap[sum];
                maxLength = System.Math.Max(maxLength, i - startIndex);
            } else {
                // Если сумма встречается впервые, добавляем ее в словарь
                sumIndexMap.Add(sum, i);
            }
        }

        return maxLength;
    }
}