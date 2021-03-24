using StardewModdingAPI;
using StardewValley;
using Survivalistic.Framework.Bars;

namespace Survivalistic.Framework.Common
{
    public class Penalty
    {
        public static void VerifyPenalty()
        {
            if (!Context.IsWorldReady) return;

            if (ModEntry.data.actual_hunger <= 15 || ModEntry.data.actual_hunger > 0) BarsDatabase.tool_use_multiplier = 1.5f;
            else if (ModEntry.data.actual_hunger <= 0) BarsDatabase.tool_use_multiplier = 2.5f;
            else BarsDatabase.tool_use_multiplier = 1;

            if (ModEntry.data.actual_thirst <= 15 || ModEntry.data.actual_thirst > 0) BarsDatabase.tool_use_multiplier = 1.5f;
            else if (ModEntry.data.actual_thirst <= 0) BarsDatabase.tool_use_multiplier = 2.5f;
            else BarsDatabase.tool_use_multiplier = 1;

            DealDamage();
        }

        public static void DealDamage()
        {
            if (!Context.IsWorldReady) return;

            if (ModEntry.data.actual_hunger <= 0 || ModEntry.data.actual_thirst <= 0)
            {
                if (Game1.player.stamina > 0) Game1.player.stamina -= 5;
                else Game1.player.health -= 5;
            }
        }
    }
}
