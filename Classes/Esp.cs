using System;
using System.Collections.Generic;
using System.Windows.Forms;
using _7DaysToCheat.Menus;
using JetBrains.Annotations;
using UnityEngine;
using Screen = UnityEngine.Screen;

namespace _7DaysToCheat.Classes
{
    internal class Esp : MonoBehaviour
    {
        [CanBeNull] private static Camera _camera;
        private float _lastZombieEspTime, _lastPlayerEspTime, _lastAnimalEspTime;
        [CanBeNull] private UnityEngine.Object[] _zombieEntityObjects, _playerEntityObjects, _animalEntityObjects;

        private int _Color;
        private Material _chamsMaterial;
        private float _lastChamTime;

        public void Awake()
        {
            _camera = Camera.main;
        }

        public void Start()
        {
            _chamsMaterial = new Material(Shader.Find("Hidden/Internal-Colored"))
            {
                hideFlags = HideFlags.HideAndDontSave
            };

            _Color = Shader.PropertyToID("_Color");

            _chamsMaterial.SetInt("_SrcBlend", 5);
            _chamsMaterial.SetInt("_DstBlend", 10);
            _chamsMaterial.SetInt("_Cull", 0);
            _chamsMaterial.SetInt("_ZTest", 8);
            _chamsMaterial.SetInt("_ZWrite", 0);
            _chamsMaterial.SetColor(_Color, Color.red);
        }

