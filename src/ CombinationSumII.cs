public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates); // Сначала отсортируем массив кандидатов
        List<IList<int>> result = new List<IList<int>>();
        Search(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void Search(int[] candidates, int target, int start, IList<int> combination, IList<IList<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = start; i < candidates.Length; i++) {
            if (i > start && candidates[i] == candidates[i - 1]) // Пропускаем дубликаты
                continue;
            if (candidates[i] > target) // Если текущий элемент больше цели, прерываем цикл
                break;

            combination.Add(candidates[i]);
            Search(candidates, target - candidates[i], i + 1, combination, result); // Рекурсивно ищем комбинации, начиная с индекса i + 1
            combination.RemoveAt(combination.Count - 1); // Убираем последний добавленный элемент для создания новой комбинации
        }
    }
}
