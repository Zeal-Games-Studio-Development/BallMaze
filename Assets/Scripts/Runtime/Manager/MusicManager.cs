using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Data;
using ZealMVC.Runtime.Patterns;

public class MusicManager : ASingleton<MusicManager>
{
    public AudioSource _audioSource;
    [SerializeField] private MusicData[] listSong;

    protected override void Awake()
    {
        base.Awake();
    }


    public void ChangeSong(int songID)
    {
        _audioSource.clip = listSong[songID].clip;
        _audioSource.Play();
    }
}
