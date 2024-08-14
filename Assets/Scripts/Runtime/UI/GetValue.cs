using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Data;
using ZealMVC.Runtime.Enums;

public class GetValue : MonoBehaviour
{

    public void SetSong(int id)
    {
        MusicManager.Instance.ChangeSong(id);
    }
}
