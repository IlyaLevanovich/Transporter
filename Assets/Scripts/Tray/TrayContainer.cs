using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Tray
{
    public class TrayContainer : MonoBehaviour
    {
        public List<string> Content { get; set; } = new List<string>();
        public bool[] FreePlace { get; } = { true, true, true };
        public Stack<Vector3> Positions { get; } = new Stack<Vector3>();

        private void Start()
        {
            Positions.Push(new Vector3(-2.45f, 0.5f, -1f));
            Positions.Push(new Vector3(-2.25f, 0.5f, -1.1f));
            Positions.Push(new Vector3(-2.3f, 0.5f, -0.9f));
        }

    }
}