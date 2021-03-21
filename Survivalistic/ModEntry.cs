using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Survivalistic.Framework;
using Survivalistic.Framework.Bars;
using Survivalistic.Framework.Common;
using Survivalistic.Framework.Networking;

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
            helper.Events.Display.RenderedHud += OnRenderedHud;
            helper.Events.Display.WindowResized += OnWindowResize;
        }

        private void OnUpdate(object sender, UpdateTickedEventArgs e)
        {
            Interaction.EatingCheck();
            Interaction.UsingToolCheck();
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

        private void OnRenderedHud(object sender, RenderedHudEventArgs e)
        {
            e.SpriteBatch.Draw(Textures.hunger_sprite, new Rectangle((int)BarsPosition.barPosition.X, (int)BarsPosition.barPosition.Y - 240, Textures.hunger_sprite.Width * 4, Textures.hunger_sprite.Height * 4), Color.White);
            e.SpriteBatch.Draw(Textures.thirst_sprite, new Rectangle((int)BarsPosition.barPosition.X - 60, (int)BarsPosition.barPosition.Y - 240, Textures.thirst_sprite.Width * 4, Textures.thirst_sprite.Height * 4), Color.White);

            e.SpriteBatch.Draw(Textures.filler_sprite, new Vector2(BarsPosition.barPosition.X + 36, BarsPosition.barPosition.Y - 25), new Rectangle(0, 0, Textures.filler_sprite.Width * 4, (int)BarsInformations.hunger_percentage), BarsInformations.hunger_color, 3.138997f, new Vector2(0.5f, 0.5f), 1f, SpriteEffects.None, 1f);
            e.SpriteBatch.Draw(Textures.filler_sprite, new Vector2(BarsPosition.barPosition.X - 24, BarsPosition.barPosition.Y - 25), new Rectangle(0, 0, Textures.filler_sprite.Width * 4, (int)BarsInformations.thirst_percentage), BarsInformations.thirst_color, 3.138997f, new Vector2(0.5f, 0.5f), 1f, SpriteEffects.None, 1f);
        }

        private void OnWindowResize(object sender, WindowResizedEventArgs e)
        {
            BarsPosition.SetBarsPosition();
        }
    }
}
