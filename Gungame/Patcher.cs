using CitrusLib;
using HarmonyLib;
using Landfall.Network;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gungame
{

    public static class Patcher
    {

        [HarmonyPatch(typeof(ServerClient), nameof(ServerClient.SendGameStateChanged), new Type[] {typeof(GameState), typeof(byte[])})]
        class GameStartListener
        {
            static void Prefix(GameState state, byte[] extraData = null)
            {
                ServerClient world = Citrus.World;
                if (state == GameState.Flying)
                {
                    Gungame.GungameLog.Log("IOSAHJNDOIASNDOAISDNOAISDNAOISD FLYING GAMESTATE");
                    GameSettings gameSettings = world.GameRoomReference.CurrentGameSettings;
                    gameSettings.TimeBeforeFirstRing = 0;
                    world.SpawnTheRingIn
                }
            }
        }

        [HarmonyPatch(typeof(GameSettings), nameof(GameSettings.))]
        class GameSettingsPatch
        {

        }
    }
}
