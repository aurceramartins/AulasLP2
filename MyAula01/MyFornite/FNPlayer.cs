using System;
using System.Collections.Generic;
using System.Text;

namespace MyFornite
{
    class FNPlayer
    {
        public int ammo;
        public float health;

        public float Attack(FNPlayer enemy)
        {
            float damage = 10;
            enemy.TakeDamage(damage);
            return 0;
        }
        public void  TakeDamage(float damage)
        {
            health -= damage;
        }
    }
}
