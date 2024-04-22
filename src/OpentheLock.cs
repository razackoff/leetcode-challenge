public class Solution
{
    public int OpenLock(string[] deadends, string target)
    {
        if (deadends.Contains("0000")) return -1;

        Queue<(string[] code, int steps)> queue = new Queue<(string[] code, int steps)>();
        HashSet<string> visited = new HashSet<string>();

        foreach (string deadend in deadends) visited.Add(deadend);

        queue.Enqueue((new string[]{"0", "0", "0", "0"}, 0));
        visited.Add("0000");

        string[] current;
        int steps;

        while(queue.Count > 0)
        {
            (current, steps) = queue.Dequeue();

            if (string.Join("", current) == target) return steps;

            foreach (string[] code in GetNeightbours(current))
            {
                if (visited.Contains(string.Join("", code))) continue;
                visited.Add(string.Join("", code));
                queue.Enqueue((code, steps + 1));
            }
        }

        return -1;
    }

    private List<string[]> GetNeightbours(string[] code)
    {
        List<string[]> neightbours = new List<string[]>(8);
        int digit;
        string[] neightbour;

        for (int i = 0; i < 4; i++)
        {
            digit = int.Parse(code[i]);

            neightbour = (string[])code.Clone();
            neightbour[i] = digit + 1 == 10 ? "0" : (digit + 1).ToString();
            neightbours.Add((string[])neightbour.Clone());

            neightbour = (string[])code.Clone();
            neightbour[i] = digit - 1 == -1 ? "9" : (digit - 1).ToString();
            neightbours.Add((string[])neightbour.Clone());
        }

        return neightbours;
    }
}