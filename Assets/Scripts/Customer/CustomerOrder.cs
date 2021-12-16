using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Customer
{
    public class CustomerOrder : MonoBehaviour
    {
        [SerializeField] private Image[] _orderUI;
        [SerializeField] private Sprite[] _sprites;
        private List<string> _order = new List<string>();
        public List<string> Order => _order;

        private void Start()
        {
            for (int i = 0; i < _orderUI.Length; i++)
            {
                if (Random.value >= 0.3f)
                {
                    _orderUI[i].gameObject.SetActive(true);
                    int value = Random.Range(0, _sprites.Length);
                    _orderUI[i].sprite = _sprites[value];
                    _order.Add(_sprites[value].name);
                }    
            }
        }
    }
}