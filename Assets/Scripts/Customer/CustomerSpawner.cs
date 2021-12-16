using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Customer
{
    public class CustomerSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _customer;
        [SerializeField] private List<Transform> _targets = new List<Transform>();
        [SerializeField] private Transform _endPosition;
        private int _currentTarget = 0;

        private void Start()
        {
            StartCoroutine(Spawn());
        }
        private IEnumerator Spawn()
        {
            while(true)
            {
                yield return new WaitForSeconds(5);
                if(_targets.Count > 0)
                {
                    var customer = Instantiate(_customer, new Vector3(0, 0.5f, 3), Quaternion.identity);
                    CustomerInit(customer);
                }
            }
        }
        private void CustomerInit(GameObject customer)
        {
            var customerMovement = customer.GetComponent<CustomerMovement>();
            customerMovement.Target = SelectTarget();
            customerMovement.EndPosition = _endPosition;
        }
        private Transform SelectTarget()
        {
            if (_currentTarget < _targets.Count - 1)
            {
                _currentTarget++;
                return _targets[_currentTarget];
            }
            else
            {
                _currentTarget = 0;
                return _targets[_currentTarget];
            }
        }
    }
}