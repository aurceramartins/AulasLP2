using System;
using System.Collections.Generic;
using System.Text;

namespace MyFornite
{
    class FNPlayer
    {

        int ammo;
        float health;

        public FNPlayer()
        {

        }

        public FNPlayer(int ammo, float health)
        {
            this.ammo = ammo;
            SetHealth(health);
        }

        public float Attack(FNPlayer enemy)
        {
            float damage = 10;
            enemy.TakeDamage(damage);
            return 0;
        }
        public void TakeDamage(float damage)
        {
            health -= damage;
        }
        public float GetHealth()
        {
            return health;
        }
        public void SetHealth(float health)
        {
            if(health <=100 && health > 0)
            {
                this.health = health;
            }
        }

    }
}
