using System;
using System.Collections.Generic;
using System.Text;

namespace YieldReturn
{
    public static class Fibonacci
    {
        public static IEnumerable<int> Sequence(int length)
        {
            int n0 = 0;
            int n1 = 1;

            // First two results do'nt need to be calculated
            yield return n0;
            yield return n1;

            // -2 because we've already returned 2
            for (int i = 0; i < length - 2; ++i)
            {
                int next = n0 + n1;

                n0 = n1;
                n1 = next;

                yield return next;
            }
        }
    }
}
