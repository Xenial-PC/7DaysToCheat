using UnityEngine;
using System.Threading;

namespace _7DaysToCheat.Classes
{
    public class CreateMenu : MonoBehaviour
    {
        private static Thread _overlayThread;
        private static Overlay _overlay = Overlay.GetInstance();

        public void Start()
        {
            _overlayThread = new Thread(StartOverlayThread);
            _overlayThread.Start();
        }

        private void StartOverlayThread()
        {
            if (_overlay.IsDisposed) Overlay.OverlayInstance = new Overlay();
            ResourceHandler.InitResources();

            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.Run(_overlay);
        }
    }
}
