namespace Pokemon
{
    public class Pokemon
    {
        public string Name { get; private set; }

        // Field access is quicker than property hence this
        public readonly Letters Letters;

        public Pokemon(string name)
        {
            Name = name;
            Letters = new Letters(name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}