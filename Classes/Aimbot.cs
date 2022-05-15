using System;
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
        private bool _isFovEnabled;
        private float _distX, _distY;
        public static bool IsFovAimbot;
        public static EntityEnemy CurrentSelectedEnemy;

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public void Start()
        {
            _isFovEnabled = false;
            Overlay.GetInstance().EnableFOVAimbotCheckBox.Checked = false;
            IsFovAimbot = false;
        }

        public void Awake()
        {
            _camera = Camera.main;
        }

        public void Update()
        {
            var minDistance = 99999f;
            var aimTarget = Vector2.zero;
            var oldDist = 99999f;
            var newDist = 0f;

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

                var screenPoint = _camera.WorldToScreenPoint(entityEnemy.emodel.GetHeadTransform().position);
                if (entityEnemy.Health <= 0 || !entityEnemy.IsAlive()) continue;

                if (!IsOnScreen(screenPoint)) continue;

                if (IsFovAimbot)
                {
                    var dist = Math.Abs(Vector2.Distance(new Vector2(screenPoint.x, Screen.height - screenPoint.y), new Vector2(Screen.width / 2, Screen.height / 2)));
                    if (dist >= 150) continue;
                    if (dist >= minDistance) continue;

                    minDistance = dist;
                    aimTarget = new Vector2(screenPoint.x, Screen.height - screenPoint.y);
                    _enemyDistance = (int)Math.Ceiling(Vector3.Distance(Main.LocalPlayerEntity.transform.position, entityEnemy.transform.position));
                    CurrentSelectedEnemy = entityEnemy;
                }
                else
                {
                    if (newDist >= oldDist || newDist >= 250) continue;
                    oldDist = newDist;

                    aimTarget = new Vector2(screenPoint.x, Screen.height - screenPoint.y);
                    _enemyDistance = (int)Math.Ceiling(Vector3.Distance(Main.LocalPlayerEntity.transform.position, entityEnemy.transform.position));
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

            if (Input.GetKeyDown(KeyCode.PageUp))
            {
                Overlay.GetInstance().EnableFOVAimbotCheckBox.Checked =
                    !Overlay.GetInstance().EnableFOVAimbotCheckBox.Checked;
            }

            if (Input.GetKeyDown(KeyCode.PageDown)) _isFovEnabled = !_isFovEnabled;

            if (!_isFovEnabled) return;
            var weapon = Main.LocalPlayerEntity.vp_FPWeapon;
            weapon.BobRate = Vector4.zero;
            weapon.ShakeAmplitude = Vector3.zero;
            weapon.RenderingFieldOfView = 120f;
            weapon.StepForceScale = 0f;
        }

        public static bool IsOnScreen(Vector3 position)
        {
            return position.y > 0.01f && position.y < Screen.height - 5f && position.z > 0.01f;
        }
    }
}