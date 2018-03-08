using Grimoire.Data.DataModels;
using Grimoire.Extensions;
using System;
using System.Text;

namespace Grimoire.Models.SpellCard
{
    public class SpellViewModel : Spell
    {
        public const string CastingTimeLabel = "Casting Time: ";
        public const string RangeLabel = "Range: ";
        public const string ComponentsLabel = "Components: ";
        public const string DurationLabel = "Duration: ";

        public string Components
        {
            get
            {
                var builder = new StringBuilder();

                builder.Append(IsVerbal ? "V, " : "");
                builder.Append(IsSomatic ? "S, " : "");
                builder.Append(!string.IsNullOrEmpty(Material) ? "M (" + Material + ")" : "");

                return builder.ToString().TrimEnd(Convert.ToChar(", "));
            }
        }

        public string SpellType
        {
            get
            {
                if (SpellLevel == 0) return School.Name + " cantrip";

                var output = SpellLevel.ToOrdinal() + "-level " + School.Name;

                if (IsRitual) output = output + " (ritual)";

                return output;
            }
        }
    }
}