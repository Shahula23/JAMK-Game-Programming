using UnityEngine;

namespace AG2163
{
    public class Inheritance : MonoBehaviour
    {
        void Start()
        {
            new Dog().MakeSound();
            new Cat().MakeSound();
        }
    }
}