public class Solution {
    public void MoveZeroes(int[] nums) {
        int nonZeroPointer = 0;
        
        // Перебираем массив
        for (int i = 0; i < nums.Length; i++) {
            // Если текущий элемент ненулевой, помещаем его на позицию nonZeroPointer
            if (nums[i] != 0) {
                nums[nonZeroPointer++] = nums[i];
            }
        }
        
        // Заполняем оставшуюся часть массива нулями
        while (nonZeroPointer < nums.Length) {
            nums[nonZeroPointer++] = 0;
        }
    }
}
