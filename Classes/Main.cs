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

            AimbotGameObject = new GameObject();
            AimbotGameObject.AddComponent<Aimbot>();
            DontDestroyOnLoad(AimbotGameObject);

            EspGameObject = new GameObject();
            EspGameObject.AddComponent<Esp>();
            DontDestroyOnLoad(EspGameObject);

            GetAllItems.GetAllGunsRecoil();

            /*SceneDebuggerGameObject = new GameObject();
            SceneDebuggerGameObject.AddComponent<SceneDebugger>();
            DontDestroyOnLoad(SceneDebuggerGameObject);*/

            /*var navObjectCopy = LocalPlayerEntity.Waypoints.List[0].navObject;

            var zombieWaypoint = new Waypoint();
            zombieWaypoint.name = "Test2";
            zombieWaypoint.entityId = -1;
            zombieWaypoint.ownerId = -1;
            zombieWaypoint.pos = new Vector3i(new Vector3(120, 120, 120));
            zombieWaypoint.MapObjectKey = 0;
            zombieWaypoint.icon = "ui_game_symbol_map_fortress";
            var waypointNavObject = navObjectCopy;
            waypointNavObject.SetupNavObjectClass("waypoint");
            waypointNavObject.NavObjectClass.IsOnMap(true);
            waypointNavObject.NavObjectClass.IsOnCompass(true);
            zombieWaypoint.navObject = waypointNavObject;
            LocalPlayerEntity.Waypoints.List.Add(zombieWaypoint);*/

            //GameManager.Instance.persistentPlayers.GetPlayerDataFromEntityID()
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