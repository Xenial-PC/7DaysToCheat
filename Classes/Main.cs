using JetBrains.Annotations;
using UnityEngine;

namespace _7DaysToCheat.Classes
{
    public class Main : MonoBehaviour
    {
        [CanBeNull] public static EntityPlayer PlayerEntity;
        [CanBeNull] public static EntityPlayerLocal LocalPlayerEntity;
        [CanBeNull] public static GameObject EspGameObject, AimbotGameObject, ItemSpawnerGameObject, FreeCraftGameObject, WeaponGameObject, SceneDebuggerGameObject;
        [CanBeNull] public static Inventory Inventory;

        private static Overlay _overlay = Overlay.GetInstance();

        private static bool _start;
        private bool _showMenu = true;
        public static bool IsInitialized;

        private static bool _cacheData = true, _isEspEnabled, _isAimbotEnabled;

        private float _thirst, _stamina;
        private int _health;

        public void Start()
        {
            Overlay.GetInstance().EspMenu.EnableEspOptionCheckBox.Checked = false;
            Overlay.GetInstance().EspMenu.EnableRadarCheckBox.Checked = false;
            Overlay.GetInstance().EspMenu.EnableChamsCheckBox.Checked = false;

            _isEspEnabled = false;
            _isAimbotEnabled = false;
            _start = false;

            PlayerEntity = FindObjectOfType<EntityPlayer>();
            LocalPlayerEntity = FindObjectOfType<EntityPlayerLocal>();
            Inventory = LocalPlayerEntity.inventory;

            ItemSpawnerGameObject = new GameObject();
            ItemSpawnerGameObject.AddComponent<ItemSpawner>();
            DontDestroyOnLoad(ItemSpawnerGameObject);

            FreeCraftGameObject = new GameObject();
            FreeCraftGameObject.AddComponent<FreeCraft>();
            DontDestroyOnLoad(FreeCraftGameObject);

            WeaponGameObject = new GameObject();
            WeaponGameObject.AddComponent<WeaponModifier>();
            DontDestroyOnLoad(WeaponGameObject);

            /*SceneDebuggerGameObject = new GameObject();
            SceneDebuggerGameObject.AddComponent<SceneDebugger>();
            DontDestroyOnLoad(SceneDebuggerGameObject);*/
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Delete))
            {
                _showMenu = !_showMenu;

                if (_showMenu) _overlay.Show();
                else _overlay.Hide();
            }

            if (!GameManager.Instance.gameStateManager.IsGameStarted())
            {
                IsInitialized = false;
                return;
            }
            IsInitialized = true;

            if (Input.GetKeyDown(KeyCode.End)) Loader.Unload();
            if (Input.GetKeyDown(KeyCode.Insert)) _start = !_start;

            if (Input.GetKeyDown(KeyCode.X))
            {
                _isAimbotEnabled = !_isAimbotEnabled;
                if (_isAimbotEnabled)
                {
                    AimbotGameObject = new GameObject();
                    AimbotGameObject.AddComponent<Aimbot>();

                    DontDestroyOnLoad(AimbotGameObject);
                    return;
                }
                Destroy(AimbotGameObject);
            }

            if (Input.GetKeyDown(KeyCode.RightAlt))
            {
                LocalPlayerEntity.IsAdmin = true;
            }

            if (Input.GetKeyDown(KeyCode.Home))
            {
                _isEspEnabled = !_isEspEnabled;
                if (_isEspEnabled)
                {
                    EspGameObject = new GameObject();
                    EspGameObject.AddComponent<Esp>();

                    DontDestroyOnLoad(EspGameObject);
                    return;
                }
                Destroy(EspGameObject);
            }

            if (LocalPlayerEntity is null) return;

            if (_cacheData)
            {
                _stamina = LocalPlayerEntity.Stamina;
            }

            if (!_start && Input.GetKeyDown(KeyCode.Insert))
            {
                LocalPlayerEntity.Stamina = _stamina;
                _cacheData = true;
            }

            if (!_start) return;
            _cacheData = false;

            // Sets client stats to perm 10000
            LocalPlayerEntity.Stamina = float.MaxValue;
            LocalPlayerEntity.Health = int.MaxValue;
            LocalPlayerEntity.IsAdmin = true;
            LocalPlayerEntity.bExhausted = false;
            //LocalPlayerEntity.Stats.Entity.
        }
    }
}