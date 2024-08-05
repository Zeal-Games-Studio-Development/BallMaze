//using AYellowpaper.SerializedCollections;
//using ZealMVC.Runtime.Enums;
//using ZealMVC.Runtime.Patterns;
//using System.Collections;
//using UnityEngine;

//namespace ZealMVC.Runtime.Manager
//{
//    public class GameSettings : ASingleton <GameSettings>
//    {
//        private BoolValue _musicSwitch;
//        private BoolValue _soundFXSwitch;
//        [SerializeField] private AudioSource _musicSource;
//        [SerializeField] private AudioSource _soundFXSource;
//        [SerializeField, SerializedDictionary("ID", "Sound")]
//        private SerializedDictionary<SoundFXID, AudioClip> _soundFXDataSource;

//        [SerializeField, SerializedDictionary("ID", "Sound")]
//        private SerializedDictionary<MusicID, AudioClip> _musicDataSource;
//        private void Start()
//        {
//            _musicSwitch = DataContainer.Instance.MusicSwitch;
//            _soundFXSwitch = DataContainer.Instance.SoundFXSwitch;
//            _musicSource.mute = !_musicSwitch.Value;
//            _soundFXSource.mute = !_soundFXSwitch.Value;
//        }

//        private void SoundFXOnChanged(bool isOn)
//        {
//            _soundFXSource.mute = !isOn;
//        }

//        private void MusicOnChanged(bool isOff) 
//        {
//            _musicSource.mute = !isOff;
//        }

//        public void PlaySound (SoundFXID ID)
//        {
//            _soundFXSource.PlayOneShot(_soundFXDataSource[ID]);
//        }

//        private void PlayMusic (MusicID ID)
//        {
//            _musicSource.clip = _musicDataSource[ID];
//            _musicSource.Play();
//        }

//        public void SwitchSound(bool isOn) => _soundFXSwitch.Value = isOn;
//        public void SwitchMusic(bool isOn) => _musicSwitch.Value = isOn;
//        public void SwitchShake(bool isOn) => _soundFXSwitch.Value = isOn;

//        public bool IsSoundOn => _soundFXSwitch.Value;
//        public bool IsMusicOn => _musicSwitch.Value;
//        public bool IsShakeOn => _soundFXSwitch.Value;

//        private IEnumerator SwitchToBackgroundOnEnd(MusicID musicID)
//        {
//            PlayMusic(musicID);
//            _musicSource.loop = false;
//            yield return new WaitUntil (() => !_musicSource.isPlaying);
//            yield return new WaitForSeconds(1f);
//            _musicSource.loop = true;
//            PlayMusic(MusicID.Background01);
//        }
//    }
//}
