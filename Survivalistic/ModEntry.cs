using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
            NetController.Sync();
        }

        private void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {

            NetController.Sync();
            BarsPosition.SetBarsPosition();
            BarsUpdate.CalculatePercentage();
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
