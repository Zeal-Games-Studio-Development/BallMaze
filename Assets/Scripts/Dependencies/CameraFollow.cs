using UnityEngine;

namespace Assets.Scripts.Dependencies
{
    [RequireComponent(typeof(Camera))]
    public class CameraFollow : MonoBehaviour
    {
        public Transform Target;

        [SerializeField] private Vector3 _followOffset;
        [SerializeField] private Vector3 _lookAtOffset;

        private void LateUpdate()
        {
            FollowAndLookAtTarget();
        }

        private void FollowAndLookAtTarget()
        {
            if (Target == null) return;
            transform.position = Target.position + _followOffset;
            transform.LookAt(Target.position + _lookAtOffset);
        }
    }
}
