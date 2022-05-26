using StardewModdingAPI;
using Microsoft.Xna.Framework.Graphics;

namespace Survivalistic.Framework.Common
{
    public class Textures
    {
        public static Texture2D hunger_sprite,
            thirst_sprite,
            filler_sprite;

        public static void LoadTextures()
        {
            hunger_sprite = ModEntry.instance.Helper.ModContent.Load<Texture2D>("Assets/Bars/Hunger_Sprite.png");
            thirst_sprite = ModEntry.instance.Helper.ModContent.Load<Texture2D>("Assets/Bars/Thirst_Sprite.png");
            filler_sprite = ModEntry.instance.Helper.ModContent.Load<Texture2D>("Assets/Bars/Filler_Sprite.png");
        }
    }
}
