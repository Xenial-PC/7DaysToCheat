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
            var gun = GetAllItems.GunsList[GetAllItems.GunsList.FindIndex(name => name.Gun == currentGun)];
            return HandleEffect(effects, new List<float>() { gun.KickDegreesHorizontalMax, gun.KickDegreesHorizontalMin, gun.KickDegreesVerticalMax, gun.KickDegreesVerticalMin, gun.SpreadDegreesHorizontal, gun.SpreadDegreesVertical});
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