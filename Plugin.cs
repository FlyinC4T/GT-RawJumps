using BepInEx;
using HarmonyLib;
using System;
using UnityEngine;

namespace RawJumps
{
    [BepInPlugin("xyz.flyinc4t.rawjumps", "RawJumps", "1.0")]
    public class Plugin : BaseUnityPlugin
    {
        [HarmonyPatch(typeof(GorillaLocomotion.GTPlayer), "velocityLimit")]
        void Awake()
        {
            GameObject player = GorillaLocomotion.GTPlayer.Instance;
            if (GorillaLocomotion.GTPlayer.Instance != null)
            {
                GorillaLocomotion.GTPlayer.Instance.velocityLimit = 0;
            }
        }
    }
}
