using UnityEngine;

namespace AG2163
{
    public class Dog : Animal  // Inherits from Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Woof!");
        }
    }
}