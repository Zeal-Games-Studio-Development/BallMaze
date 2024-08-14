using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZealMVC.Runtime.Enums;
using ZealMVC.Runtime.Manager;

namespace ZealMVC.Runtime.Data
{
    [Serializable]
    public class MusicData : ADataBinding<MusicID> 
    {
        public AudioClip clip;

    }
}
