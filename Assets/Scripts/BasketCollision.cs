using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Collider))]
    public class BasketCollision : MonoBehaviour
    {
        [SerializeField] private Text _score;

        private void OnCollisionEnter(Collision collision)
        {
            _score.text = (int.Parse(_score.text) - 1).ToString();
            Destroy(collision.gameObject);
        }
    }
}