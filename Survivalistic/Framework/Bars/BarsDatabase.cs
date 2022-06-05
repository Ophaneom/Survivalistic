namespace Survivalistic.Framework.Bars
{
    public class BarsDatabase
    {
        public static float hunger_velocity = ModEntry.config.hunger_multiplier;
        public static float thirst_velocity = ModEntry.config.thirst_multiplier;

        public static bool render_numerical_hunger = false;
        public static bool render_numerical_thirst = false;

        public static bool right_side = false;

        public static float tool_use_multiplier = 0.25f;
    }
}
