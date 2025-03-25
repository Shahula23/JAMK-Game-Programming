using UnityEngine;
using System;

namespace AG2163
{
    public class GreetUser : MonoBehaviour
    {
        public GreetEnglish greetEnglish; 
        public GreetSpanish greetSpanish;

        void Start()
        {
            greetEnglish.SayHello();
            greetSpanish.SayHello();
        }
    }
}