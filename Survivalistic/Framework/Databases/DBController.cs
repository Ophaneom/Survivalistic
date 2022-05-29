using System.Collections.Generic;
using System.Linq;
using StardewModdingAPI;

namespace Survivalistic.Framework.Databases
{
    class DBController
    {
        public static void LoadDatabases()
        {
            EdiblesDB _actualModDatabase = ModEntry.instance.Helper.Data.ReadJsonFile<EdiblesDB>($"assets/Databases/BaseGame_edibles.json") ?? null;
            if (_actualModDatabase != null)
            {
                for (var i = 0; i < _actualModDatabase.edibles.Length / 2; i++)
                {
                    Foods.foodDatabase.Add(_actualModDatabase.edibles[i, 0], _actualModDatabase.edibles[i, 1]);
                }
            }

            List<IModInfo> _modList = ModEntry.instance.Helper.ModRegistry.GetAll().ToList();
            foreach (IModInfo _mod in _modList)
            {
                _actualModDatabase = ModEntry.instance.Helper.Data.ReadJsonFile<EdiblesDB>($"assets/Databases/{_mod.Manifest.UniqueID}_edibles.json") ?? null;
                if (_actualModDatabase != null)
                {
                    for (var i = 0; i < _actualModDatabase.edibles.Length / 2; i++)
                    {
                        Foods.foodDatabase.Add(_actualModDatabase.edibles[i, 0], _actualModDatabase.edibles[i, 1]);
                    }
                }
            }
        }
    }
}
