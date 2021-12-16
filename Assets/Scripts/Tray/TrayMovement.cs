using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Tray
{
    [RequireComponent(typeof(Rigidbody))]
    public class TrayMovement : MonoBehaviour
    {
        public bool IsMoving { get; set; }
        [SerializeField, Range(0.1f, 1)] private float _speed;
        private Rigidbody _rigidbody;

        private void Start()
        {
            IsMoving = false;
            _rigidbody = GetComponent<Rigidbody>();
        }
        private void FixedUpdate()
        {
            if(IsMoving)
            {
                _rigidbody.MovePosition(transform.position + Vector3.right * _speed * Time.fixedDeltaTime);
            }
        }
    }
}