using UnityEngine;

namespace AG2163
{
    // Abstract class
    public abstract class Character : MonoBehaviour
    {
        public string characterName;
        public int health;

        public abstract void Attack();
    }
}