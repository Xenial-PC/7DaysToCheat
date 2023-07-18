using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;

namespace C7D2C.Classes
{
    internal class Aimbot : MonoBehaviour
    {
        private float _natNextUpdateTime;
        [CanBeNull] private UnityEngine.Object[] _natObjects;
        [CanBeNull] private Camera _camera;
        private float _enemyDistance;
        private float _distX, _distY;
        public static bool IsFovAimbotEnabled, IsAimbotEnabled, IsFovCircleEnabled, IsToggleFovEnabled;
        public static EntityEnemy CurrentSelectedEnemy;
        public static float AimbotFovDistance = 150f;
        public static float AimbotDistance = 250f;

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public void Start()
        {
            IsAimbotEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Enable Aimbot");
            IsFovAimbotEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("FOV Aimbot");
            IsFovCircleEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("FOV Circle(Overlay)");
            IsToggleFovEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Player FOV");
        }

        public void Awake()
        {
            _camera = Camera.main;
        }

        public void Update()
        {
            IsAimbotEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Enable Aimbot");
            IsFovAimbotEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("FOV Aimbot");
            IsFovCircleEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("FOV Circle(Overlay)");
            IsToggleFovEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Player FOV");

            if (IsToggleFovEnabled)
            {
                var weapon = Main.LocalPlayerEntity.vp_FPWeapon;
                weapon.BobRate = Vector4.zero;
                weapon.ShakeAmplitude = Vector3.zero;
                weapon.RenderingFieldOfView = 120f;
                weapon.StepForceScale = 0f;
            }

            if (!IsAimbotEnabled) return;
            if (Input.GetKeyDown(KeyCode.PageUp)) Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.SetItemChecked(1, IsFovAimbotEnabled = !IsFovAimbotEnabled);

            var zombieAimbotEnabled = Overlay.GetInstance().AimbotMenu.EnabledEntitesListView.FindItemWithText("Zombie");
            var playerAimbotEnabled = Overlay.GetInstance().AimbotMenu.EnabledEntitesListView.FindItemWithText("Player");
            var animalAimbotEnabled = Overlay.GetInstance().AimbotMenu.EnabledEntitesListView.FindItemWithText("Animal");
            var enemyAnimalAimbotEnabled = Overlay.GetInstance().AimbotMenu.EnabledEntitesListView.FindItemWithText("Enemy Animal");

            var silentAimbot = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Silent Aimbot");
            var rageAimbot = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Rage Aimbot");
            var magicBullet = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Magic Bullet");
            var magicBulletBlameOthers = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("MB Blame Others");

            Type entityEnemyClass = null;

            var minDistance = 99999f;
            var aimTarget = Vector2.zero;
            
            if (Time.time >= _natNextUpdateTime)
            {
                _natObjects = FindObjectsOfType(typeof(EntityEnemy));
                _natNextUpdateTime = Time.time + 0.2f;
            }

            foreach (var entityEnemyObj in _natObjects)
            {
                if (entityEnemyObj == null) continue;
                var entityEnemy = (EntityEnemy)entityEnemyObj;
                if (entityEnemy == null) continue;
                entityEnemyClass = entityEnemy.EntityClass.classname;

                if (zombieAimbotEnabled == null && entityEnemyClass == typeof(EntityZombie))
                    continue;
                if (playerAimbotEnabled == null && entityEnemyClass == typeof(EntityPlayer))
                    continue;
                if (animalAimbotEnabled == null && entityEnemyClass == typeof(EntityAnimal))
                    continue;
                if (enemyAnimalAimbotEnabled == null && entityEnemyClass == typeof(EntityEnemyAnimal))
                    continue;

                var screenPoint = _camera.WorldToScreenPoint(entityEnemy.emodel.GetHeadTransform().position);
                if (entityEnemy.Health <= 0 || !entityEnemy.IsAlive()) continue;

                if (!IsOnScreen(screenPoint)) continue;
                _enemyDistance = (int)Math.Ceiling(Vector3.Distance(Main.LocalPlayerEntity.transform.position, entityEnemy.transform.position));

                if (IsFovAimbotEnabled)
                {
                    var dist = Math.Abs(Vector2.Distance(new Vector2(screenPoint.x, Screen.height - screenPoint.y), new Vector2(Screen.width / 2, Screen.height / 2)));
                    if (dist >= AimbotFovDistance) continue;
                    if (dist >= minDistance) continue;

                    minDistance = dist;
                    aimTarget = new Vector2(screenPoint.x, Screen.height - screenPoint.y);
                    CurrentSelectedEnemy = entityEnemy;

                    continue;
                }

                if (_enemyDistance <= AimbotDistance)
                {
                    aimTarget = new Vector2(screenPoint.x, Screen.height - screenPoint.y);
                    CurrentSelectedEnemy = entityEnemy;
                }
            }

            if (Input.GetKey(KeyCode.V) && aimTarget != Vector2.zero)
            {
                _distX = aimTarget.x - Screen.width / 2.0f;
                _distY = aimTarget.y - Screen.height / 2.0f;

                if (silentAimbot)
                {
                    _distX /= 15;
                    _distY /= 15;
                }

                if (rageAimbot)
                {
                    _distX /= 4;
                    _distY /= 4;
                }

                if (!rageAimbot && !silentAimbot)
                {
                    _distX /= 5;
                    _distY /= 5;
                }

                HandleMagicBullet(magicBullet, entityEnemyClass, CurrentSelectedEnemy, magicBulletBlameOthers);
                mouse_event(0x0001, (int)_distX, (int)_distY, 0, 0);
            }
        }

