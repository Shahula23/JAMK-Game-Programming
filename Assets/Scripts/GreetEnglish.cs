using UnityEngine;
using System;

namespace AG2163
{
    public class GreetEnglish : MonoBehaviour, IGreet
    {
        public void SayHello()
        {
            Debug.Log("Hello!");
        }
    }
}