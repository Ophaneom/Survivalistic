using StardewValley;
using Microsoft.Xna.Framework;

namespace Survivalistic.Framework.Bars
{
    public class BarsPosition
    {
        public static Vector2 barPosition;

        private static Vector2 sizeUI = new Vector2(Game1.uiViewport.Width, Game1.uiViewport.Height);
        private static string current_location = Game1.player.currentLocation.Name;

        public static void SetBarsPosition()
        {
            switch (ModEntry.config.bars_position)
            {
                case "bottom-right":
                    if (current_location.Contains("UndergroundMine") || current_location.Contains("VolcanoDungeon") || Game1.player.health < Game1.player.maxHealth) barPosition.X = sizeUI.X - 171;
                    else barPosition.X = sizeUI.X - 116;
                    barPosition.Y = sizeUI.Y;
                    break;

                case "bottom-left":
                    barPosition.X = 70;
                    barPosition.Y = sizeUI.Y;
                    break;

                case "middle-right":
                    barPosition.X = sizeUI.X - 56;
                    barPosition.Y = (sizeUI.Y / 2) + 75;
                    break;

                case "middle-left":
                    barPosition.X = 70;
                    barPosition.Y = (sizeUI.Y / 2) + 75;
                    break;

                case "top-right":
                    barPosition.X = sizeUI.X - 365;
                    if (Game1.player.appliedSpecialBuffs != null) barPosition.Y = 325;
                    else barPosition.Y = 290;
                    break;

                case "top-left":
                    barPosition.X = 70;
                    if (current_location.Contains("UndergroundMine")) barPosition.Y = 320;
                    else if (current_location.Contains("VolcanoDungeon") && current_location != "VolcanoDungeon0") barPosition.Y = 320;
                    else barPosition.Y = 260;
                    break;

                //Sets the position to a custom position
                case "custom":
                    barPosition.X = ModEntry.config.bars_custom_x;
                    barPosition.X = ModEntry.config.bars_custom_y;
                    break;
            }
        }
    }
}
