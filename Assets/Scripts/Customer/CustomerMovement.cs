using UnityEngine;

namespace Assets.Scripts.Customer
{
    public class CustomerMovement : MonoBehaviour
    {
        public Transform Target { get; set; }
        public Transform EndPosition { get; set; }
        [SerializeField] private float _speed;

        private void Update()
        {
            if(Target != null)
                transform.position = Vector3.MoveTowards(transform.position, Target.position, _speed);
        }
        public void GetOut()
        {
            Target = EndPosition;
        }
    }
}

