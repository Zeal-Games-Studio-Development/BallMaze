using UnityEngine;

namespace Assets.Scripts.Game
{
    [RequireComponent(typeof(Rigidbody))]
    public class Ball : MonoBehaviour
    {
        [SerializeField, Range(1f, 5f)] private float _speed = 1f;
        private Rigidbody _rb;
        [SerializeField] protected Vector3 direction;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }
        private void FixedUpdate()
        {
            MoveToDirection();
        }

        private void MoveToDirection()
        {
            direction = new Vector3(Joystick.Instance.Horizontal, 0, Joystick.Instance.Vertical);
            _rb.velocity += Time.fixedDeltaTime * _speed * direction;
        }
    }
}