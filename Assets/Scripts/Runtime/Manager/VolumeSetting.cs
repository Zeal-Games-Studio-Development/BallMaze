using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using ZealMVC.Runtime.Manager;

public class VolumeSetting : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;

    private void Start()
    {
        musicSlider.value = DataContainer.Instance.MusicSwitch.Value;
        
    }

    public void SetMusicVolume()
    {
        DataContainer.Instance.MusicSwitch.Value = musicSlider.value;
        
        myMixer.SetFloat("music", DataContainer.Instance.MusicSwitch.Value);
    }
}
