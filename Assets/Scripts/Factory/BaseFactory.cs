using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Factory
{
    public class BaseFactory : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;

        public GameObject Create(Vector3 spawnPosition)
        {
            var instance = Instantiate(_prefab, spawnPosition, Quaternion.identity);
            return instance;
        }
    }
}