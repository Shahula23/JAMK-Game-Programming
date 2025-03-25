using UnityEngine;
using System;

namespace AG2163
{
    public class GreetSpanish : MonoBehaviour, IGreet
    {
        public void SayHello()
        {
            Debug.Log("¡Hola!");
        }
    }
}