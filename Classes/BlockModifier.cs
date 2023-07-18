using UnityEngine;

namespace C7D2C.Classes
{
    public class BlockModifier : MonoBehaviour
    {
        public static void SetBlockHealth(Block block, int health)
        {
            block.MaxDamage = health;
        }

        public static void SetBlockHealthPlusDowngrades(Block block, int maxDamage, int maxDamagePlusDowngrades)
        {
            block.MaxDamage = maxDamage;
            block.MaxDamagePlusDowngrades = maxDamagePlusDowngrades;
        }

        public static void SetBlockCraftComponentTime(Block block, int time)
        {
            block.CraftComponentTime = time;
        }

        public static void SetBlockCraftComponentExp(Block block, int exp)
        {
            block.CraftComponentExp = exp;
        }

        public static int GetOriginalBlockHealth(Block block)
        {
            var blockValues = GetAllItems.BlockList[GetAllItems.BlockList.FindIndex(values => values.BlockId == block.blockID)];
            return blockValues.MaxDamage;
        }

        public static int GetOriginalBlockHealthPlusDowngrades(Block block)
        {
            var blockValues = GetAllItems.BlockList[GetAllItems.BlockList.FindIndex(values => values.BlockId == block.blockID)];
            return blockValues.MaxDamagePlusDowngrades;
        }

        public static void ResetBlockToOriginalValues(Block block)
        {
            var blockValues = GetAllItems.BlockList[GetAllItems.BlockList.FindIndex(blockId => blockId.BlockId == block.blockID)];
            block.MaxDamage = blockValues.MaxDamage;
            block.MaxDamagePlusDowngrades = blockValues.MaxDamagePlusDowngrades;
            block.CraftComponentTime = blockValues.CraftComponentTime;
            block.CraftComponentExp = blockValues.CraftComponentExp;
        }

        public static void UpdateBlockValues(Block block, int maxDamage, int upgradeMaxDamage, int time, int exp)
        {
            SetBlockHealthPlusDowngrades(block, maxDamage, upgradeMaxDamage);
            SetBlockCraftComponentTime(block, time);
            SetBlockCraftComponentExp(block, exp);
        }
    }
}