﻿using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;

namespace _7DaysToCheat.Classes
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
            IsToggleFovEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Toggle FOV");
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
            IsToggleFovEnabled = Overlay.GetInstance().AimbotMenu.AimbotSettingsCheckBoxList.CheckedItems.Contains("Toggle FOV");

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
                var entityEnemyClass = entityEnemy.EntityClass.classname;

                if (zombieAimbotEnabled == null && entityEnemyClass.ToString() == "EntityZombie" || entityEnemyClass.ToString() == "EntityVulture")
                    continue;
                if (playerAimbotEnabled == null && entityEnemyClass.ToString() == "EntityPlayer")
                    continue;
                if (animalAimbotEnabled == null && entityEnemyClass.ToString() == "EntityAnimal")
                    continue;
                if (enemyAnimalAimbotEnabled == null && entityEnemyClass.ToString() == "EntityEnemyAnimal")
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

                _distX /= 5;
                _distY /= 5;

                mouse_event(0x0001, (int)_distX, (int)_distY, 0, 0);
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
    }
}