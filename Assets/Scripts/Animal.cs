using UnityEngine;

namespace AG2163
{
    public class Animal  // Base class
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }
    }
}