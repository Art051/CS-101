using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_LINQ
{
    internal class SequenceOperations
    {

        public int EqualSequence()
        {
            #region equal-sequence
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };

            bool match = wordsA.SequenceEqual(wordsB);

            Console.WriteLine($"The sequences match: {match}");
            #endregion
            return 0;
        }

        public int DotProduct()
        {
            #region dot-product
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();

            Console.WriteLine($"Dot product: {dotProduct}");
            #endregion
            return 0;
        }

        public int SelectFromMultipleSequences()
        {
            #region select-many-syntax
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b //commenting out this line will return all results, not just where a < b
                        select (a, b);

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.a} is less than {pair.b}");
            }
            #endregion
            return 0;
        }
    }
}
