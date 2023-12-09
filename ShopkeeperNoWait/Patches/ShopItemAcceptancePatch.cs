using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopkeeperNoWait.Patches
{
    [HarmonyPatch(typeof(DepositItemsDesk))]
    internal class ShopItemAcceptancePatch
    {
        [HarmonyPatch(nameof(DepositItemsDesk.SetTimesHeardNoiseServerRpc))]
        [HarmonyPostfix]
        static void noDelayPatch(ref float ___timesHearingNoise)
        {
            ___timesHearingNoise = 8f;
        }
    }
}
