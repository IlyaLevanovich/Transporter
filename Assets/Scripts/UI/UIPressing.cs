using Assets.Scripts.Factory;
using Assets.Scripts.Tray;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI
{
    public class UIPressing : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private BaseFactory _factory;
        [SerializeField] private TrayFreePlace _trayFreePlace;
        [SerializeField] private string _productName;

        public void OnPointerClick(PointerEventData eventData)
        {
            if(IsFreePlace())
            {
                var instance = _factory.Create(_trayFreePlace.Positions.Pop());
                instance.transform.SetParent(_trayFreePlace.Parent);
                _trayFreePlace.CurrentTray.Content.Add(_productName);
            }  
        }

        private bool IsFreePlace()
        {
            for (int i = 0; i < _trayFreePlace.FreePlace.Length; i++)
            {
                if (_trayFreePlace.FreePlace[i])
                {
                    _trayFreePlace.FreePlace[i] = false;
                    return true;
                }
            }
            return false;
        }
    }
}

