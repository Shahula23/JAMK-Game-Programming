using UnityEngine;

namespace AG2163
{
    public interface IDamageable
    {
        void TakeDamage(int damage);
    }
    class Enemy : IDamageable
    {
        public void TakeDamage(int damage)
        {
            Debug.Log("Enemy took " + damage + " damage!");
        }
    }
}