using System.Linq;

namespace Pokemon
{
    public class Letters
    {
        private const int AIndex = 97;
        public const int AlphabetMask = 67108863;

        public readonly int Mask;

        public readonly string Name;
        public readonly int Count;

        public Letters(string name)
        {
            Name = name;
            Count = Name.Count();
            Mask = name.Where(c => c != '-').Aggregate(0, (current, c) => current | GetBit(c));
        }

        /// <summary>
        /// Returns whether this set of letters contains all the other letters.
        /// </summary>
        public bool Contains(Letters other)
        {
            return (Mask | other.Mask) == Mask;
        }

        private static int GetBit(char c)
        {
            return 1 << c - AIndex;
        }
    }
}