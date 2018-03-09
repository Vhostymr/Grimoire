using Grimoire.Extensions;
using System.Collections.Generic;

namespace Grimoire.Models.SpellCard
{
    public class SpellCardViewModel
    {
        public List<SpellViewModel> Spells { get; set; }

        public static string GetSpellHeading(int spellLevel)
        {
            if (spellLevel == 0) return "Cantrips";

            return spellLevel.ToOrdinal() + " Level";
        }
    }
}
