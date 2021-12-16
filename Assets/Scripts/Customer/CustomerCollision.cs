using Assets.Scripts.Tray;
using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.Customer
{
    [RequireComponent(typeof(Collider))]
    public class CustomerCollision : MonoBehaviour
    {
        public Text Score { get; private set; }
        private CustomerOrder _order;
        private CustomerMovement _movement;
         

        private void Start()
        {
            _order = GetComponent<CustomerOrder>();
            _movement = GetComponent<CustomerMovement>();
            Score = FindObjectOfType<Text>();
        }
        private void OnTriggerEnter(Collider other)
        {
            var tray = other.gameObject.GetComponent<TrayContainer>();
            if (tray != null)
            {
                if (CompareOrder(tray.Content, _order.Order))
                {
                    Destroy(other.gameObject);
                    _movement.GetOut();
                    ChangeScore(1);
                }
            }
            if (other.gameObject.name == "End")
                Destroy(gameObject);
        }
        private bool CompareOrder(List<string> first, List<string> second)
        {
            if (first.Count != second.Count) return false;
            else
            {
                first.Sort();
                second.Sort();
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i] != second[i])
                        return false;
                }
            }
            return true;
        }
        public void ChangeScore(int value)
        {
            Score.text = (int.Parse(Score.text) + value).ToString();
        }
    }
}