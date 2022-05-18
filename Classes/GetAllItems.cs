﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _7DaysToCheat.Classes
{
    public class GetAllItems : ItemClass
    {
        public static List<RecoilValues> GunsList = new List<RecoilValues>();

        public static List<string> GetAllCurrentItems()
        {
            return itemNames;
        }

        public static void GetAllGunsRecoil()
        {
            try
            {
                foreach (var item in ItemNames)
                {
                    var itemValue = GetItem(item);
                    if (!itemValue.ItemClass.IsGun()) continue;
                    if (itemValue.ItemClass.Name.Contains("melee")) continue;

                    var weapon = new RecoilValues
                    {
                        Gun = item
                    };

                    foreach (var effect in from effectGroup in itemValue.ItemClass.Effects.EffectGroups
                        from effect in effectGroup.PassiveEffects
                        select effect)
                    {
                        if (effect.Values?[0] == null) continue;

                        if (effect.Type == PassiveEffects.KickDegreesHorizontalMax)
                            weapon.KickDegreesHorizontalMax = effect.Values[0];

                        if (effect.Type == PassiveEffects.KickDegreesHorizontalMin)
                            weapon.KickDegreesHorizontalMin = effect.Values[0];

                        if (effect.Type == PassiveEffects.KickDegreesVerticalMax)
                            weapon.KickDegreesVerticalMax = effect.Values[0];

                        if (effect.Type == PassiveEffects.KickDegreesVerticalMin)
                            weapon.KickDegreesVerticalMin = effect.Values[0];

                        if (effect.Type == PassiveEffects.SpreadDegreesHorizontal)
                            weapon.SpreadDegreesHorizontal = effect.Values[0];

                        if (effect.Type == PassiveEffects.SpreadDegreesVertical)
                            weapon.SpreadDegreesVertical = effect.Values[0];
                    }

                    GunsList.Add(weapon);
                }
            }
            catch (Exception e)
            {
                // ignore
            }
        }
    }
}
