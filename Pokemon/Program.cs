using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var startTime = DateTime.UtcNow;

            var counter = 0;
            var pokemon = PokemonData.FilteredPokemon;
            var found = new ConcurrentBag<PokemonSet>();
            Parallel.For(0, pokemon.Length, i =>
            {
                var p1 = pokemon[i];
                for (var j = i + 1; j < pokemon.Length; j++)
                {
                    var p2 = pokemon[j];
                    for (var k = j + 1; k < pokemon.Length; k++)
                    {
                        var p3 = pokemon[k];
                        for (var l = k + 1; l < pokemon.Length; l++)
                        {
                            var p4 = pokemon[l];
                            for (var m = l + 1; m < pokemon.Length; m++)
                            {
                                var p5 = pokemon[m];

                                // Inline 'or' is much quicker than wrapping this up in a method 
                                // so I have hardcoded the loops rather than doing this dynamically :(
                                if ((p1.Letters.Mask | p2.Letters.Mask | p3.Letters.Mask | 
                                    p4.Letters.Mask | p5.Letters.Mask) == Letters.AlphabetMask)
                                {
                                    found.Add(new PokemonSet(new[] { p1, p2, p3, p4, p5 }));
                                    Console.WriteLine("Total found: " + found.Count);
                                }
                            }
                        }
                    }
                }
                Interlocked.Increment(ref counter);
                Console.WriteLine(counter + " - " + i);
            });

            Console.WriteLine("Best set: " + GetBest(found));

            Console.WriteLine("Total time: " + (DateTime.UtcNow - startTime));
            Console.ReadLine();
        }

        private static PokemonSet GetBest(ConcurrentBag<PokemonSet> sets)
        {
            var best = sets.First();
            foreach (var set in sets.Skip(1))
            {
                if (set.LetterCount < best.LetterCount) best = set;
            }

            return best;
        }
    }
}
