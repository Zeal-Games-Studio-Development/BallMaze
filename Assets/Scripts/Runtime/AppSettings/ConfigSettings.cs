
using UnityEngine;

namespace ZealMVC.Runtime.AppSettings
{
    public class ConfigSettings : MonoBehaviour
    {
#if !UNITY_EDITOR
        private void Awake()
        {
            Application.targetFrameRate = 60;
            QualitySettings.vSyncCount = 0;
        }
#endif
    }
}
