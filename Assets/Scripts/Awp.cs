using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StatePattern
{
    public class Awp : Weapon
    {
        public override void Shoot()
        {
            damage = 10f;
            print(damage);
            Bullet.damage = damage;
        }


    }
}
