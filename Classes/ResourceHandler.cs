using System.IO;
using System.Reflection;
using InControl.UnityDeviceProfiles;
using UnityEngine;

namespace _7DaysToCheat.Classes
{
    class ResourceHandler
    {
        public static AssetBundle CheatBundle;
        public static Shader WireFrameShader;

        public static void ExtractResourceToFile(string resourceName, string filename)
        {
            if (File.Exists(filename)) return;

            var s = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            var fs = new FileStream(filename, FileMode.Create);

            var b = new byte[s.Length];

            s.Read(b, 0, b.Length);
            fs.Write(b, 0, b.Length);
        }

        public static void InitResources()
        {
            if (!File.Exists($@"{Directory.GetCurrentDirectory()}/cheatbundle.unity3d"))
                ExtractResourceToFile("_7DaysToCheat.ResourcesFolder.cheatbundle.unity3d", $@"{Directory.GetCurrentDirectory()}/cheatbundle.unity3d");
        }

        public static void InitAssetBundle()
        {
            CheatBundle = AssetBundle.LoadFromFile($@"{Directory.GetCurrentDirectory()}/cheatbundle.unity3d");
            CheatBundle.LoadAllAssets();

            WireFrameShader = CheatBundle.LoadAsset<Shader>("wireframetransparent");
        }

        public static void UnloadAssetBundle()
        {

        }

        public static class MaterialCreator
        {
            public static Material GetMaterial(string path, int width, int height, string gameObjectName)
            {
                var selected = LoadImage(path, width, height);
                selected.name = gameObjectName;

                var material = new Material(Shader.Find("Unlit/Texture"))
                {
                    mainTexture = selected
                };

                return material;
            }

            public static Texture2D LoadImage(string filename, int width, int height)
            {
                var bytes = File.ReadAllBytes(filename);

                var texture = new Texture2D(width, height);
                texture.LoadImage(bytes);
                
                return texture;
            }
        }
    }
}
