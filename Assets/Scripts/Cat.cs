using UnityEngine;

namespace AG2163
{
    public class Cat : Animal  // Inherits from Animal
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
    }
}