        public void OnGUI()
        {
            if (Event.current.type != EventType.Repaint) return;
            var espBox = Overlay.GetInstance().EspMenu.EspOptionsCheckListBox.GetItemChecked(0);
            var espCornerBox = Overlay.GetInstance().EspMenu.EspOptionsCheckListBox.GetItemChecked(1);
            var espEntityHealth = Overlay.GetInstance().EspMenu.EspOptionsCheckListBox.GetItemChecked(2);
            var espEntityInfo = Overlay.GetInstance().EspMenu.EspOptionsCheckListBox.GetItemChecked(3);
            var espHeadCircle = Overlay.GetInstance().EspMenu.EspOptionsCheckListBox.GetItemChecked(4);
            var espEnabled = Overlay.GetInstance().EspMenu.EnableEspOptionCheckBox.Checked;
            var radarEnabled = Overlay.GetInstance().EspMenu.EnableRadarCheckBox.Checked;
            var chamsEnabled = Overlay.GetInstance().EspMenu.EnableChamsCheckBox.Checked;

            if (radarEnabled)
            {
                var lineColor = new Color(54 / 255f, 69 / 255f, 79 / 255f, 0.8f);
                EspUtils.RectFilled(0, 0, 200, 200, new Color(0, 0, 0, 0.8f));
                 
                EspUtils.DrawLine(new Vector2(100, 0), new Vector2(100, 200), lineColor, 3);
                EspUtils.DrawLine(new Vector2(0, 100), new Vector2(200, 100), lineColor, 3);
                EspUtils.OutlineBox(new Vector2(0, 0), new Vector2(200, 200), new Color(255, 0, 0, 0.8f), 5);
                
                EspUtils.RectFilled(95, 95, 10, 10, Color.green);
            }

            var zombieEspEnabled = Overlay.GetInstance().EspMenu.EnabledEntitesListView.FindItemWithText("Zombie");
            var enemyAnimalEspEnabled = Overlay.GetInstance().EspMenu.EnabledEntitesListView.FindItemWithText("Enemy Animal");
            if (zombieEspEnabled != null && zombieEspEnabled.Text == @"Zombie" || enemyAnimalEspEnabled != null && enemyAnimalEspEnabled.Text == @"Enemy Animal")
            {
                if (Time.time >= _lastZombieEspTime)
                {
                    _zombieEntityObjects = FindObjectsOfType(typeof(EntityEnemy));
                    _lastZombieEspTime = Time.time + 0.2f;
                }

                if (_zombieEntityObjects == null || _zombieEntityObjects.Length <= 0) return;
                foreach (var enemy in _zombieEntityObjects)
                {
                    if (enemy == null) continue;
                    var entityZombie = (EntityEnemy)enemy;
                    if (entityZombie == null || entityZombie.gameObject == null || entityZombie.IsDead()) continue;
                    var entityEnemyClass = entityZombie.EntityClass.classname;

                    if (zombieEspEnabled == null && entityEnemyClass == typeof(EntityZombie))
                        continue;
                    if (enemyAnimalEspEnabled == null && entityEnemyClass == typeof(EntityEnemyAnimal))
                        continue;

                    var dist = (int)Math.Ceiling(Vector3.Distance(Main.LocalPlayerEntity.transform.position, entityZombie.transform.position));
                    var vector = _camera.WorldToScreenPoint(entityZombie.transform.position);

                    var headPoint = _camera.WorldToScreenPoint(entityZombie.emodel.GetHeadTransform().position);

                    if (radarEnabled)
                    {
                        var normalizePosition = NormalizePosition(Main.LocalPlayerEntity.transform.position, entityZombie.transform.position);
                        HandleMiniMap(EntityType.Zombie, normalizePosition);
                    }

                    if (!EspUtils.IsOnScreen(vector) || !EspUtils.IsOnScreen(headPoint)) continue;

                    var height = Mathf.Abs(headPoint.y - vector.y);
                    var x = vector.x - height * 0.3f;
                    var y = Screen.height - headPoint.y;

                    if (vector.z <= 0f || dist > 200) continue;

                    var vector2 = GUIUtility.ScreenToGUIPoint(vector);
                    vector2.y = Screen.height - (vector2.y + 1f);

                    EspUtils.ApplyWireFrame(entityZombie, Color.red);

                    if (Time.time >= _lastChamTime && chamsEnabled)
                    {
                        if (Aimbot.CurrentSelectedEnemy != null && entityZombie == Aimbot.CurrentSelectedEnemy) ApplyChams(entityZombie, HandleEntityChamsColor(EntityType.Zombie));
                        else ApplyChams(entityZombie, entityZombie.ApproachingPlayer ? HandleEntityChamsColor(EntityType.Zombie) : Color.red);
                    }

                    if (!espEnabled) continue;
                    HandleEspTypes(espBox, espCornerBox, espEntityHealth, espHeadCircle, entityZombie.Health, entityZombie.GetMaxHealth(), EntityType.Zombie, headPoint, height, x, y);

                    if (espEntityInfo)
                    {
                        EspUtils.DrawString(new Vector2(vector.x, Screen.height - vector.y + 8f), string.Concat(
                            "Health: ",
                            entityZombie.Health,
                            "\nName: ",
                            entityZombie.EntityName,
                            "\nEntityClass: ",
                            entityZombie.EntityClass,
                            "\nSleeping: ",
                            entityZombie.IsSleeping,
                            "\nDistance: ",
                            dist,
                            "\nApproachingPlayer: ",
                            entityZombie.ApproachingPlayer), entityZombie.ApproachingPlayer ? ESPMenu.ApproachingPlayerColor : HandleEntityEspColor(EntityType.Zombie));
                    }
                }
            }

            var playerEspEnabled = Overlay.GetInstance().EspMenu.EnabledEntitesListView.FindItemWithText("Player");
            if (playerEspEnabled != null && playerEspEnabled.Text == @"Player")
            {
                if (Time.time >= _lastPlayerEspTime)
                {
                    _playerEntityObjects = FindObjectsOfType(typeof(EntityPlayer));
                    _lastPlayerEspTime = Time.time + 0.2f;
                }

                if (_playerEntityObjects == null || _playerEntityObjects.Length <= 0) return;
                foreach (var enemy in _playerEntityObjects)
                {
                    if (enemy == null) continue;
                    var entityPlayer = (EntityPlayer)enemy;
                    if (entityPlayer == null || entityPlayer.gameObject == null || entityPlayer.IsDead()) continue;

                    var dist = (int)Math.Ceiling(Vector3.Distance(Main.LocalPlayerEntity.transform.position, entityPlayer.transform.position));
                    var vector = _camera.WorldToScreenPoint(entityPlayer.transform.position);

                    var headPoint = _camera.WorldToScreenPoint(entityPlayer.emodel.GetHeadTransform().position);
                    
                    if (radarEnabled)
                    {
                        var normalizePosition = NormalizePosition(Main.LocalPlayerEntity.transform.position, entityPlayer.transform.position);
                        HandleMiniMap(EntityType.Player, normalizePosition);
                    }

                    if (!EspUtils.IsOnScreen(vector) || !EspUtils.IsOnScreen(headPoint)) continue;

                    var height = Mathf.Abs(headPoint.y - vector.y);
                    var x = vector.x - height * 0.3f; 
                    var y = Screen.height - headPoint.y;

                    if (vector.z <= 0f || dist > 200) continue;

                    var vector2 = GUIUtility.ScreenToGUIPoint(vector);
                    vector2.y = Screen.height - (vector2.y + 1f);

                    if (Time.time >= _lastChamTime && chamsEnabled)
                    {
                        if (Aimbot.CurrentSelectedEnemy != null && entityPlayer == Aimbot.CurrentSelectedEnemy) ApplyChams(entityPlayer, HandleEntityChamsColor(EntityType.Player));
                        else ApplyChams(entityPlayer, entityPlayer.ApproachingPlayer ? HandleEntityChamsColor(EntityType.Player) : Color.red);
                    }

                    if (!espEnabled) continue;
                    HandleEspTypes(espBox, espCornerBox, espEntityHealth, espHeadCircle, entityPlayer.Health, entityPlayer.GetMaxHealth(), EntityType.Player, headPoint, height, x, y);

                    if (espEntityInfo)
                    {
                        EspUtils.DrawString(new Vector2(vector.x, Screen.height - vector.y + 8f), string.Concat(
                            "Health: ",
                            entityPlayer.Health,
                            "\nName: ",
                            entityPlayer.EntityName,
                            "\nIsAdmin: ",
                            entityPlayer.IsAdmin,
                            "\nDistance: ",
                            dist,
                            "\nTotalKilledPlayers: ",
                            entityPlayer.KilledPlayers), HandleEntityEspColor(EntityType.Player));
                    }
                }
            }

            var animalEspEnabled = Overlay.GetInstance().EspMenu.EnabledEntitesListView.FindItemWithText("Animal");
            if (animalEspEnabled != null && animalEspEnabled.Text == @"Animal")
            {
                if (Time.time >= _lastAnimalEspTime)
                {
                    _animalEntityObjects = FindObjectsOfType(typeof(EntityAnimal));
                    _lastAnimalEspTime = Time.time + 0.2f;
                }

                if (_animalEntityObjects == null || _animalEntityObjects.Length <= 0) return;
                foreach (var enemy in _animalEntityObjects)
                {
                    if (enemy == null) continue;
                    var entityAnimal = (EntityAnimal)enemy;
                    if (entityAnimal == null || entityAnimal.gameObject == null || entityAnimal.IsDead()) continue;

                    var dist = (int)Math.Ceiling(Vector3.Distance(Main.LocalPlayerEntity.transform.position, entityAnimal.transform.position));
                    var vector = _camera.WorldToScreenPoint(entityAnimal.transform.position);

                    var headPoint = _camera.WorldToScreenPoint(entityAnimal.emodel.GetHeadTransform().position);

                    if (radarEnabled)
                    {
                        var normalizePosition = NormalizePosition(Main.LocalPlayerEntity.transform.position, entityAnimal.transform.position);
                        HandleMiniMap(EntityType.Animal, normalizePosition);
                    }

                    if (!EspUtils.IsOnScreen(vector) || !EspUtils.IsOnScreen(headPoint)) continue;

                    var height = Mathf.Abs(headPoint.y - vector.y);
                    var x = vector.x - height * 0.3f;
                    var y = Screen.height - headPoint.y;

                    if (vector.z <= 0f || dist > 200) continue;

                    var vector2 = GUIUtility.ScreenToGUIPoint(vector);
                    vector2.y = Screen.height - (vector2.y + 1f);

                    if (Time.time >= _lastChamTime && chamsEnabled)
                    {
                        if (Aimbot.CurrentSelectedEnemy != null && entityAnimal == Aimbot.CurrentSelectedEnemy) ApplyChams(entityAnimal, HandleEntityChamsColor(EntityType.Animal));
                        else ApplyChams(entityAnimal, entityAnimal.ApproachingPlayer ? HandleEntityChamsColor(EntityType.Animal) : Color.red);
                    }

                    if (!espEnabled) continue;
                    HandleEspTypes(espBox, espCornerBox, espEntityHealth, espHeadCircle, entityAnimal.Health, entityAnimal.GetMaxHealth(), EntityType.Unknown, headPoint, height, x, y);

                    if (espEntityInfo)
                    {
                        EspUtils.DrawString(new Vector2(vector.x, Screen.height - vector.y + 8f), string.Concat(
                            "Health: ",
                            entityAnimal.Health,
                            "\nName: ",
                            entityAnimal.EntityName,
                            "\nDistance: ",
                            dist,
                            "\nApproachingPlayer: ",
                            entityAnimal.ApproachingPlayer), entityAnimal.ApproachingPlayer ? ESPMenu.ApproachingPlayerColor : HandleEntityEspColor(EntityType.Unknown));
                    }
                }
            }
        }

