namespace Grimoire.Data.DataModels
{
    public class Spell
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public School School { get; set; }

        public int SpellLevel { get; set; }

        public string CastingTime { get; set; }

        public string Range { get; set; }

        public string Duration { get; set; }

        public string Description { get; set; }

        public string Material { get; set; }

        public bool IsVerbal { get; set; }

        public bool IsSomatic { get; set; }

        public bool IsRitual { get; set; }
    }
}
