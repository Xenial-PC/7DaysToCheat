using UnityEngine;

namespace C7D2C.Classes
{
    class PlayerModifer : MonoBehaviour
    {
        public static void IsCreativeMode(bool isEnabled)
        {
            GameStats.Set(EnumGameStats.IsCreativeMenuEnabled, isEnabled);
        }

        public static void IsDebugMode(bool isEnabled)
        {
            GamePrefs.Set(EnumGamePrefs.DebugMenuEnabled, isEnabled);
        }

        public static void IsSpawnWindowShowed(bool isEnabled)
        {
            GameStats.Set(EnumGameStats.ShowSpawnWindow, isEnabled);
        }

        public static void SetHudOpacity(int opacity)
        {
            GamePrefs.Set(EnumGamePrefs.OptionsHudOpacity, opacity);
        }

        public static void IsCompassEnabled(bool isEnabled)
        {
            GamePrefs.Set(EnumGamePrefs.OptionsShowCompass, isEnabled);
        }

        public static void SetPlayerKillingMode(bool isEnabled)
        {
            GamePrefs.Set(EnumGamePrefs.PlayerKillingMode, isEnabled);
        }

        public static void AddSkillPoints(int amount)
        {
            var playerProgression = Main.LocalPlayerEntity.Progression;
            playerProgression.SkillPoints += amount;
        }

        public static void SetSkillPoints(int amount)
        {
            var playerProgression = Main.LocalPlayerEntity.Progression;
            playerProgression.SkillPoints = amount;
        }

        public static void AddPlayerLevel(int amount)
        {
            var playerProgression = Main.LocalPlayerEntity.Progression;
            playerProgression.Level += amount;
        }

        public static void SetPlayerLevel(int amount)
        {
            var playerProgression = Main.LocalPlayerEntity.Progression;
            playerProgression.Level = amount;
        }

        public static void SetExpDeficit(int amount)
        {
            var playerProgression = Main.LocalPlayerEntity.Progression;
            playerProgression.ExpDeficit = amount;
        }

        public static void SetExpToNextLevel(int amount)
        {
            var playerProgression = Main.LocalPlayerEntity.Progression;
            playerProgression.ExpToNextLevel = amount;
        }

        public static void SetKilledPlayerAmount(int amount)
        {
            Main.LocalPlayerEntity.KilledPlayers = amount;
        }

        public static void AddKilledPlayerAmount(int amount)
        {
            Main.LocalPlayerEntity.KilledPlayers += amount;
        }

        public static void SetKilledZombieAmount(int amount)
        {
            Main.LocalPlayerEntity.KilledZombies = amount;
        }

        public static void AddKilledZombieAmount(int amount)
        {
            Main.LocalPlayerEntity.KilledZombies += amount;
        }

        public static void TeleportEntity(Entity entity, Entity target)
        {
            entity.SetPosition(target.GetPosition());
        }

        public static void TeleportEntity(EntityPlayerLocal localPlayer, EntityPlayer target)
        {
            localPlayer.TeleportToPosition(target.GetPosition());
        }

        public static void TeleportEntity(EntityPlayerLocal localPlayer, Entity target)
        {
            localPlayer.TeleportToPosition(target.GetPosition());
        }
    }
}