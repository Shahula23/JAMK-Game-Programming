using UnityEngine;

namespace AG2163
{
    // Class inheriting from Character
    public class Warrior : Character
    {
        public int attackPower = 10;

        void Start()
        {
            characterName = "Warrior";
            health = 100;
            Attack();
        }
        public override void Attack()
        {
            Debug.Log(characterName + " attacks with power: " + attackPower);
        }
    }
}