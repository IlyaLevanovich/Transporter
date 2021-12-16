using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Customer
{
    public class CustomerTimer : MonoBehaviour
    {
        [SerializeField] private Image _timerBar;
        private CustomerMovement _movement;
        private float _timer;
        private int _startTimerValue;

        private void Start()
        {
            _movement = GetComponent<CustomerMovement>();
            _startTimerValue = Random.Range(5, 10);
            _timer = _startTimerValue;
        }
        private void Update()
        {
            _timer -= Time.deltaTime;
            _timerBar.fillAmount = _timer / _startTimerValue;
            if (_timer <= 0)
            {
                _movement.GetOut();
                GetComponent<CustomerCollision>().ChangeScore(-1);
                this.enabled = false;
            } 
        }
    }
}