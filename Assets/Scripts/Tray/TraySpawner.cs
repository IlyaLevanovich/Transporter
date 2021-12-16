using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Tray
{
    public class TraySpawner : MonoBehaviour
    {
        [SerializeField] private TrayFreePlace _freePlace;
        [SerializeField] private GameObject _tray;
        [SerializeField] private Vector3 _spawnPosition;
        private TrayMovement _previousTray;

        private void Start()
        {
            CreateNewTray();
        }
        public async void CreateNewTray()
        {
            if (_previousTray != null) 
                _previousTray.IsMoving = true;

            await Task.Delay(1000);
            var newTray = Instantiate(_tray, _spawnPosition, Quaternion.identity);
            _previousTray = newTray.GetComponent<TrayMovement>();
            UpdateTrayFreePlace();
        }
        private void UpdateTrayFreePlace()
        {
            var data = _previousTray.GetComponent<TrayContainer>();
            _freePlace.FreePlace = data.FreePlace;
            _freePlace.Positions = data.Positions;
            _freePlace.Parent = _previousTray.transform;
            _freePlace.CurrentTray = data;
        }
    }
}