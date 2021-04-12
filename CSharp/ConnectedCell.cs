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
        private int result;

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

        public void Perform()
        {

        }

    }
}
