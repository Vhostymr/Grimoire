using Grimoire.Domain;
using Grimoire.Extensions;
using System.Collections.Generic;
using System.Text;

namespace Grimoire.Models.SpellCard
{
    public class SpellViewModel
    {
        public const string CastingTimeLabel = "Casting Time: ";
        public const string RangeLabel = "Range: ";
        public const string ComponentsLabel = "Components: ";
        public const string DurationLabel = "Duration: ";

        public List<Spell> Spells { get; set; }

        public static string GetSpellHeading(int spellLevel)
        {
            if (spellLevel == 0) return "Cantrips";

            return spellLevel.ToOrdinal() + " Level";
        }

        public static string GetComponents(Spell spell)
        {
            var builder = new StringBuilder();

            builder.Append(spell.IsVerbal ? "V, " : "");
            builder.Append(spell.IsSomatic ? "S, " : "");
            builder.Append(!string.IsNullOrEmpty(spell.Material) ? "M (" + spell.Material + ")" : "");

            return builder.ToString().TrimEnd(',', ' ');
        }

        public static string GetSpellType(Spell spell)
        {
            if (spell.SpellLevel == 0) return spell.School.Name + " cantrip";

            var output = spell.SpellLevel.ToOrdinal() + "-level " + spell.School.Name;

            if (spell.IsRitual) output = output + " (ritual)";

            return output;
        }
    }
}