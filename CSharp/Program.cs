using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectedCell = new ConnectedCell();

            connectedCell.GetInputs();
            connectedCell.Perform();
            connectedCell.PrintOutput();
        }
    }
}
