public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {

        if(source == destination){

            return true;
        }

        Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

        for(int i = 0; i < n; i ++){

            adjList[i] = new List<int>();
        }

        foreach(int[] edge in edges){

            int u = edge[0];

            int v = edge[1];

            adjList[u].Add(v);

            adjList[v].Add(u);
        }

        Queue<int> queue = new Queue<int>();

        queue.Enqueue(source);

        HashSet<int> visited = new HashSet<int> {source};

        while(queue.Count > 0){

            int current = queue.Dequeue();

            foreach(int neighbor in adjList[current]){

                if(neighbor == destination){

                    return true;
                }

                if(!visited.Contains(neighbor)){

                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        return false;
    }     
}