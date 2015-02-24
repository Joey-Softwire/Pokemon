﻿using System.Collections.Generic;
using System.Linq;

namespace Pokemon
{
    public class PokemonData
    {
        public static readonly string[] Pokemon =
        {
            "abomasnow", "abomasnow-mega", "abra", "absol", "absol-mega", "accelgor", "aegislash", "aegislash-blade",
            "aerodactyl", "aerodactyl-mega", "aggron", "aggron-mega", "aipom", "alakazam", "alakazam-mega", "alomomola",
            "altaria", "amaura", "ambipom", "amoonguss", "ampharos", "ampharos-mega", "anorith", "arbok", "arcanine",
            "arceus", "archen", "archeops", "ariados", "armaldo", "aromatisse", "aron", "articuno", "audino", "aurorus",
            "avalugg", "axew", "azelf", "azumarill", "azurill", "bagon", "baltoy", "banette", "banette-mega",
            "barbaracle", "barboach", "basculin-blue-striped", "basculin-red-striped", "bastiodon", "bayleef", "beartic",
            "beautifly", "beedrill", "beheeyem", "beldum", "bellossom", "bellsprout", "bergmite", "bibarel", "bidoof",
            "binacle", "bisharp", "blastoise", "blastoise-mega", "blaziken", "blaziken-mega", "blissey", "blitzle",
            "boldore", "bonsly", "bouffalant", "braixen", "braviary", "breloom", "bronzong", "bronzor", "budew",
            "buizel", "bulbasaur", "buneary", "bunnelby", "burmy", "butterfree", "cacnea", "cacturne", "camerupt",
            "carbink", "carnivine", "carracosta", "carvanha", "cascoon", "castform", "castform-rainy", "castform-snowy",
            "castform-sunny", "caterpie", "celebi", "chandelure", "chansey", "charizard", "charizard-mega-x",
            "charizard-mega-y", "charmander", "charmeleon", "chatot", "cherrim", "cherubi", "chesnaught", "chespin",
            "chikorita", "chimchar", "chimecho", "chinchou", "chingling", "cinccino", "clamperl", "clauncher",
            "clawitzer", "claydol", "clefable", "clefairy", "cleffa", "cloyster", "cobalion", "cofagrigus", "combee",
            "combusken", "conkeldurr", "corphish", "corsola", "cottonee", "cradily", "cranidos", "crawdaunt",
            "cresselia", "croagunk", "crobat", "croconaw", "crustle", "cryogonal", "cubchoo", "cubone", "cyndaquil",
            "darkrai", "darmanitan-standard", "darmanitan-zen", "darumaka", "dedenne", "deerling", "deino", "delcatty",
            "delibird", "delphox", "deoxys-attack", "deoxys-defense", "deoxys-normal", "deoxys-speed", "dewgong",
            "dewott", "dialga", "diggersby", "diglett", "ditto", "dodrio", "doduo", "donphan", "doublade", "dragalge",
            "dragonair", "dragonite", "drapion", "dratini", "drifblim", "drifloon", "drilbur", "drowzee", "druddigon",
            "ducklett", "dugtrio", "dunsparce", "duosion", "durant", "dusclops", "dusknoir", "duskull", "dustox",
            "dwebble", "eelektrik", "eelektross", "eevee", "ekans", "electabuzz", "electivire", "electrike", "electrode",
            "elekid", "elgyem", "emboar", "emolga", "empoleon", "entei", "escavalier", "espeon", "espurr", "excadrill",
            "exeggcute", "exeggutor", "exploud", "farfetchd", "fearow", "feebas", "fennekin", "feraligatr", "ferroseed",
            "ferrothorn", "finneon", "flaaffy", "flabebe", "flareon", "fletchinder", "fletchling", "floatzel", "floette",
            "florges", "flygon", "foongus", "forretress", "fraxure", "frillish", "froakie", "frogadier", "froslass",
            "furfrou", "furret", "gabite", "gallade", "galvantula", "garbodor", "garchomp", "garchomp-mega", "gardevoir",
            "gardevoir-mega", "gastly", "gastrodon", "genesect", "gengar", "gengar-mega", "geodude", "gible", "gigalith",
            "girafarig", "giratina-altered", "giratina-origin", "glaceon", "glalie", "glameow", "gligar", "gliscor",
            "gloom", "gogoat", "golbat", "goldeen", "golduck", "golem", "golett", "golurk", "goodra", "goomy",
            "gorebyss", "gothita", "gothitelle", "gothorita", "gourgeist-average", "gourgeist-large", "gourgeist-small",
            "gourgeist-super", "granbull", "graveler", "greninja", "grimer", "grotle", "groudon", "grovyle", "growlithe",
            "grumpig", "gulpin", "gurdurr", "gyarados", "gyarados-mega", "happiny", "hariyama", "haunter", "hawlucha",
            "haxorus", "heatmor", "heatran", "heliolisk", "helioptile", "heracross", "heracross-mega", "herdier",
            "hippopotas", "hippowdon", "hitmonchan", "hitmonlee", "hitmontop", "ho-oh", "honchkrow", "honedge",
            "hoothoot", "hoppip", "horsea", "houndoom", "houndoom-mega", "houndour", "huntail", "hydreigon", "hypno",
            "igglybuff", "illumise", "infernape", "inkay", "ivysaur", "jellicent", "jigglypuff", "jirachi", "jolteon",
            "joltik", "jumpluff", "jynx", "kabuto", "kabutops", "kadabra", "kakuna", "kangaskhan", "kangaskhan-mega",
            "karrablast", "kecleon", "keldeo-ordinary", "keldeo-resolute", "kingdra", "kingler", "kirlia", "klang",
            "klefki", "klink", "klinklang", "koffing", "krabby", "kricketot", "kricketune", "krokorok", "krookodile",
            "kyogre", "kyurem", "kyurem-black", "kyurem-white", "lairon", "lampent", "landorus-incarnate",
            "landorus-therian", "lanturn", "lapras", "larvesta", "larvitar", "latias", "latios", "leafeon", "leavanny",
            "ledian", "ledyba", "lickilicky", "lickitung", "liepard", "lileep", "lilligant", "lillipup", "linoone",
            "litleo", "litwick", "lombre", "lopunny", "lotad", "loudred", "lucario", "lucario-mega", "ludicolo", "lugia",
            "lumineon", "lunatone", "luvdisc", "luxio", "luxray", "machamp", "machoke", "machop", "magby", "magcargo",
            "magikarp", "magmar", "magmortar", "magnemite", "magneton", "magnezone", "makuhita", "malamar", "mamoswine",
            "manaphy", "mandibuzz", "manectric", "manectric-mega", "mankey", "mantine", "mantyke", "maractus", "mareep",
            "marill", "marowak", "marshtomp", "masquerain", "mawile", "mawile-mega", "medicham", "medicham-mega",
            "meditite", "meganium", "meloetta-aria", "meloetta-pirouette", "meowstic-female", "meowstic-male", "meowth",
            "mesprit", "metagross", "metang", "metapod", "mew", "mewtwo", "mewtwo-mega-x", "mewtwo-mega-y", "mienfoo",
            "mienshao", "mightyena", "milotic", "miltank", "mime-jr", "minccino", "minun", "misdreavus", "mismagius",
            "moltres", "monferno", "mothim", "mr-mime", "mudkip", "muk", "munchlax", "munna", "murkrow", "musharna",
            "natu", "nidoking", "nidoqueen", "nidoran-f", "nidoran-m", "nidorina", "nidorino", "nincada", "ninetales",
            "ninjask", "noctowl", "noibat", "noivern", "nosepass", "numel", "nuzleaf", "octillery", "oddish", "omanyte",
            "omastar", "onix", "oshawott", "pachirisu", "palkia", "palpitoad", "pancham", "pangoro", "panpour",
            "pansage", "pansear", "paras", "parasect", "patrat", "pawniard", "pelipper", "persian", "petilil", "phanpy",
            "phantump", "phione", "pichu", "pidgeot", "pidgeotto", "pidgey", "pidove", "pignite", "pikachu", "piloswine",
            "pineco", "pinsir", "pinsir-mega", "piplup", "plusle", "politoed", "poliwag", "poliwhirl", "poliwrath",
            "ponyta", "poochyena", "porygon", "porygon-z", "porygon2", "primeape", "prinplup", "probopass", "psyduck",
            "pumpkaboo-average", "pumpkaboo-large", "pumpkaboo-small", "pumpkaboo-super", "pupitar", "purrloin",
            "purugly", "pyroar", "quagsire", "quilava", "quilladin", "qwilfish", "raichu", "raikou", "ralts",
            "rampardos", "rapidash", "raticate", "rattata", "rayquaza", "regice", "regigigas", "regirock", "registeel",
            "relicanth", "remoraid", "reshiram", "reuniclus", "rhydon", "rhyhorn", "rhyperior", "riolu", "roggenrola",
            "roselia", "roserade", "rotom", "rotom-fan", "rotom-frost", "rotom-heat", "rotom-mow", "rotom-wash",
            "rufflet", "sableye", "salamence", "samurott", "sandile", "sandshrew", "sandslash", "sawk", "sawsbuck",
            "scatterbug", "sceptile", "scizor", "scizor-mega", "scolipede", "scrafty", "scraggy", "scyther", "seadra",
            "seaking", "sealeo", "seedot", "seel", "seismitoad", "sentret", "serperior", "servine", "seviper",
            "sewaddle", "sharpedo", "shaymin-land", "shaymin-sky", "shedinja", "shelgon", "shellder", "shellos",
            "shelmet", "shieldon", "shiftry", "shinx", "shroomish", "shuckle", "shuppet", "sigilyph", "silcoon",
            "simipour", "simisage", "simisear", "skarmory", "skiddo", "skiploom", "skitty", "skorupi", "skrelp",
            "skuntank", "slaking", "slakoth", "sliggoo", "slowbro", "slowking", "slowpoke", "slugma", "slurpuff",
            "smeargle", "smoochum", "sneasel", "snivy", "snorlax", "snorunt", "snover", "snubbull", "solosis", "solrock",
            "spearow", "spewpa", "spheal", "spinarak", "spinda", "spiritomb", "spoink", "spritzee", "squirtle",
            "stantler", "staraptor", "staravia", "starly", "starmie", "staryu", "steelix", "stoutland", "stunfisk",
            "stunky", "sudowoodo", "suicune", "sunflora", "sunkern", "surskit", "swablu", "swadloon", "swalot",
            "swampert", "swanna", "swellow", "swinub", "swirlix", "swoobat", "sylveon", "taillow", "talonflame",
            "tangela", "tangrowth", "tauros", "teddiursa", "tentacool", "tentacruel", "tepig", "terrakion", "throh",
            "thundurus-incarnate", "thundurus-therian", "timburr", "tirtouga", "togekiss", "togepi", "togetic",
            "torchic", "torkoal", "tornadus-incarnate", "tornadus-therian", "torterra", "totodile", "toxicroak",
            "tranquill", "trapinch", "treecko", "trevenant", "tropius", "trubbish", "turtwig", "tympole", "tynamo",
            "typhlosion", "tyranitar", "tyranitar-mega", "tyrantrum", "tyrogue", "tyrunt", "umbreon", "unfezant",
            "unown", "ursaring", "uxie", "vanillish", "vanillite", "vanilluxe", "vaporeon", "venipede", "venomoth",
            "venonat", "venusaur", "venusaur-mega", "vespiquen", "vibrava", "victini", "victreebel", "vigoroth",
            "vileplume", "virizion", "vivillon", "volbeat", "volcarona", "voltorb", "vullaby", "vulpix", "wailmer",
            "wailord", "walrein", "wartortle", "watchog", "weavile", "weedle", "weepinbell", "weezing", "whimsicott",
            "whirlipede", "whiscash", "whismur", "wigglytuff", "wingull", "wobbuffet", "woobat", "wooper",
            "wormadam-plant", "wormadam-sandy", "wormadam-trash", "wurmple", "wynaut", "xatu", "xerneas", "yamask",
            "yanma", "yanmega", "yveltal", "zangoose", "zapdos", "zebstrika", "zekrom", "zigzagoon", "zoroark", "zorua",
            "zubat", "zweilous", "zygarde"
        };

        public static readonly Pokemon[] FilteredPokemon;

        static PokemonData()
        {
            var allPokemon = new Stack<Pokemon>(Pokemon.Select(p => new Pokemon(p)));
            var filteredPokemon = new List<Pokemon>();

            // Filter out cases such as "abca" which is more succint as "abc"
            foreach (var pokemon in allPokemon)
            {
                if (filteredPokemon.Any(filtered =>
                            filtered.Letters.Contains(pokemon.Letters) &&
                            filtered.Letters.Count <= pokemon.Letters.Count))
                {
                    // We've already picked up a 'better' pokemon
                    continue;
                }

                // Remove all previously selected pokemon we are better than.
                filteredPokemon.RemoveAll(filtered => pokemon.Letters.Contains(filtered.Letters) && pokemon.Letters.Count <= filtered.Letters.Count);
                filteredPokemon.Add(pokemon);
            }

            FilteredPokemon = filteredPokemon.ToArray();
        }
    }
}