        private void HandleEspTypes(bool espBox, bool espCornerBox, bool espEntityHealth, bool espHeadCircle, float health, float maxHealth, EntityType type, Vector3 headPoint, float height, float x, float y)
        {
            if (espBox)
            {
                EspUtils.OutlineBox(new Vector2(x - 1f, y - 1f), new Vector2((height / 2f) + 2f, height + 2f), HandleEntityEspColor(type));
                EspUtils.OutlineBox(new Vector2(x, y), new Vector2(height / 2f, height), HandleEntityEspColor(type));
                EspUtils.OutlineBox(new Vector2(x + 1f, y + 1f), new Vector2((height / 2f) - 2f, height - 2f), HandleEntityEspColor(type));
            }

            if (espCornerBox)
            {
                EspUtils.CornerBox(new Vector2(headPoint.x, y), height / 2f, height, 2f, HandleEntityEspColor(type), true);
            }

            if (espEntityHealth)
            {
                var percentage = health / maxHealth;
                var barHeight = height * percentage;

                var barColor = EspUtils.GetHealthColor(health, maxHealth);

                EspUtils.RectFilled(x - 5f, y, 4f, height, Color.black);
                EspUtils.RectFilled(x - 4f, y + height - barHeight - 1f, 2f, barHeight, barColor);
            }

            if (espHeadCircle)
            {
                EspUtils.DrawCircle(HandleEntityEspColor(type), new Vector2(headPoint.x, Screen.height - headPoint.y), 10);
            }
        }

