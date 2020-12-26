using UnityEngine;

namespace _7DaysToCheat
{
    public class Loader : MonoBehaviour
    {
        private static GameObject _injectGameObject;

        public static void Load()
        {
            _injectGameObject = new GameObject();
            _injectGameObject.AddComponent<Main>();

            DontDestroyOnLoad(_injectGameObject);
        }

        public static void Destroy()
        {
            Destroy(_injectGameObject);
        }
    }
}