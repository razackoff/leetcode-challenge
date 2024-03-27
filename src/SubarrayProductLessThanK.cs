public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if (k <= 1) // Если k <= 1, то произведение любого подмассива будет больше или равно k.
            return 0;

        int ans = 0;
        int product = 1;
        int left = 0;

        for (int right = 0; right < nums.Length; right++) {
            product *= nums[right]; // Умножаем текущий элемент на текущее произведение.

            // Сдвигаем левый указатель, пока произведение больше или равно k.
            while (product >= k) {
                product /= nums[left];
                left++;
            }

            // Добавляем количество подмассивов, которые заканчиваются в текущей позиции right.
            ans += right - left + 1;
        }

        return ans;
    }
}