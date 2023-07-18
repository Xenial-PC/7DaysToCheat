using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using JetBrains.Annotations;

namespace C7D2C.Classes
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

                GetAllItems.GetHoldingGunRecoil(currentGunName);

                var currentHeldGunModel = Main.LocalPlayerEntity.inventory.holdingItemData.model.gameObject;
                var armsModel = Main.LocalPlayerEntity.vp_FPWeapon.WeaponModel.gameObject;

                /*EspUtils.ApplyWeaponSkin(currentHeldGunModel, @"F:\VSRepos\VSStudio\C#\_7DaysToCheat\ResourcesFolder\WeaponSkins\NeonVoidWeaponSkin.jpg", 150, 150);
                EspUtils.ApplyArmSkin(armsModel, @"F:\VSRepos\VSStudio\C#\_7DaysToCheat\ResourcesFolder\WeaponSkins\SnakeSkin.jpg", 2, 2);*/
                
                //PassiveEffects.MagazineSize
                //PassiveEffects.EntityDamage
                //PassiveEffects.BlockDamage
                //PassiveEffects.DegradationPerUse
                //PassiveEffects.RoundsPerMinute
                //PassiveEffects.DamageFalloffRange

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

        public static void MaxMagSize()
        {

        }

        public static void MaxDamage()
        {

        }

        public static void MaxDurability()
        {

        }

        public static void MaxRange()
        {

        }

        public static void MaxFireRate()
        {

        }

        public static void DisableUseTimeDamage()
        {

        }

        public static float HandleCurrentGun([NotNull] string currentGun, PassiveEffects effects)
        {
            var gun = GetAllItems.GunsList[GetAllItems.GunsList.FindIndex(name => name.Gun == currentGun)];
            return HandleEffect(effects, new List<float>() { gun.KickDegreesHorizontalMax, gun.KickDegreesHorizontalMin, gun.KickDegreesVerticalMax, gun.KickDegreesVerticalMin, gun.SpreadDegreesHorizontal, gun.SpreadDegreesVertical});
        }

        public static float HandleEffect(PassiveEffects effects, [NotNull] List<float> valuesList)
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