        private void HandleMagicBullet(bool magicBullet, Type entityEnemyClass, EntityEnemy entityEnemy,
            bool magicBulletBlameOthers)
        {
            if (magicBullet && !magicBulletBlameOthers)
            {
                var source = new DamageSource(EnumDamageSource.External, EnumDamageTypes.Concuss);
                if (entityEnemyClass == typeof(EntityZombie))
                    source.CreatorEntityId = Main.LocalPlayerEntity.entityId;

                entityEnemy.DamageEntity(source, 100, false, 1f);
                entityEnemy.AwardKill(Main.LocalPlayerEntity);
                if (entityEnemyClass == typeof(EntityZombie) || entityEnemyClass == typeof(EntityAnimal) || entityEnemyClass == typeof(EntityEnemyAnimal))
                    Main.LocalPlayerEntity.AddKillXP(entityEnemy);

                return;
            }

            if (magicBulletBlameOthers)
            {
                var source = new DamageSource(EnumDamageSource.External, EnumDamageTypes.Concuss);
                if (entityEnemyClass == typeof(EntityPlayer))
                {
                    var randomPlayer = new System.Random();
                    source.CreatorEntityId = randomPlayer.Next(0, GetAllPlayers().Count);
                }

                entityEnemy.DamageEntity(source, 100, false, 1f);
                entityEnemy.AwardKill(Main.LocalPlayerEntity);
                if (entityEnemyClass == typeof(EntityZombie) || entityEnemyClass == typeof(EntityAnimal) || entityEnemyClass == typeof(EntityEnemyAnimal))
                    Main.LocalPlayerEntity.AddKillXP(entityEnemy);
            }
        }

        public void OnGUI()
        {
            if (!IsFovCircleEnabled || !IsFovAimbotEnabled) return;
            
            EspUtils.DrawCircle(Color.black, new Vector2(Screen.width / 2, Screen.height / 2), AimbotFovDistance - 1);
            EspUtils.DrawCircle(Color.black, new Vector2(Screen.width / 2, Screen.height / 2), AimbotFovDistance + 1);

            EspUtils.DrawCircle(new Color32(255, 255, 255, 255), new Vector2(Screen.width / 2, Screen.height / 2), AimbotFovDistance);
        }

        public static bool IsOnScreen(Vector3 position)
        {
            return position.y > 0.01f && position.y < Screen.height - 5f && position.z > 0.01f;
        }

        private List<EntityPlayer> GetAllPlayers()
        {
            var playerList = new List<EntityPlayer>();
            foreach (var playerObject in FindObjectsOfType(typeof(EntityPlayer)))
            {
                if (playerObject == null) continue;
                var playerEntity = playerObject as EntityPlayer;
                if (playerEntity == null || playerEntity.gameObject == null || playerEntity.IsDead()) continue;
                if (playerEntity == Main.LocalPlayerEntity)
                    continue;

                playerList.Add(playerEntity);
            }
            return playerList;
        }
    }
}