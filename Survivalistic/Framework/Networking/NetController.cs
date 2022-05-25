using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using Survivalistic.Framework.Common;
using Survivalistic.Framework.Bars;

namespace Survivalistic.Framework.Networking
{
    public class NetController
    {
        private static IModHelper Helper = ModEntry.instance.Helper;
        private static IManifest Manifest = ModEntry.instance.ModManifest;

        public static bool firstLoad;

        public static void SyncSpecificPlayer(long player_id)
        {
            if (Context.IsMainPlayer)
            {
                Data _data = Helper.Data.ReadSaveData<Data>($"{player_id}") ?? new Data();
                Helper.Data.WriteSaveData($"{player_id}", _data);

                Debugger.Log($"Sending important data to farmhand {player_id}.", "Trace");
                Helper.Multiplayer.SendMessage(
                    message: _data,
                    messageType: "SaveDataFromHost",
                    modIDs: new[] { Manifest.UniqueID },
                    playerIDs: new[] { player_id }
                );
            }
        }

        public static void SyncAllPlayers()
        {
            if (Context.IsMainPlayer)
            {
                Debugger.Log($"Sending important data to all farmhands.", "Trace");
                foreach (Farmer farmer in Game1.getOnlineFarmers())
                {
                    Data _data = Helper.Data.ReadSaveData<Data>($"{farmer.UniqueMultiplayerID}") ?? new Data();
                    Helper.Data.WriteSaveData($"{farmer.UniqueMultiplayerID}", _data);

                    Debugger.Log($"Sending important data to farmhand {farmer.UniqueMultiplayerID}.", "Trace");
                    Helper.Multiplayer.SendMessage(
                        message: _data,
                        messageType: "SaveDataFromHost",
                        modIDs: new[] { Manifest.UniqueID },
                        playerIDs: new[] { farmer.UniqueMultiplayerID }
                    );
                }
            }
        }

        public static void Sync()
        {
            if (Context.IsMainPlayer)
            {
                Debugger.Log($"Saving host data.", "Trace");

                Data _data = Helper.Data.ReadSaveData<Data>($"{Game1.player.UniqueMultiplayerID}") ?? new Data();
                if (!firstLoad)
                {
                    ModEntry.data = _data;
                    firstLoad = true;
                }
                Helper.Data.WriteSaveData($"{Game1.player.UniqueMultiplayerID}", ModEntry.data);

                BarsUpdate.CalculatePercentage();
            }
            else
            {
                Debugger.Log($"Sending important data to host.", "Trace");

                Helper.Multiplayer.SendMessage(
                    message: ModEntry.data,
                    messageType: "SaveDataToHost",
                    modIDs: new[] { Manifest.UniqueID },
                    playerIDs: new[] { Game1.MasterPlayer.UniqueMultiplayerID }
                );
            }
        }

        public static void OnMessageReceived(ModMessageReceivedEventArgs e)
        {
            if (!Context.IsMainPlayer && e.FromModID == Manifest.UniqueID && e.Type == "SaveDataFromHost")
            {
                ModEntry.data = e.ReadAs<Data>();
                BarsUpdate.CalculatePercentage();
                Debugger.Log("Received important data from host.", "Trace");
                BarsUpdate.CalculatePercentage();
            }

            if (Context.IsMainPlayer && e.FromModID == Manifest.UniqueID && e.Type == "SaveDataToHost")
            {
                Data _data = e.ReadAs<Data>();
                Debugger.Log($"Received important data from player {e.FromPlayerID}.", "Trace");
                Helper.Data.WriteSaveData($"{e.FromPlayerID}", _data);
            }
        }
    }
}
