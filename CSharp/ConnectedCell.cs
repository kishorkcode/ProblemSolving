using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class ConnectedCell
    {
        private int n, m;
        private int[][] matrix;
        private bool[][] visited;
        private int result;

        private int[] dx = {-1, -1, -1, 0, 0, 1, 1, 1};
        private int[] dy = {-1, 0, 1, -1, 1, -1, 0, 1 };

        public void GetInputs()
        {
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine();
                matrix[i] = Array.ConvertAll(row.Split(' '), x => Convert.ToInt32(x));
            }
        }

        public void PrintOutput()
        {
            Console.WriteLine(result);
        }

        int islandSize = 0;

        public void Perform()
        {
            bool[][] visited = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                visited[i] = new bool[m];
            }
            
            int maxIslandSize = 0;
            int islandCount = 0;
            for (int i = 0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (visited[i][j] == false && matrix[i][i] == 1)
                    {
                        islandSize = 0;
                        DFS(i, j);
                        if (islandSize > maxIslandSize)
                        {
                            maxIslandSize = islandSize;
                        }

                        islandCount++;
                    }
                }
            }

            result = maxIslandSize;
        }

        private void DFS(int row, int col)
        {
            islandSize++;

            visited[row][col] = true;

            for (int i = 0; i < 8; i++)
            {
                if (check(row + dx[i], col + dy[i]))
                {
                    DFS(row+dx[i], col + dy[i]);
                }
            }
        }

        private bool check(int row, int col)
        {
            return (row >= 0) && (row < n) && (col >= 0) && (col < m) && (matrix[row][col] == 1) && (!visited[row][col]);
        }

    }
}
