using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace _7DaysToCheat
{
    public class Main : MonoBehaviour
    {
        [DllImport("kernel32.dll")]
        internal static extern Boolean AllocConsole();

        private readonly EntityPlayer _playerEntity = FindObjectOfType<EntityPlayer>();
        private readonly EntityPlayerLocal _localPlayerEntity = FindObjectOfType<EntityPlayerLocal>();
        private static GameObject _espGameObject;

        private static bool _start;
        public static bool IsInitialized;

        private static bool _cacheData = true, _isEspEnabled;

        private float _thirst, _stamina;
        private int _health;

        public void Start()
        {
            //AllocConsole(); // for debugging
        }

        public void Update()
        {
            if (!GameManager.Instance.gameStateManager.IsGameStarted())
            {
                IsInitialized = false;
                return;
            }
            IsInitialized = true;

            if (Input.GetKeyDown(KeyCode.End)) Loader.Destroy();
            if (Input.GetKeyDown(KeyCode.Insert)) _start = !_start;

            if (Input.GetKeyDown(KeyCode.Home))
            {
                _isEspEnabled = !_isEspEnabled; // flips the bool from what it was prior
                if (_isEspEnabled) // if its true it will create a new GameObject of type ESP
                {
                    _espGameObject = new GameObject();
                    _espGameObject.AddComponent<Esp>();

                    DontDestroyOnLoad(_espGameObject); //  makes sure the esp doesn't get destroyed if you change scenes 
                }
                else Destroy(_espGameObject); // destroys it if _isEspEnabled is false
            }

            if (_cacheData) // caches current data of the local player entity
            {
                _stamina = _localPlayerEntity.Stamina;
            }

            if (!_start && Input.GetKeyDown(KeyCode.Insert)) // takes the cached data and inputs back the data to what it was prior
            {
                _localPlayerEntity.Stamina = _stamina;
                _cacheData = true;
            }

            if (!_start) return; // Inverted for now to keep nesting to a minimum 

            // Stops Caching the stat values
            _cacheData = false;

            // Sets client stats to perm 10000
            _localPlayerEntity.Stats.Stamina.Value = 10000; // This is held on the clients side (as for health is not and nothing else is)
            _localPlayerEntity.Stealth.noiseVolume = 0;
            _localPlayerEntity.Stealth.smell = 0;
        }

        public void OnGUI()
        {
            GUI.Label(new Rect(0, Screen.height / 2f, 120, 120), $@"Init time {_localPlayerEntity.spawnInTime}");
        }
    }
}