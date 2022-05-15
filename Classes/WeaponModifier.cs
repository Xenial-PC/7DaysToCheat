using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using JetBrains.Annotations;

namespace _7DaysToCheat.Classes
{
    class WeaponModifier : MonoBehaviour
    {
        private bool _isNoRecoilEnabled;

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                if (!Main.LocalPlayerEntity.inventory.holdingItem.IsGun()) return;

                var currentGunName = Main.LocalPlayerEntity.inventory.GetHoldingGun().item.GetItemName();
                var currentGun = ItemClass.GetItem(currentGunName);
                _isNoRecoilEnabled = !_isNoRecoilEnabled;

                if (currentGun == null || currentGun.ItemClass == null) return;
                foreach (var effect in from effectGroup in currentGun.ItemClass.Effects.EffectGroups
                                       from effect in effectGroup.PassiveEffects
                                       select effect)
                {
                    if (effect.Type == PassiveEffects.KickDegreesHorizontalMax || effect.Type == PassiveEffects.KickDegreesHorizontalMin 
                    || effect.Type == PassiveEffects.KickDegreesVerticalMax || effect.Type == PassiveEffects.KickDegreesVerticalMin
                    || effect.Type == PassiveEffects.SpreadDegreesHorizontal || effect.Type == PassiveEffects.SpreadDegreesVertical)
                    {
                        for (var i = 0; i < effect.Values.Length; i++)
                        {
                            if (_isNoRecoilEnabled) effect.Values[i] = 0f;
                            else effect.Values[i] = HandleCurrentGun(currentGunName, effect.Type);
                        }
                    }
                }
            }

            //Main.LocalPlayerEntity.inventory.GetHoldingGun().InfiniteAmmo = _isNoRecoilEnabled;
        }

        private float HandleCurrentGun([NotNull] string currentGun, PassiveEffects effects)
        {
            switch (currentGun)
            {
                case "gunHandgunT1Pistol":
                    return HandleEffect(effects, new List<float>() { 0.8f, 0.7f, 0.25f, -0.25f, 1.5f, 1.5f });
                case "gunHandgunT3SMG5":
                    return HandleEffect(effects, new List<float>() { 0.3f, -0.3f, 1f, 0.5f, 1.35f, 1.35f });
                case "gunHandgunT2Magnum44":
                    return HandleEffect(effects, new List<float>() { 0.15f, -0.3f, 5f, 4.5f, 1.3f, 1.3f });
                case "gunHandgunT3DesertVulture":
                    return HandleEffect(effects, new List<float>() { 0.15f, -0.3f, 4f, 3.5f, 1.3f, 1.3f });
                case "gunShotgunT0Blunderbuss":
                    return HandleEffect(effects, new List<float>() { 4f, -4f, 8f, 8f, 5.5f, 5.5f });
                case "gunShotgunT1DoubleBarrel":
                    return HandleEffect(effects, new List<float>() { 2.5f, -2.5f, 4.2f, 4.2f, 0f, 0f });
                case "gunShotgunT2PumpShotgun":
                    return HandleEffect(effects, new List<float>() { 2.5f, -2.5f, 4.2f, 4.2f, 0f, 0f });
                case "gunShotgunT3AutoShotgun":
                    return HandleEffect(effects, new List<float>() { 2.5f, -2.5f, 4.2f, 4.2f, 0f, 0f });
                case "gunRifleT1HuntingRifle":
                    return HandleEffect(effects, new List<float>() { 0.35f, -0.35f, 2f, 0.5f, 5f, 5f });
                case "gunRifleT2MarksmanRifle":
                    return HandleEffect(effects, new List<float>() { 0.2f, -0.2f, 3f, 1.5f, 6f, 6f });
                case "gunRifleT3SniperRifle":
                    return HandleEffect(effects, new List<float>() { 0.2f, -0.2f, 3f, 1.5f, 6f, 6f });
                case "gunMGT1AK47":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 1f, -0.5f, 2.8f, 2.8f });
                case "gunMGT2TacticalAR":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 1f, -0.5f, 2.8f, 2.8f });
                case "gunMGT3M60":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 1.1f, -0.4f, 2.8f, 2.8f });
                case "gunExplosivesT3RocketLauncher":
                    return HandleEffect(effects, new List<float>() { 0.5f, -0.5f, 10f, 10f, 7f, 7f });
                case "gunBowT0PrimitiveBow":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 2f, 2f, 2.8f, 2.8f });
                case "gunBowT1WoodenBow":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 2f, 2f, 2.8f, 2.8f });
                case "gunBowT3CompoundBow":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 2f, 2f, 2.67f, 2.67f });
                case "gunBowT1IronCrossbow":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 2f, 2f, 3.35f, 3.35f });
                case "gunBowT3CompoundCrossbow":
                    return HandleEffect(effects, new List<float>() { 1f, -1f, 2f, 2f, 3.35f, 3.35f });
            }
            return 0f;
        }

        private float HandleEffect(PassiveEffects effects, [NotNull] List<float> valuesList)
        {
            switch (effects)
            {
                case PassiveEffects.KickDegreesHorizontalMax:
                    return valuesList[0];
                case PassiveEffects.KickDegreesHorizontalMin:
                    return valuesList[1];
                case PassiveEffects.KickDegreesVerticalMax:
                    return valuesList[2];
                case PassiveEffects.KickDegreesVerticalMin:
                    return valuesList[3];
                case PassiveEffects.SpreadDegreesHorizontal:
                    return valuesList[4];
                case PassiveEffects.SpreadDegreesVertical:
                    return valuesList[5];
            }
            return 0f;
        }
    }
}