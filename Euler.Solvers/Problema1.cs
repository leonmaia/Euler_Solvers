using System.Linq;

namespace Euler.Solvers
{
    public class Problema1 : ISolver
    {
        public object Solve()
        {
            

            return Enumerable.Range(0, 1000).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }
    }
}