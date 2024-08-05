using System;
using UnityEngine;

namespace ZealMVC.Runtime.Manager
{
    [Serializable]
    public class DataContainer
    {
        public const string DATA_KEY = "DATA_SERVICE";
        public static DataContainer Instance;
        [Header("=== User Data ===")]

        public IntValue Level;
        public IntValue Coin;
        public IntValue Score;
        public StringValue Username;
        public LevelValue LevelData;

        [Header("=== Game Settings ===")]
        public BoolValue MusicSwitch;
        public BoolValue SoundFXSwitch;
        public BoolValue VibrationSwitch;
    }
}
