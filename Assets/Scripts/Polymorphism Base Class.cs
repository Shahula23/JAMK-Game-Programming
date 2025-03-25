using System;
using UnityEngine;

namespace AG2163
{
    public class PolymorphismBaseClass : MonoBehaviour
    {
        public virtual void ShowMessage()
        {
            Debug.Log("Hello from the base!");
        }
        void Start()
        {
            ShowMessage();
        }
    }
}