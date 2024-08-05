using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Test
{
    public class TestJoystick : MonoBehaviour
    {
        public void Update()
        {
            Debug.Log(Joystick.Instance.Direction);
        }
    }
}