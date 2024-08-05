using ZealMVC.Runtime.Patterns;
using System;
using UnityEngine;

namespace ZealMVC.Runtime.Manager
{
    public class InputController : ASingleton<InputController>
    {
        public Action<Vector3> OnTouchBegan;
        public Action<Vector3> OnTouchEnded;
        public Action<Vector3> OnTouchMoved;

        private void Update()
        {
            TouchPositionUpdate();

        }

        private void TouchPositionUpdate()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                switch (touch.phase)
                {
                    case TouchPhase.Began:
                        OnTouchBegan?.Invoke(touch.position);
                        break;
                    case TouchPhase.Moved:
                        OnTouchMoved?.Invoke(touch.position);
                        break;
                    case TouchPhase.Ended:
                        OnTouchEnded?.Invoke(touch.position);
                        break;
                }
            }
        }

        private void OnDestroy()
        {
            OnTouchBegan = null;
            OnTouchMoved = null;
            OnTouchEnded = null;
        }
    }
}
