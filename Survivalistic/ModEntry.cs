using StardewModdingAPI;
using StardewModdingAPI.Events;
using Survivalistic.Framework.Bars;
using Survivalistic.Framework.Common;
using Survivalistic.Framework.Networking;
using Survivalistic.Framework.Rendering;

namespace Survivalistic
{
    public class ModEntry : Mod
    {
        public static ModEntry instance;
        internal static Data data;
        public static Config config;

        public override void Entry(IModHelper helper)
        {
            instance = this;
            config = this.Helper.ReadConfig<Config>();

            Textures.LoadTextures();

            helper.Events.GameLoop.UpdateTicked += OnUpdate;
            helper.Events.GameLoop.TimeChanged += OnTimeChanged;
            helper.Events.GameLoop.SaveLoaded += OnSaveLoaded;
            helper.Events.Multiplayer.PeerConnected += OnPlayerConnected;
            helper.Events.Multiplayer.ModMessageReceived += OnMessageReceived;
            helper.Events.Display.RenderingHud += Renderer.OnRenderingHud;

            helper.ConsoleCommands.Add("survivalistic_feed", "Feeds a player.\nUsage: survivalistic_feed 'player_name'", Commands.Feed);
            helper.ConsoleCommands.Add("survivalistic_hydrate", "Hydrates a player.\nUsage: survivalistic_hydrate 'player_name'", Commands.Hydrate);
            helper.ConsoleCommands.Add("survivalistic_fullness", "Set full status to a player.\nUsage: survivalistic_fullness 'player_name'", Commands.Fullness);
            helper.ConsoleCommands.Add("survivalistic_forcesync", "Forces the synchronization in multiplayer to all players.\nUsage: survivalistic_forcesync", Commands.ForceSync);
        }

        private void OnUpdate(object sender, UpdateTickedEventArgs e)
        {
            Interaction.EatingCheck();
            Interaction.UsingToolCheck();
            BarsPosition.SetBarsPosition();
        }

        private void OnTimeChanged(object sender, TimeChangedEventArgs e)
        {
            BarsUpdate.UpdateBarsInformation();
            BarsUpdate.CalculatePercentage();
            BarsWarnings.VerifyStatus();
            Penalty.VerifyPenalty();
            NetController.Sync();
        }

        private void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {

            NetController.Sync();
            BarsPosition.SetBarsPosition();
            BarsUpdate.CalculatePercentage();
            BarsWarnings.VerifyStatus();
        }

        private void OnPlayerConnected(object sender, PeerConnectedEventArgs e)
        {
            NetController.SyncSpecificPlayer(e.Peer.PlayerID);
        }

        private void OnMessageReceived(object sender, ModMessageReceivedEventArgs e)
        {
            NetController.OnMessageReceived(e);
        }
    }
}
