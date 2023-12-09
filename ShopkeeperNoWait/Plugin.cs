using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using ShopkeeperNoWait.Patches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopkeeperNoWait
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ShopkeerNoWaitModBase : BaseUnityPlugin
    {
        private const string modGUID = "Sant.ShopkeeperWait";
        private const string modName = "Shopkeeper Wait Time";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ShopkeerNoWaitModBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("The Shopkeepr wait mod has awaken :)");

            harmony.PatchAll(typeof(ShopkeerNoWaitModBase));
            harmony.PatchAll(typeof(ShopItemAcceptancePatch));
        }
    }
}