        private void HandleMiniMap(EntityType type, Vector3 targetPos)
        {
            var angleToTarget = Mathf.Atan2(targetPos.x, targetPos.z) * Mathf.Rad2Deg;
            var anglePlayer = Main.LocalPlayerEntity.gameObject.transform.eulerAngles.y;
            var angleRadarDegrees = angleToTarget - anglePlayer - 90;

            var targetPosMagnitude = targetPos.magnitude;
            var angleRadians = angleRadarDegrees * Mathf.Deg2Rad;
            var enemyPosX = targetPosMagnitude * Mathf.Cos(angleRadians);
            var enemyPosY = targetPosMagnitude * Mathf.Sin(angleRadians);

            EspUtils.RectFilled(95 + enemyPosX, 95 + enemyPosY, 10, 10, HandleEntityEspColor(type));
        }

        private Vector3 NormalizePosition(Vector3 playerPos, Vector3 targetPos)
        {
            var targetPosX = (targetPos.x - playerPos.x) / 2;
            var targetPosZ = (targetPos.z - playerPos.z) / 2;

            return new Vector3(targetPosX, 0, targetPosZ);
        }

        private void ApplyChams(Entity entity, Color color)
        {
            foreach (var renderer in entity.GetComponentsInChildren<Renderer>())
            {
                renderer.material = _chamsMaterial;
                renderer.material.SetColor(_Color, color);
            }
        }

        private Color HandleEntityEspColor(EntityType entity)
        {
            switch (entity)
            {
                case EntityType.Zombie:
                    return ESPMenu.ZombieEspColor;
                case EntityType.Player:
                    return ESPMenu.PlayerEspColor;
                case EntityType.Animal:
                    return ESPMenu.AnimalEspColor;
                case EntityType.Unknown:
                    return ESPMenu.AnimalEspColor;
            }
            return Color.green;
        }

        private Color HandleEntityChamsColor(EntityType entity)
        {
            switch (entity)
            {
                case EntityType.Zombie:
                    return ESPMenu.ZombieChamsColor;
                case EntityType.Player:
                    return ESPMenu.PlayerChamsColor;
                case EntityType.Animal:
                    return ESPMenu.AnimalChamsColor;
                case EntityType.Unknown:
                    return ESPMenu.AnimalChamsColor;
            }
            return Color.green;
        }
    }
}