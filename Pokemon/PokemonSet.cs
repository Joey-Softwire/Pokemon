using System.Collections.Generic;
using System.Linq;

namespace Pokemon
{
    public class PokemonSet
    {
        public IEnumerable<Pokemon> Pokemons { get; set; }
        public readonly int LetterCount;

        public PokemonSet(IEnumerable<Pokemon> pokemons)
        {
            Pokemons = pokemons;
            LetterCount = Pokemons.Sum(p => p.Letters.Count);
        }

        public override string ToString()
        {
            return "Letters: " + LetterCount + " Pokemon: " + string.Join(", ", Pokemons);
        }
    }
}
