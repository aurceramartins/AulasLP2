using System;
using System.Collections.Generic;
using System.Text;

namespace MyFornite
{
    class FNPlayer
    {

        public int Ammo { get; private set; }
        public float Health { get; private set; }

        public FNPlayer()
        {

        }

        public FNPlayer(int ammo, float health)
        {
            Ammo = ammo;
            Health = health;
        }

        public float Attack(FNPlayer enemy)
        {
            float damage = 10;
            enemy.TakeDamage(damage);
            return 0;
        }
        public void TakeDamage(float damage)
        {
            Health -= damage;
        }


    }
}
