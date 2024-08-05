using ZealMVC.Runtime.Utils;
using UnityEngine;

namespace ZealMVC.Runtime.Manager
{
    public class DataInitialization : MonoBehaviour
    {
        [SerializeField] private DataContainer _dataContainer;
        private void Awake()
        {
            LoadData();
        }

        private void SaveData()
        {
            var toJson = JsonUtility.ToJson(_dataContainer);
            PlayerPrefs.SetString (DataContainer.DATA_KEY, toJson);
        }

        private void LoadData()
        {
            var dataJson = PlayerPrefs.GetString(DataContainer.DATA_KEY);
            if (!string.IsNullOrEmpty(dataJson))
            {
                JsonUtility.FromJsonOverwrite(dataJson, _dataContainer);
            }
            else
            {
                _dataContainer.Username.Value = StringHelper.RandomUsername();
            }
            DataContainer.Instance = _dataContainer;
        }
#if !UNITY_EDITOR
        private void OnApplicationPause(bool paused)
        {
            if (paused)
            {
                SaveData();
            }
        }
#else
        private void OnApplicationQuit()
        {
            SaveData();
        }
#endif
    }
}
