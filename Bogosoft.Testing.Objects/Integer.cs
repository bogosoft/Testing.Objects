using System;
using System.Collections.Generic;

namespace Bogosoft.Testing.Objects
{
    /// <summary>
    /// Provides a set of static methods for working with integer sequences.
    /// </summary>
    public static class Integer
    {
        /// <summary>
        /// Determine if a given integer is even.
        /// </summary>
        /// <param name="int">An integer to test.</param>
        /// <returns>A value indicating whether or not the given integer is even.</returns>
        public static bool Even(int @int)
        {
            return @int % 2 == 0;
        }

        /// <summary>
        /// Determine if a given integer is odd.
        /// </summary>
        /// <param name="int">An integer to test.</param>
        /// <returns>A value indicating whether or not the given integer is odd.</returns>
        public static bool Odd(int @int)
        {
            return @int % 2 == 1;
        }

        /// <summary>
        /// Filter a given sequence of integers by whether or not a sequence item is even.
        /// </summary>
        /// <param name="source">The current sequence of integers.</param>
        /// <returns>
        /// A filtered sequence of integers consisting only of even values, or no values at all.
        /// </returns>
        public static IEnumerable<int> Even(this IEnumerable<int> source)
        {
            foreach (var i in source)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// Filter a given sequence of integers by whether or not a sequence item is odd.
        /// </summary>
        /// <param name="source">The current sequence of integers.</param>
        /// <returns>
        /// A filtered sequence of integers consisting only of odd values, or no values at all.
        /// </returns>
        public static IEnumerable<int> Odd(this IEnumerable<int> source)
        {
            foreach(var i in source)
            {
                if(i % 2 == 1)
                {
                    yield return i;
                }
            }
        }

        /// <summary>
        /// Generate a sequence of random integers. The length of the sequence will be a random
        /// number between 1 and 65,536. Each integer will be a random
        /// value between the minimum and maximum values that an integer can have.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> RandomSequence()
        {
            return RandomSequence(new Random().Next(1, 65536), int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Generate a sequence of random integers with a given size. Each integer will be a random
        /// value between the minimum and maximum values that an integer can have.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static IEnumerable<int> RandomSequence(int size)
        {
            return RandomSequence(size, int.MinValue, int.MaxValue);
        }

        /// <summary>
        /// Generate a random sequence of integers. The length of the sequence will be a random
        /// number between 1 and 65,536.
        /// </summary>
        /// <param name="minval"></param>
        /// <param name="maxval"></param>
        /// <returns></returns>
        public static IEnumerable<int> RandomSequence(int minval, int maxval)
        {
            return RandomSequence(new Random().Next(1, 65536), minval, maxval);
        }

        /// <summary>
        /// Generate a sequence of random integer values.
        /// </summary>
        /// <param name="size">A value corresponding to the size of the sequence.</param>
        /// <param name="maxval">
        /// A value corresponding to the maximum value that an integer of the sequence can have.
        /// </param>
        /// <param name="minval">
        /// A value corresponding to the minimum value that an integer of the sequence can contain.
        /// </param>
        /// <returns>A sequence of integers.</returns>
        public static IEnumerable<int> RandomSequence(
            int size,
            int minval,
            int maxval
            )
        {
            var rng = new Random();

            for(var i = 0; i < size; i++)
            {
                yield return rng.Next(minval, maxval);
            }
        }
    }
}