using System.Collections;
using UnityEngine;
using System.Collections.Generic;

namespace Assets.Scripts.Tray
{
    public class TrayFreePlace : MonoBehaviour
    {
        public bool[] FreePlace { get; set; }
        public Stack<Vector3> Positions { get; set; }
        public Transform Parent { get; set; }
        public TrayContainer CurrentTray { get; set; }

    }
}