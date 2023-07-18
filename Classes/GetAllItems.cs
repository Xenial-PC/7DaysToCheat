using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace C7D2C.Classes
{
    public class GetAllItems : ItemClass
    {
        public static List<RecoilValues> GunsList = new List<RecoilValues>();
        public static List<BlockValues> BlockList = new List<BlockValues>();

        public static List<string> GetAllCurrentItems()
        {
            return itemNames;
        }

        public static void GetAllGunsRecoil()
        {
            try
            {
                foreach (var item in GetAllCurrentItems())
                {
                    if (!item.StartsWith("gun")) continue;
                    var itemValue = GetItem(item);
                    if (!itemValue.ItemClass.IsGun()) continue;

                    var weapon = new RecoilValues
                    {
                        Gun = item,
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

        public static void GetHoldingGunRecoil(string gunName)
        {
            try
            {
                var isGunPresent = GunsList.Any(name => name.Gun == gunName);
                if (isGunPresent) return;

                var itemValue = GetItem(gunName);
                var weapon = new RecoilValues
                {
                    Gun = itemValue.ItemClass.GetItemName(),
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
            catch (Exception e)
            {
                // ignore
            }
        }

        public static void GetAllBlocks()
        {
            try
            {
                if (BlockList.Count > 0) BlockList.Clear();
                foreach (var item in ItemNames)
                {
                    var blockItem = GetItem(item);
                    var isBlock = blockItem.ItemClass.IsBlock();
                    if (!isBlock) continue;

                    var block = blockItem.ItemClass.GetBlock();

                    var blockValues = new BlockValues()
                    {
                        Block = item,
                        BlockId = blockItem.GetItemOrBlockId(),
                        MaxDamage = block.MaxDamage,
                        MaxDamagePlusDowngrades = block.MaxDamagePlusDowngrades,
                        CraftComponentTime = block.CraftComponentTime,
                        CraftComponentExp = block.CraftComponentExp
                    };

                    BlockList.Add(blockValues);
                }
            }
            catch (Exception e)
            {
                // ignore
            }
        }
    }
}
