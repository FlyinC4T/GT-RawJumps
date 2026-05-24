using BepInEx;
using HarmonyLib;
using System;
using UnityEngine;

namespace RawJumps
{
    [BepInPlugin("xyz.flyinc4t.rawjumps", "RawJumps", "1.0")]
    public class Plugin : BaseUnityPlugin
    {
        private float _updateTimer;

        [HarmonyPatch(typeof(GorillaLocomotion.GTPlayer), "velocityLimit" + "slideVelocityLimit")]
        private void UpdatePlayer()
        {
            GorillaLocomotion.GTPlayer player = GorillaLocomotion.GTPlayer.Instance;

            if (player != null)
            {
                player.velocityLimit = 0;
                player.slideVelocityLimit = 0;
            }
        }

        void Update()
        {
            _updateTimer += Time.deltaTime;
            if (_updateTimer > 7) UpdatePlayer();
        }
    }
}
