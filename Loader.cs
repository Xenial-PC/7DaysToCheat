using _7DaysToCheat.Classes;
using JetBrains.Annotations;
using UnityEngine;

namespace _7DaysToCheat
{
    public class Loader : MonoBehaviour
    {
        [CanBeNull] private static GameObject _injectGameObject;
        [CanBeNull] private static GameObject _loadMenuGameObject;

        public static void Load()
        {
            _loadMenuGameObject = new GameObject();
            _loadMenuGameObject.AddComponent<CreateMenu>();

            DontDestroyOnLoad(_loadMenuGameObject);
        }

        public static void LoadCheats()
        {
            _injectGameObject = new GameObject();
            _injectGameObject.AddComponent<Main>();
            DontDestroyOnLoad(_injectGameObject);
        }

        public static void Unload()
        {
            Destroy(Main.EspGameObject);
            Destroy(Main.AimbotGameObject);
            Destroy(Main.ItemSpawnerGameObject);
            Destroy(Main.FreeCraftGameObject);
            Destroy(Main.WeaponGameObject);
            Destroy(_loadMenuGameObject);
            Destroy(_injectGameObject);
        }

        public static void UnloadInGame()
        {
            Destroy(Main.EspGameObject);
            Destroy(Main.AimbotGameObject);
            Destroy(Main.ItemSpawnerGameObject);
            Destroy(Main.FreeCraftGameObject);
            Destroy(Main.WeaponGameObject);
            Destroy(_injectGameObject);
        }
    }
}