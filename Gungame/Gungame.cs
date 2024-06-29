using BepInEx;
using CitrusLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Landfall.Network;
using HarmonyLib;

namespace Gungame
{
    public struct PluginInfo
    {
        public const string PLUGIN_GUID = "io.github.guyapooye.gungame";
        public const string PLUGIN_NAME = "Gungame";
        public const string PLUGIN_VERSION = "1.0.0";
        
    }

    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Gungame : BaseUnityPlugin
    {
        public static CitLog GungameLog = new CitLog(PluginInfo.PLUGIN_NAME);

        public static void DoPatching()
        {
            Harmony harmony = new Harmony(PluginInfo.PLUGIN_GUID);
            harmony.PatchAll();
        }

        private void Awake()
        {
            DoPatching();
            GungameLog.Log("HELLO WORLD AND IDK IM JUST WRTING SHIT TO TEST IT OUT");
        }
    }
}
