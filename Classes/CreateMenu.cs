using UnityEngine;
using System.Threading;

namespace C7D2C.Classes
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
            ResourceHandler.InitResources();

            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.Run(_overlay);
        }
    }
}
