//using ZealMVC.Runtime.Config;
//using ZealMVC.Runtime.Patterns;
//using System.Linq;
//using UnityEngine;

//namespace ZealMVC.Runtime.Manager
//{
//    public class LevelInstantiator : ASingleton<LevelInstantiator>
//    {
//        private const string LEVEL_PREFIX = "Level";
//        private GameObject[] _gameLevels;

//        private GameObject _currentLevel;
//        private IntValue _level;
//        protected override void Awake()
//        {
//            base.Awake();
//            PreloadLevel();
//            _level = DataContainer.Instance.Level;
//        }

//        public int LevelCount => _gameLevels.Length;
//        private void PreloadLevel()
//        {
//            _gameLevels = Resources.LoadAll<GameObject>(PathDirectory.LEVEL_DATA_PATH)
//                .Where(e => e.TryGetComponent(out RuntimeGameDataManager manager) && e.name.StartsWith(LEVEL_PREFIX)).ToArray();
//        }

//        private void LoadLevel(int level)
//        {
//            UnloadLevel();
//            var gameLevel = _gameLevels.FirstOrDefault(e => e.name.StartsWith($"{LEVEL_PREFIX} {level}"));
//            if (gameLevel == null)
//            {
//                throw new System.Exception($"There is no current level {level}");
//            }
//            else
//            {
//                _currentLevel = Instantiate(gameLevel);
//            }
//        }

//        public void UnloadLevel()
//        {
//            if (_currentLevel != null)
//            {
//                Destroy(_currentLevel);
//                RuntimeGameDataManager.Instance = null;
//                _currentLevel = null;
//            }
//        }

//        /// <summary>
//        /// Load level hiện tại dựa trên Data Tracker
//        /// </summary>
//        public void ReloadCurrentLevel()
//        {
//            LoadLevel(_level.Value);
//        }

//        public void LoadLevelByOption(int level)
//        {
//            _level.Value = level;
//            LoadLevel(level);
//        }
//    }
//}
