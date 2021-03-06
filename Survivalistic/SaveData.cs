using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StardewModdingAPI;
using StardewValley;

namespace Survivalistic
{
    class SaveData
    {
        public float hunger { get; set; } = 100;
        public float thirst { get; set; } = 100;
        public float hungerSaturation { get; set; } = 50;
        public float thirstSaturation { get; set; } = 50;

        public void SyncToHost()
        {
            if (Context.IsMainPlayer)
                ModEntry.instance.Helper.Data.WriteSaveData($"spacechase0.AnotherHungerMod.{Game1.player.UniqueMultiplayerID}", ModEntry.data);
            else
            {
                ModEntry.instance.Helper.Multiplayer.SendMessage(this, "MESSAGE_KEY", null, new long[] { Game1.MasterPlayer.UniqueMultiplayerID });
            }
        }
    }
}
